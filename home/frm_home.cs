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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            AtualizarDrivers();
            CarregarInfoDriver();
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                crt_grafico.Visible = false;
                groupBox3.Text = "Sobre";
                label1.Visible = true;
                cb_drivers.Enabled = true;
                aviso.Visible = true;
                lbl_sobre.Visible = true;
                logo.Visible = true;
            }else
            {
                CarregarGrafico();
            }
        }

        int imagem = 0;
        int musica = 0;
        int video = 0;
        int documento = 0;

        private void AtualizarDrivers()
        {
            cb_drivers.Items.Clear();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in drivers)
                if (d.IsReady && d.DriveFormat == "NTFS")
                    cb_drivers.Items.Add(d.RootDirectory);
            cb_drivers.SelectedIndex = 0;
        }

        private void CarregarInfoDriver()
        {
            string driver = cb_drivers.SelectedItem.ToString();
            DriveInfo d = new DriveInfo(driver);
            
            long tot = d.TotalSize;
            long disp = d.TotalFreeSpace;
            long usa = tot - disp;

            if (tot > 1073741824)
                lbl_tot.Text = "Total:\n" + Math.Ceiling(tot / 1073741824M).ToString("#,### GB");
            else
                lbl_tot.Text = "Total:\n" + Math.Ceiling(tot / 1048576M).ToString("#,### MB");

            if (disp > 1073741824)
                lbl_disp.Text = "Disponível:\n" + Math.Ceiling(disp / 1073741824M).ToString("#,### GB");
            else
                lbl_disp.Text = "Disponível:\n" + Math.Ceiling(disp / 1048576M).ToString("#,### MB");

            if (usa > 1073741824)
                lbl_usa.Text = "Usado:\n" + Math.Ceiling(usa / 1073741824M).ToString("#,### GB");
            else
                lbl_tot.Text = "Usado:\n" + Math.Ceiling(usa / 1048576M).ToString("#,### MB");

        }

        private void cb_drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_drivers.Enabled)
            {
                CarregarInfoDriver();
                crt_grafico.Series.Clear();

                var identity = WindowsIdentity.GetCurrent();
                var principal = new WindowsPrincipal(identity);
                if (principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    CarregarGrafico();
                }
            }
        }

        private void CarregarGrafico()
        {
            cb_drivers.Enabled = false;
            imagem = 0;
            musica = 0;
            video = 0;
            documento = 0;
            crt_grafico.Series.Clear();
            lbl_status.Visible = true;
            backMFT.RunWorkerAsync(cb_drivers.SelectedItem.ToString());
        }

        private void backMFT_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Dictionary<ulong, FileNameAndParentFrn> mDict = new Dictionary<ulong, FileNameAndParentFrn>();
                PInvokeWin32 mft = new PInvokeWin32();
                mft.Drive = e.Argument.ToString().Substring(0,2);

                mft.EnumerateVolume(out mDict, new string[] { "*" });
                foreach (KeyValuePair<UInt64, Find_And_Organize.FileNameAndParentFrn> entry in mDict)
                {
                    FileNameAndParentFrn file = (FileNameAndParentFrn)entry.Value;
                    string nome = file.Name;
                    if (!nome.Contains('.'))
                        continue;

                    string ext = nome.Substring(nome.LastIndexOf("."), nome.Length - nome.LastIndexOf("."));
                    string tipo = Pesquisa.VefTipo(ext);

                    if (tipo == null)
                        continue;

                    if (tipo == "IMG")
                        imagem++;

                    if (tipo == "MUS")
                        musica++;

                    if (tipo == "DOC")
                        documento++;

                    if (tipo == "VID")
                        video++;
                }
            }
            catch { MessageBox.Show("Erro"); return; }
        }

        private void backMFT_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!this.IsDisposed)
            {
                if (imagem != 0)
                {
                    crt_grafico.Series.Add("Imagem");
                    crt_grafico.Series["Imagem"].AxisLabel = "Arquivos";
                    crt_grafico.Series["Imagem"].Points.AddY(imagem);
                    crt_grafico.Series["Imagem"].LegendText = "Imagem: \n" + imagem;
                }

                if (musica != 0)
                {
                    crt_grafico.Series.Add("Musica");

                    crt_grafico.Series["Musica"].Points.AddY(musica);
                    crt_grafico.Series["Musica"].LegendText = "Música: \n" + musica;
                }
                if (video != 0)
                {
                    crt_grafico.Series.Add("Video");

                    crt_grafico.Series["Video"].Points.AddY(video);
                    crt_grafico.Series["Video"].LegendText = "Vídeo: \n" + video;
                }

                if (documento != 0)
                {
                    crt_grafico.Series.Add("Documento");

                    crt_grafico.Series["Documento"].Points.AddY(documento);
                    crt_grafico.Series["Documento"].LegendText = "Documento: \n" + documento;
                }

                crt_grafico.ChartAreas[0].RecalculateAxesScale();
                lbl_status.Visible = false;
                crt_grafico.Visible = true;

                cb_drivers.Enabled = true;
            }
        }
    }
}
