using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Find_And_Organize
{
    public partial class frm_resultado : Form
    {
        public frm_resultado()
        {
            InitializeComponent();
        }

        Tipo imagens = new Tipo("Imagem");
        Tipo musicas = new Tipo("Musica");
        Tipo videos = new Tipo("Video");
        Tipo documentos = new Tipo("Documento");

        public bool imagem { get; set; }
        public bool musica { get; set; }
        public bool video { get; set; }
        public bool documento { get; set; }

        public string origem { get; set; }

        int duplicatas = 0;
        int workers = 0;

        List<structs.Arquivo> arquivos = new List<structs.Arquivo>();

        private void frm_resultado_Load(object sender, EventArgs e)
        {
            progresso.Style = ProgressBarStyle.Marquee;
            backArvore.RunWorkerAsync();
        }

        private void CriarLista(string chave)
        {
            ListView list = new ListView();
            list.Location = new Point(0, 0);
            list.Columns.Add("Arquivo");
            list.View = View.Details;
            list.CheckBoxes = true;
            list.Dock = DockStyle.Fill;
            list.Columns[0].Width = 500;
            list.MultiSelect = false;
            list.ContextMenuStrip = menu;

            tabControl1.TabPages[chave].Controls.Add(list);
        }

        private void backArvore_DoWork(object sender, DoWorkEventArgs e)
        {
            IEnumerable<string> arquivo = Pesquisa.Arvore(origem);
            int i = 0;
            foreach (string a in arquivo)
            {
                try
                {
                    string nome = a.Substring(a.LastIndexOf(@"\") + 1, a.Length - a.LastIndexOf(@"\") - 1);
                    string ext = a.Substring(a.LastIndexOf("."), a.Length - a.LastIndexOf("."));
                    string caminho = a.Substring(0, a.LastIndexOf(@"\") + 1);
                    arquivos.Add(new structs.Arquivo(i, nome, caminho, ext));
                }
                catch { }
                i++;
            }
        }

        private void backArvore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresso.Style = ProgressBarStyle.Continuous;
            progresso.Maximum = arquivos.Count;
            lbl_status.Text = "Analizando...";
            backSeparacao.RunWorkerAsync();
        }

        private void backSeparar_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < arquivos.Count; i++)
            {
                backSeparacao.ReportProgress(0);

                string caminho = arquivos[i].caminho;
                string extensao = arquivos[i].extensao;
                string nome = arquivos[i].nome;

                string tipo = Pesquisa.VefTipo(extensao);

                if (tipo == null)
                    continue;

                if (imagem && tipo == "IMG")
                    imagens.conteudo.Add(new ListaDupli(i, nome, caminho, extensao));

                if (musica && tipo == "MUS")
                    musicas.conteudo.Add(new ListaDupli(i, nome, caminho, extensao));

                if (video && tipo == "VID")
                    videos.conteudo.Add(new ListaDupli(i, nome, caminho, extensao));

                if (documento && tipo == "DOC")
                    documentos.conteudo.Add(new ListaDupli(i, nome, caminho, extensao));
            }
        }

        private void backSeparacao_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progresso.PerformStep();
        }

        private void backSeparacao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl_status.Text = "Verificando...";
            progresso.Value = 0;
            progresso.Style = ProgressBarStyle.Marquee;

            if (imagens.conteudo.Count != 0)
                backImagem.RunWorkerAsync(imagens);

            if (musicas.conteudo.Count != 0)
                backMusica.RunWorkerAsync(musicas);

            if (videos.conteudo.Count != 0)
                backVideo.RunWorkerAsync(videos);

            if (documentos.conteudo.Count != 0)
                backDocumento.RunWorkerAsync(documentos);

            if (workers == 0)
                WorkersCompleted();
        }

        private void EqualsDoWork(object sender, DoWorkEventArgs e)
        {
            workers++;
            bool diferente = false;
            bool enviar = false;
            bool primeiro = false;
            Tipo t = (Tipo)e.Argument;

            int grupos = 1;
            for (int i = 0; i < t.conteudo.Count; i++)
            {
                if (((BackgroundWorker)sender).CancellationPending) //Verifica se o usuario cancelou a operacao.
                    break;
                try
                {
                    enviar = false;
                    primeiro = true;
                    long arq1 = new FileInfo(t.conteudo[i].caminho + t.conteudo[i].nome).Length;
                    byte[] arq1_bin = File.ReadAllBytes(t.conteudo[i].caminho + t.conteudo[i].nome);

                    for (int i2 = i + 1; i2 < t.conteudo.Count; i2++)
                    {
                        diferente = false;
                        if (!t.conteudo[i2].verificado && t.conteudo[i].extensao == t.conteudo[i2].extensao)
                        {
                            long arq2 = new FileInfo(t.conteudo[i2].caminho + t.conteudo[i2].nome).Length;
                            if (arq1 == arq2)
                            {
                                byte[] arq2_bin = File.ReadAllBytes(t.conteudo[i2].caminho + t.conteudo[i2].nome);
                                for (int b = 0; b < arq1_bin.Length; b++)
                                {
                                    if (arq1_bin[b] != arq2_bin[b])
                                        diferente = true;
                                }
                                if (!diferente)
                                {
                                    if (primeiro)
                                    {
                                        ListViewItem lista_arq1 = new ListViewItem(t.conteudo[i].caminho + t.conteudo[i].nome, new ListViewGroup(grupos.ToString()));
                                        lista_arq1.Checked = false;
                                        t.iguais.Enqueue(lista_arq1);
                                        primeiro = false;
                                    }

                                    ListViewItem lista_arq2 = new ListViewItem(t.conteudo[i2].caminho + t.conteudo[i2].nome, new ListViewGroup(grupos.ToString()));
                                    lista_arq2.Checked = true;

                                    t.conteudo[i2].verificado = true;
                                    t.iguais.Enqueue(lista_arq2);
                                    enviar = true;
                                }
                            }
                        }
                    }
                    if (enviar)
                    {
                        grupos++;
                        duplicatas++;
                        ((BackgroundWorker)sender).ReportProgress(0, t);
                    }
                }catch(Exception ex){}
            }
        }
    
        private void EqualsProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string name = ((Tipo)e.UserState).nome;
            if (!tabControl1.TabPages.ContainsKey(name))
            {
                tabControl1.TabPages.Add(name, name);
                CriarLista(name);
            }
            ListView l = (ListView)tabControl1.TabPages[name].Controls[0];
            lbl_duplicatas.Text = "Duplicatas Encontradas:\n" + Environment.NewLine + duplicatas;
            while (((Tipo)e.UserState).iguais.Count > 0)
            {
                ListViewItem arq = ((Tipo)e.UserState).iguais.Dequeue();
                ListViewGroup grupo = new ListViewGroup(arq.Group.Header, arq.Group.Header);
                l.Groups.Add(grupo);
                arq.Group = l.Groups[grupo.Header];
                l.Items.Add(arq);
            }
        }

        private void EqualsRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            workers--;
            if (workers == 0)
                WorkersCompleted();
        }

        private void btn_sel_Click(object sender, EventArgs e)
        {
            ListView l = (ListView)tabControl1.SelectedTab.Controls[0];
            foreach (ListViewItem li in l.Items)
                li.Checked = true;
        }

        private void btn_des_Click(object sender, EventArgs e)
        {
            ListView l = (ListView)tabControl1.SelectedTab.Controls[0];
            foreach (ListViewItem li in l.Items)
                li.Checked = false;
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja deletar os arquivos selecionados ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                frm_deletar f = new frm_deletar();
                foreach (TabPage t in tabControl1.TabPages)
                {
                    ListView l = (ListView)t.Controls[0];
                    foreach (ListViewItem i in l.Items)
                        if (i.Checked)
                            f.arquivos.Add(i.Text);
                }
                if (f.arquivos.Count != 0)
                {
                    foreach (Control c in Application.OpenForms[0].Controls)
                    {
                        if (c.Tag != null)
                        {
                            Panel p = (Panel)c;
                            f.TopLevel = false;
                            f.Size = p.Size;
                            this.Hide();
                            p.Controls.Add(f);
                            f.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum arquivo selecionado para deletar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menu_Opening(object sender, CancelEventArgs e)
        {
            TabPage t = tabControl1.SelectedTab;
            ListView l = (ListView)t.Controls[0];
            if (l.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void WorkersCompleted()
        {
            if (duplicatas == 0)
            {
                lbl_status.Visible = true;
                lbl_status.Text = "Nada Encontrado";
                btn_deletar.Visible = false;
            }
            else
            {
                lbl_status.Visible = false;
                btn_des.Enabled = true;
                btn_sel.Enabled = true;
                btn_deletar.Visible = true;
                btn_deletar.Focus();
            }
            progresso.Visible = false;
            btn_voltar.Text = "Voltar";
        }

        public class ListaDupli
        {
            public int chave { get; set; }
            public string nome { get; set; }
            public string caminho { get; set; }
            public string extensao { get; set; }
            public bool verificado { get; set; }

            public ListaDupli(int _chave, string _nome, string _caminho, string _extensao)
            {
                chave = _chave;
                nome = _nome;
                caminho = _caminho;
                extensao = _extensao;
                verificado = false;
            }
        }

        public class Tipo
        {
            public Queue<ListViewItem> iguais;
            public string nome;
            public List<ListaDupli> conteudo;

            public Tipo(string _nome)
            {
                nome = _nome;
                conteudo = new List<ListaDupli>();
                iguais = new Queue<ListViewItem>();
            }
        }

        private void abrir_local_Click(object sender, EventArgs e)
        {
            TabPage pagina = tabControl1.SelectedTab;
            ListView lista = (ListView)pagina.Controls[0];
            if (lista.SelectedItems.Count != 0)
            {
                string arquivo = lista.SelectedItems[0].Text;
                Process.Start("explorer.exe", @"/select, " + arquivo);
            }
        }

        private void abrir_arquivo_Click(object sender, EventArgs e)
        {
            TabPage pagina = tabControl1.SelectedTab;
            ListView lista = (ListView)pagina.Controls[0];
            if (lista.SelectedItems.Count != 0)
            {
                string arquivo = lista.SelectedItems[0].Text;
                Process.Start("explorer.exe", arquivo);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (btn_voltar.Text == "Cancelar")
            {
                backDocumento.CancelAsync();
                backArvore.CancelAsync();
                backImagem.CancelAsync();
                backMusica.CancelAsync();
                backVideo.CancelAsync();
                backDocumento.CancelAsync();
                btn_voltar.Text = "Voltar";
                progresso.Visible = false;
                lbl_status.Text = "Cancelado";

            }
            else
            {
                foreach (Control c in Application.OpenForms[0].Controls)
                {
                    if (c.Tag != null)
                    {
                        Panel p = (Panel)c;
                        Form f = (Form)p.Controls[0];
                        this.Close();
                        f.Show();
                    }
                }
            }
        }
    }
}
