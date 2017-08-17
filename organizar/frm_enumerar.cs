using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Find_And_Organize
{
    public partial class frm_enumerar : Form
    {
        public frm_enumerar()
        {
            InitializeComponent();
        }

        public string origem = "";

        public enums.Modos_Pesquisa opcao_pesquisa = enums.Modos_Pesquisa.Nenhum;

        List<structs.Arquivo> arquivos = new List<structs.Arquivo>();

        private int total_arquivos = 0;

        private void frm_enumerar_Load(object sender, EventArgs e)
        {
            if(opcao_pesquisa == enums.Modos_Pesquisa.Arvore)
                backArvore.RunWorkerAsync();
            if (opcao_pesquisa == enums.Modos_Pesquisa.MFT)
                backMFT.RunWorkerAsync();
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
            progresso.Maximum = arquivos.Count;
            progresso.Style = ProgressBarStyle.Continuous;
            lbl_status.Text = "Analizando Arquivos...";
            backSeparacao.RunWorkerAsync();
        }

        structs.ListaArquivos arquivos_validos = new structs.ListaArquivos();
        private void backSeparacao_DoWork(object sender, DoWorkEventArgs e)
        {
            arquivos_validos.imagem = new List<structs.Arquivo>();
            arquivos_validos.musica = new List<structs.Arquivo>();
            arquivos_validos.video = new List<structs.Arquivo>();
            arquivos_validos.documento = new List<structs.Arquivo>();

            for (int i = 0; i < arquivos.Count; i++)
            {
                backSeparacao.ReportProgress(0);

                string caminho = arquivos[i].caminho;
                string extensao = arquivos[i].extensao;
                string nome = arquivos[i].nome;

                string tipo = Pesquisa.VefTipo(extensao);

                if (tipo == null)
                    continue;

                if (tipo == "IMG")
                    arquivos_validos.imagem.Add(new structs.Arquivo(i, nome, caminho, extensao));

                if (tipo == "MUS")
                    arquivos_validos.musica.Add(new structs.Arquivo(i, nome, caminho, extensao));

                if (tipo == "DOC")
                    arquivos_validos.documento.Add(new structs.Arquivo(i, nome, caminho, extensao));

                if (tipo == "VID")
                    arquivos_validos.video.Add(new structs.Arquivo(i, nome, caminho, extensao));
            }
        }

        private void backSeparacao_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progresso.PerformStep();
        }

        private void backSeparacao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresso.Visible = false;
            total_arquivos = arquivos_validos.imagem.Count + arquivos_validos.musica.Count + arquivos_validos.video.Count + arquivos_validos.documento.Count;
            if (total_arquivos == 0)
                lbl_status.Text = "Nenhum arquivo válido foi encontrado";
            else
            {
                if (arquivos_validos.imagem.Count != 0)
                {
                    tabControl1.TabPages.Add("Imagem", "Imagem");
                    CriarAba("Imagem", "IMG");
                }
                if (arquivos_validos.musica.Count != 0)
                {
                    tabControl1.TabPages.Add("Música", "Música");
                    CriarAba("Música", "MUS");
                }

                if (arquivos_validos.video.Count != 0)
                {
                    tabControl1.TabPages.Add("Video", "Video");
                    CriarAba("Video", "VID");
                }

                if (arquivos_validos.documento.Count != 0)
                {
                    tabControl1.TabPages.Add("Documento", "Documento");
                    CriarAba("Documento", "DOC");
                }

                lbl_status.Text = "Selecione os arquivos que deseja mover";
                btn_deselecionar.Enabled = true;
                btn_selecionar.Enabled = true;
                btn_continuar.Enabled = true;
            }
        }

        private void CriarAba(string nomeAba, string tipo)
        {
            ListView list = new ListView();
            list.Location = new Point(0, 0);
            list.Size = new System.Drawing.Size(415, 286);
            list.GridLines = true;
            list.Columns.Add("Arquivo");
            list.Columns[0].Width = list.Size.Width;
            list.View = View.Details;
            list.CheckBoxes = true;
            list.Dock = DockStyle.Fill;
            list.Columns[0].Width = list.Size.Width - 4;
            list.HeaderStyle = ColumnHeaderStyle.Clickable;
            list.ContextMenuStrip = menuContexto;
            list.MultiSelect = false;

            TabPage page = new TabPage();

            if (tipo == "IMG")
            {
                foreach (string ext in Pesquisa.filtro_imagem)
                    list.Groups.Add(ext, ext);
                page.Controls.Add(list);
                for (int i = 0; i < arquivos_validos.imagem.Count; i++)
                {
                    list.Items.Add(new ListViewItem(arquivos_validos.imagem[i].nome, arquivos_validos.imagem[i].chave + "-IMG", list.Groups[arquivos_validos.imagem[i].extensao]));
                    list.Items[i].Checked = true;
                }
            }
            if (tipo == "MUS")
            {
                foreach (string ext in Pesquisa.filtro_musica)
                    list.Groups.Add(ext, ext);
                page.Controls.Add(list);
                for (int i = 0; i < arquivos_validos.musica.Count; i++)
                {
                    list.Items.Add(new ListViewItem(arquivos_validos.musica[i].nome, arquivos_validos.musica[i].chave + "-MUS", list.Groups[arquivos_validos.musica[i].extensao]));
                    list.Items[i].Checked = true;
                }
            }

            if (tipo == "DOC")
            {
                foreach (string ext in Pesquisa.filtro_documento)
                    list.Groups.Add(ext, ext);
                page.Controls.Add(list);
                for (int i = 0; i < arquivos_validos.documento.Count; i++)
                {
                    list.Items.Add(new ListViewItem(arquivos_validos.documento[i].nome, arquivos_validos.documento[i].chave + "-DOC", list.Groups[arquivos_validos.documento[i].extensao]));
                    list.Items[i].Checked = true;
                }
            }

            if (tipo == "VID")
            {
                foreach (string ext in Pesquisa.filtro_video)
                    list.Groups.Add(ext, ext);
                page.Controls.Add(list);
                for (int i = 0; i < arquivos_validos.video.Count; i++)
                {
                    list.Items.Add(new ListViewItem(arquivos_validos.video[i].nome, arquivos_validos.video[i].chave + "-VID", list.Groups[arquivos_validos.video[i].extensao]));
                    list.Items[i].Checked = true;
                }
            }

            foreach (Control c in page.Controls)
                tabControl1.TabPages[nomeAba].Controls.Add(c);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
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

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            frm_destino f2 = new frm_destino();
            int abas = tabControl1.TabPages.Count;
            int abas_vazias = 0;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                ListView lista = (ListView)tab.Controls[0];
                if (tab.Text == "Imagem")
                    f2.btn_imagem.Enabled = true;

                if (tab.Text == "Música")
                    f2.btn_musica.Enabled = true;

                if (tab.Text == "Video")
                    f2.btn_video.Enabled = true;

                if (tab.Text == "Documento")
                    f2.btn_documento.Enabled = true;

                if (lista.CheckedItems.Count == 0)
                {
                    abas_vazias++;
                    if (tab.Text == "Imagem")
                        f2.btn_imagem.Enabled = false;
                    if (tab.Text == "Música")
                        f2.btn_musica.Enabled = false;
                    if (tab.Text == "Video")
                        f2.btn_video.Enabled = false;
                    if (tab.Text == "Documento")
                        f2.btn_documento.Enabled = false;
                }
            }

            if (abas != abas_vazias)
            {
                structs.ListaArquivos arquivos_mover = new structs.ListaArquivos();
                arquivos_mover.imagem = new List<structs.Arquivo>();
                arquivos_mover.musica = new List<structs.Arquivo>();
                arquivos_mover.video = new List<structs.Arquivo>();
                arquivos_mover.documento = new List<structs.Arquivo>();

                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    object tab = tabControl1.TabPages[i].Controls[0];
                    ListView tab_atual = (ListView)tab;

                    foreach (ListViewItem item in tab_atual.Items)
                    {
                        if (item.Checked)
                        {
                            string[] result = item.ImageKey.Split('-');
                            int chave = int.Parse(result[0]);
                            string tipo = result[1];

                            if (tipo == "IMG")
                                arquivos_mover.imagem.Add(RetornarArquivo(chave));
                            if (tipo == "MUS")
                                arquivos_mover.musica.Add(RetornarArquivo(chave));
                            if (tipo == "VID")
                                arquivos_mover.video.Add(RetornarArquivo(chave));
                            if (tipo == "DOC")
                                arquivos_mover.documento.Add(RetornarArquivo(chave));
                        }
                    }
                }

                foreach (Control c in Application.OpenForms[0].Controls)
                {
                    if (c.Tag != null)
                    {
                        Panel p = (Panel)c;
                        f2.TopLevel = false;
                        f2.Size = p.Size;

                        f2.arquivos = arquivos_mover;

                        this.Hide();
                        p.Controls.Add(f2);
                        f2.Show();
                    }
                }              
            }
            else
            {
                MessageBox.Show("Selecione no mínimo um arquivo para mover", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private structs.Arquivo RetornarArquivo(int chave)
        {
            foreach (structs.Arquivo a in arquivos_validos.imagem)
                if (a.chave == chave)
                    return a;

            foreach (structs.Arquivo a in arquivos_validos.musica)
                if (a.chave == chave)
                    return a;

            foreach (structs.Arquivo a in arquivos_validos.video)
                if (a.chave == chave)
                    return a;

            foreach (structs.Arquivo a in arquivos_validos.documento)
                if (a.chave == chave)
                    return a;

            return new structs.Arquivo();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            TabPage pagina = tabControl1.SelectedTab;
            ListView lista = (ListView)pagina.Controls[0];
            foreach (ListViewItem i in lista.Items)
                i.Checked = true;
        }

        private void btn_deselecionar_Click(object sender, EventArgs e)
        {
            TabPage pagina = tabControl1.SelectedTab;
            ListView lista = (ListView)pagina.Controls[0];
            foreach (ListViewItem i in lista.Items)
                i.Checked = false;
        }

        private void Abrir_local_Click(object sender, EventArgs e)
        {
            TabPage pagina = tabControl1.SelectedTab;
            ListView lista = (ListView)pagina.Controls[0];
            if (lista.SelectedItems.Count != 0)
            {
                string[] dados = lista.SelectedItems[0].ImageKey.Split('-');
                int chave = int.Parse(dados[0]);
                structs.Arquivo arquivo = RetornarArquivo(chave);
                Process.Start("explorer.exe", @"/select, " +arquivo.caminho+arquivo.nome);
            }
        }

        private void Abrir_arquivo_Click(object sender, EventArgs e)
        {
            TabPage pagina = tabControl1.SelectedTab;
            ListView lista = (ListView)pagina.Controls[0];
            if (lista.SelectedItems.Count != 0)
            {
                string[] dados = lista.SelectedItems[0].ImageKey.Split('-');
                int chave = int.Parse(dados[0]);
                structs.Arquivo arquivo = RetornarArquivo(chave);
                Process.Start("explorer.exe", arquivo.caminho+arquivo.nome);
            }
        }

        private void backMFT_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                NtfsUsnJournal nuj = new NtfsUsnJournal(new DriveInfo(origem));
                Dictionary<ulong, FileNameAndParentFrn> mDict = new Dictionary<ulong, FileNameAndParentFrn>();
                PInvokeWin32 mft = new PInvokeWin32();
                mft.Drive = origem.Substring(0,2);
                mft.EnumerateVolume(out mDict, new string[] { "*" });
                int i = 0;
                foreach (KeyValuePair<UInt64, Find_And_Organize.FileNameAndParentFrn> entry in mDict)
                {
                    if (backMFT.CancellationPending == true)
                        e.Cancel = true;
                    else
                    {
                        Find_And_Organize.FileNameAndParentFrn file = (Find_And_Organize.FileNameAndParentFrn)entry.Value;
                        if (PInvokeWin32.ChkAtri(file.Attributes))
                        {
                            string nome = file.Name;
                            string caminho;
                            if (!nome.Contains('.'))
                                continue;
                            string ext = nome.Substring(nome.LastIndexOf("."), nome.Length - nome.LastIndexOf("."));
                            nuj.GetPathFromFileReference(file.ParentFrn, out caminho);
                            if (caminho == "Unavailable")
                                continue;
                            caminho = origem.Substring(0, 2) + caminho + @"\";
                            arquivos.Add(new structs.Arquivo(i, nome, caminho, ext));
                        }
                    }
                    i++;
                }
            }
            catch {MessageBox.Show("Erro","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
        }

        private void backMFT_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresso.Maximum = arquivos.Count;
            progresso.Style = ProgressBarStyle.Continuous;
            lbl_status.Text = "Analizando Arquivos...";
            backSeparacao.RunWorkerAsync();
        }

        private void menuContexto_Opening(object sender, CancelEventArgs e)
        {
            TabPage t = tabControl1.SelectedTab;
            ListView l = (ListView)t.Controls[0];
            if (l.SelectedItems.Count == 0)
                e.Cancel = true;
        }
    }
}
