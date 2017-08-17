using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Find_And_Organize
{
    public partial class frm_deletar : Form
    {
        public frm_deletar()
        {
            InitializeComponent();
        }

        public List<string> arquivos = new List<string>();
        private bool Cancelado = false;

        private void frm_deletar_Load(object sender, EventArgs e)
        {
            progresso.Maximum = arquivos.Count;
            backDeletar.RunWorkerAsync();
        }

        private void backDeletar_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string a in arquivos)
            {
                if (!backDeletar.CancellationPending)
                {
                    backDeletar.ReportProgress(0, a);
                    File.Delete(a);
                }
                else
                {
                    Cancelado = true;
                    break;
                }
            }
        }

        private void backDeletar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_atual.Text = e.UserState.ToString();
            progresso.PerformStep();
        }

        private void backDeletar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            if (Cancelado)
            {
                lbl_status.Text = "Cancelado";
                MessageBox.Show("Cancelado", "Duplicatas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_status.Text = "Finalizado";
                MessageBox.Show("Finalizado", "Duplicatas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lbl_atual.Text = "";


            frm_inicio f = (frm_inicio)Application.OpenForms[1];
            f.lbl_origem.Text = "Não selecionado";
            f.ck_imagem.Checked = true;
            f.ck_musica.Checked = true;
            f.ck_video.Checked = true;
            f.ck_documento.Checked = true;


            for (int i = Application.OpenForms.Count; i > 2; i--)
            {
                Application.OpenForms[i - 1].Close();
            }
            Application.OpenForms[1].Show();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            backDeletar.CancelAsync();
        }


    }
}
