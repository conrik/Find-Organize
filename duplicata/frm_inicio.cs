using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;

namespace Find_And_Organize
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                lbl_origem.Text = fbd.SelectedPath;
                btn_procurar.Focus();
            }
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            if (lbl_origem.Text == "Não selecionado")
            {
                MessageBox.Show("Selecione um local para pesquisar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_selecionar.Focus();
                return;
            }
            else
            {
                int sel1 = 0;
                foreach(Control c in flowLayoutPanel1.Controls)
                {
                    CheckBox ck = (CheckBox)c;
                    if (ck.Checked)
                        sel1++;
                }

                if (sel1 < 1)
                {
                    MessageBox.Show("Selecione no mínimo um tipo de arquivo para pesquisar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                frm_resultado f = new frm_resultado();

                string origem = lbl_origem.Text;
                f.origem = origem;

                if (ck_imagem.Checked)
                    f.imagem = true;
                if (ck_musica.Checked)
                    f.musica = true;
                if (ck_video.Checked)
                    f.video = true;
                if (ck_documento.Checked)
                    f.documento = true;

                var identity = WindowsIdentity.GetCurrent();
                var principal = new WindowsPrincipal(identity);

                foreach (Control c in Application.OpenForms[0].Controls)
                {
                    if (c.Tag != null)
                    {
                        Panel p = (Panel)c;
                        f.origem = origem;
                        f.TopLevel = false;
                        f.Size = p.Size;
                        this.Hide();
                        p.Controls.Add(f);
                        f.Show();
                    }
                }

            }
        }
    }
}
