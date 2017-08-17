using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Find_And_Organize
{
    public partial class frm_destino : Form
    {
        public frm_destino()
        {
            InitializeComponent();
        }

        public structs.ListaArquivos arquivos = new structs.ListaArquivos();

        private void rb_unico_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_unico.Checked)
            {
                gb_unico.Enabled = true;
                btn_selecionar.Focus();
            }
            else
                gb_unico.Enabled = false;
        }

        private void rb_padrao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_padrao.Checked)
                gb_padrao.Enabled = true;
            else
                gb_padrao.Enabled = false;
        }

        private void rb_multiplo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_multiplo.Checked)
                gb_multiplo.Enabled = true;
            else
                gb_multiplo.Enabled = false;
        }

        private void frm_destino_Load(object sender, EventArgs e)
        {
            rb_padrao.Checked = true;
            AtualizarDrivers();
        }

        private void AtualizarDrivers()
        {
            cb_drivers.Items.Clear();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in drivers)
                if (d.IsReady && new DirectoryInfo(d.RootDirectory+"Windows").Exists)
                    cb_drivers.Items.Add(d.RootDirectory);
            cb_drivers.SelectedIndex = 0;
            AtualizarUsers();
        }

        public void AtualizarUsers()
        {
            cb_users.Items.Clear();
            string[] usuarios = Directory.GetDirectories(cb_drivers.SelectedItem.ToString()+"Users");
            foreach (string f in usuarios)
            {
                DirectoryInfo d = new DirectoryInfo(f);
                if ((d.Attributes & FileAttributes.Hidden) == 0)
                    cb_users.Items.Add(d.Name);
            }
            cb_users.SelectedIndex = 0;
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string destino = fbd.SelectedPath;
            if (destino != "")
            {
                lbl_destino_unico.Text = destino;
            }
        }

        private void btn_imagem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string destino = fbd.SelectedPath;
            if (destino != "")
            {
                lbl_imagem.Text = destino;
            }
        }

        private void btn_musica_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string destino = fbd.SelectedPath;
            if (destino != "")
            {
                lbl_musica.Text = destino;
            }
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string destino = fbd.SelectedPath;
            if (destino != "")
            {
                lbl_video.Text = destino;
            }
        }

        private void btn_documento_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string destino = fbd.SelectedPath;
            if (destino != "")
            {
                lbl_documento.Text = destino;
            }
        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mover os arquivos para o destino selecionado ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                frm_mover f = new frm_mover();
                if (rb_unico.Checked)
                {
                    if (lbl_destino_unico.Text != "Não Selecionado")
                    {
                        f.driver = new DriveInfo(new DirectoryInfo(lbl_destino_unico.Text).Root.ToString()).RootDirectory.ToString();
                        f.opcao_destino = enums.Destino.Unico;
                        f.destino_unico = lbl_destino_unico.Text;
                    }
                    else
                    {
                        MessageBox.Show("Selecione um destino", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (rb_padrao.Checked)
                {
                    string driver = cb_drivers.SelectedItem.ToString();
                    f.opcao_destino = enums.Destino.Padrao;
                    f.driver = driver;
                    string nome = cb_users.SelectedItem.ToString();

                    f.destino_imagem = driver + @"Users\" + nome + @"\Pictures\";

                    f.destino_musica = driver + @"Users\" + nome + @"\Music\";

                    f.destino_video = driver + @"Users\" + nome + @"\Videos\";

                    f.destino_documento = driver + @"Users\" + nome + @"\Documents\";

                    if (!(new DirectoryInfo(driver + @"Users\" + nome + @"\").Exists && new DirectoryInfo(f.destino_imagem).Exists && new DirectoryInfo(f.destino_musica).Exists &&
                        new DirectoryInfo(f.destino_video).Exists && new DirectoryInfo(f.destino_documento).Exists))
                    {
                        MessageBox.Show("Bibliotecas não encontradas ou incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (rb_multiplo.Checked)
                {
                    int prenchido = 0;
                    int selecionados = 0;
                    if (lbl_imagem.Text != "Não Selecionado")
                        prenchido++;
                    if (lbl_musica.Text != "Não Selecionado")
                        prenchido++;
                    if (lbl_video.Text != "Não Selecionado")
                        prenchido++;
                    if (lbl_documento.Text != "Não Selecionado")
                        prenchido++;

                    if(btn_imagem.Enabled)
                        selecionados++;
                    if(btn_musica.Enabled)
                        selecionados++;
                    if(btn_video.Enabled)
                        selecionados++;
                    if(btn_documento.Enabled)
                        selecionados++;

                    if (prenchido == selecionados)
                    {
                        f.opcao_destino = enums.Destino.Multiplo;
                        f.destino_imagem = lbl_imagem.Text + @"\";
                        f.destino_musica = lbl_musica.Text + @"\";
                        f.destino_video = lbl_video.Text + @"\";
                        f.destino_documento = lbl_documento.Text + @"\";

                        if (lbl_imagem.Text == "Não Selecionado")
                            arquivos.imagem.Clear();
                        if (lbl_musica.Text == "Não Selecionado")
                            arquivos.musica.Clear();
                        if (lbl_video.Text == "Não Selecionado")
                            arquivos.video.Clear();
                        if (lbl_documento.Text == "Não Selecionado")
                            arquivos.documento.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Selecione os destinos dos arquivos para mover", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                foreach (Control c in Application.OpenForms[0].Controls)
                {
                    if (c.Tag != null)
                    {
                        Panel p = (Panel)c;
                        f.TopLevel = false;
                        f.Size = p.Size;

                        f.arquivos = arquivos;

                        this.Hide();
                        p.Controls.Add(f);
                        f.Show();
                    }
                } 
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Application.OpenForms[0].Controls)
            {
                if (c.Tag != null)
                {
                    Panel p = (Panel)c;
                    Form f = (Form)p.Controls[1];
                    this.Close();
                    f.Show();
                }
            }
        }

        private void cb_drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarUsers();
        }
    }
}
