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
    public partial class frm_mover : Form
    {
        public frm_mover()
        {
            InitializeComponent();
        }

        public string driver = "";
        public string destino_unico = "";
        public string destino_imagem = "";
        public string destino_musica = "";
        public string destino_video = "";
        public string destino_documento = "";

        bool cancelado = false;

        public enums.Destino opcao_destino = new enums.Destino();
        public structs.ListaArquivos arquivos = new structs.ListaArquivos();

        Queue<structs.Arquivo> reverter = new Queue<structs.Arquivo>();

        private void frm_mover_Load(object sender, EventArgs e)
        {
            progressoTot.Maximum = arquivos.imagem.Count + arquivos.musica.Count + arquivos.video.Count + arquivos.documento.Count;
            progressoImg.Maximum = arquivos.imagem.Count;
            progressoMus.Maximum = arquivos.musica.Count;
            progressoVid.Maximum = arquivos.video.Count;
            progressoDoc.Maximum = arquivos.documento.Count;
            backMover.RunWorkerAsync();
        }

        private void backMover_DoWork(object sender, DoWorkEventArgs e)
        {
            //Verifica Espaco Disponivel
            long tamImg = 0;
            long tamMus = 0;
            long tamVid = 0;
            long tamDoc = 0;
 
            foreach (structs.Arquivo f in arquivos.imagem)
                try
                {
                    tamImg += new FileInfo(f.caminho + @"\" + f.nome).Length;
                }
                catch { }
            foreach (structs.Arquivo f in arquivos.musica)
                try
                {
                    tamMus += new FileInfo(f.caminho + @"\" + f.nome).Length;
                }
                catch { }
            foreach (structs.Arquivo f in arquivos.video)
                try
                {
                    tamVid += new FileInfo(f.caminho + @"\" + f.nome).Length;
                }
                catch { }
            foreach (structs.Arquivo f in arquivos.documento)
                try
                {
                    tamDoc += new FileInfo(f.caminho + @"\" + f.nome).Length;
                }
                catch { }

            long tamTot = tamImg + tamMus + tamVid + tamDoc;

            backMover.ReportProgress(0);

            //Unico
            if (opcao_destino == enums.Destino.Unico)
            {
                long tamanho_disponivel_atual = new DriveInfo(driver).AvailableFreeSpace;
                if (tamTot >= tamanho_disponivel_atual)
                    MessageBox.Show("Espaço Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MoverArquivos(opcao_destino, enums.Modo.Todos);
            }

            //Padrao
            if (opcao_destino == enums.Destino.Padrao)
            {
                long tamanho_disponivel_atual = new DriveInfo(driver).AvailableFreeSpace;
                if (tamTot >= tamanho_disponivel_atual)
                    MessageBox.Show("Espaço Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MoverArquivos(opcao_destino, enums.Modo.Todos);
            }

            //Multiplo
            if (opcao_destino == enums.Destino.Multiplo)
            {
                if (destino_imagem != "Não Selecionado\\")
                {
                    if (new DriveInfo(Directory.GetDirectoryRoot(destino_imagem)).AvailableFreeSpace > tamImg)
                    {
                        driver = new DirectoryInfo(destino_imagem).Root.ToString();
                        MoverArquivos(opcao_destino, enums.Modo.Imagem);
                    }
                    else
                    {
                        MessageBox.Show("Espaço Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (destino_musica != "Não Selecionado\\")
                {
                    if (new DriveInfo(Directory.GetDirectoryRoot(destino_musica)).AvailableFreeSpace > tamMus)
                    {
                        driver = new DirectoryInfo(destino_musica).Root.ToString();
                        MoverArquivos(opcao_destino, enums.Modo.Musica);
                    }
                    else
                    {
                        MessageBox.Show("Espaço Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (destino_video != "Não Selecionado\\")
                {
                    if (new DriveInfo(Directory.GetDirectoryRoot(destino_video)).AvailableFreeSpace > tamVid)
                    {
                        driver = new DirectoryInfo(destino_video).Root.ToString();
                        MoverArquivos(opcao_destino, enums.Modo.Video);
                    }
                    else
                    {
                        MessageBox.Show("Espaço Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (destino_documento != "Não Selecionado\\")
                {
                    if (new DriveInfo(Directory.GetDirectoryRoot(destino_documento)).AvailableFreeSpace > tamDoc)
                    {
                        driver = new DirectoryInfo(destino_documento).Root.ToString();
                        MoverArquivos(opcao_destino, enums.Modo.Documento);
                    }
                    else
                    {
                        MessageBox.Show("Espaço Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }

        //Mover
        private void MoverArquivos(enums.Destino d, enums.Modo m)
        {
            if (m == enums.Modo.Imagem || m == enums.Modo.Todos)
            {
                foreach (structs.Arquivo a in arquivos.imagem)
                {
                    if (cancelado)
                        break;

                        string nome;
                        string atual;
                        bool erro = true;
                        int i = 1;

                        backMover.ReportProgress(1, a.nome + "^" + "0");

                        //if (d == enums.Destino.Unico && !(new DirectoryInfo(destino_unico + @"\Imagens").Exists))
                        //    Directory.CreateDirectory(destino_unico + @"\Imagens");

                        while (erro)
                        {
                            atual = a.caminho + a.nome;
                            try
                            {
                                if (cancelado)
                                    break;

                                if (i == 1)
                                    nome = a.nome;
                                else
                                    nome = a.nome.Replace(a.extensao, "") + "(" + i + ")" + a.extensao;
                                if (d == enums.Destino.Unico)
                                {
                                    File.Copy(atual, destino_unico + nome);
                                    File.Delete(atual);
                                }

                                if (d == enums.Destino.Multiplo || d == enums.Destino.Padrao)
                                {
                                    File.Copy(atual, destino_imagem + nome);
                                    File.Delete(atual);
                                }
                                erro = false;
                                backMover.ReportProgress(1, a.nome + "^" + "1");
                            }
                            catch
                            {
                                if (!(new DriveInfo(driver).IsReady))
                                {
                                    MessageBox.Show("Disco removido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                i++;
                            }
                        }
                        reverter.Enqueue(a);
                }
            }

            if (m == enums.Modo.Musica || m == enums.Modo.Todos)
            {
                foreach (structs.Arquivo a in arquivos.musica)
                {
                    if (cancelado)
                        break;

                        string nome;
                        string atual;
                        bool erro = true;
                        int i = 1;

                        backMover.ReportProgress(2, a.nome + "^" + "0");

                        //if (d == enums.Destino.Unico && !(new DirectoryInfo(destino_unico + @"\Musicas").Exists))
                        //    Directory.CreateDirectory(destino_unico + @"\Musicas");
                        while (erro)
                        {
                            atual = a.caminho + a.nome;
                            try
                            {
                                if (cancelado)
                                    break;

                                if (i == 1)
                                    nome = a.nome;
                                else
                                    nome = a.nome.Replace(a.extensao, "") + "(" + i + ")" + a.extensao;
                                if (d == enums.Destino.Unico)
                                {
                                    File.Copy(atual, destino_unico + nome);
                                    File.Delete(atual);
                                }
                                if (d == enums.Destino.Multiplo || d == enums.Destino.Padrao)
                                {
                                    File.Copy(atual, destino_musica + nome);
                                    File.Delete(atual);
                                }
                                erro = false;
                                backMover.ReportProgress(2, a.nome + "^" + "1");
                            }
                            catch
                            {
                                if (!(new DriveInfo(driver).IsReady))
                                {
                                    MessageBox.Show("Disco removido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                i++;
                            }
                        }
                        reverter.Enqueue(a);
                }
            }

            if (m == enums.Modo.Video || m == enums.Modo.Todos)
            {
                foreach (structs.Arquivo a in arquivos.video)
                {
                    if (cancelado)
                        break;

                        string nome;
                        string atual;
                        bool erro = true;
                        int i = 1;

                        backMover.ReportProgress(3, a.nome + "^" + "0");

                        //if (d == enums.Destino.Unico && !(new DirectoryInfo(destino_unico + @"\Videos").Exists))
                        //    Directory.CreateDirectory(destino_unico + @"\Videos");

                        while (erro)
                        {
                            atual = a.caminho + a.nome;
                            try
                            {
                                if (cancelado)
                                    break;

                                if (i == 1)
                                    nome = a.nome;
                                else
                                    nome = a.nome.Replace(a.extensao, "") + "(" + i + ")" + a.extensao;
                                if (d == enums.Destino.Unico)
                                {
                                    File.Copy(atual, destino_unico + nome);
                                    File.Delete(atual);
                                }
                                if (d == enums.Destino.Multiplo || d == enums.Destino.Padrao)
                                {
                                    File.Copy(atual, destino_video + nome);
                                    File.Delete(atual);
                                }
                                erro = false;
                                backMover.ReportProgress(3, a.nome + "^" + "1");
                            }
                            catch
                            {
                                if (!(new DriveInfo(driver).IsReady))
                                {
                                    MessageBox.Show("Disco removido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                i++;
                            }
                        }
                        reverter.Enqueue(a);
                }
            }

            if (m == enums.Modo.Documento || m == enums.Modo.Todos)
            {
                foreach (structs.Arquivo a in arquivos.documento)
                {
                    if (cancelado)
                        break;

                        string nome;
                        string atual;
                        bool erro = true;
                        int i = 1;

                        backMover.ReportProgress(4, a.nome + "^" + "0");

                        //if (d == enums.Destino.Unico && !(new DirectoryInfo(destino_unico + @"\Documentos").Exists))
                        //    Directory.CreateDirectory(destino_unico + @"\Documentos");
                        while (erro)
                        {
                            atual = a.caminho + a.nome;
                            try
                            {
                                if (cancelado)
                                    break;
                                
                                if (i == 1)
                                    nome = a.nome;
                                else
                                    nome = a.nome.Replace(a.extensao, "") + "(" + i + ")" + a.extensao;
                                if (d == enums.Destino.Unico)
                                {
                                    File.Copy(atual, destino_unico + nome);
                                    File.Delete(atual);
                                }
                                if (d == enums.Destino.Multiplo || d == enums.Destino.Padrao)
                                {
                                    File.Copy(atual, destino_documento + nome);
                                    File.Delete(atual);
                                }
                                erro = false;
                                backMover.ReportProgress(4, a.nome + "^" + "1");
                            }
                            catch
                            {
                                if (!(new DriveInfo(driver).IsReady))
                                {
                                    MessageBox.Show("Disco removido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                i++;
                            }
                        }
                        reverter.Enqueue(a);
                }
            }
        }

        private void backMover_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                lbl_status.Text = "Movendo...";
                return;
            }

            string[] status = e.UserState.ToString().Split('^');

            if (e.ProgressPercentage == 1)
            {
                lbl_arquivo.Text = status[0];
                if (status[1] == "1")
                {
                    progressoImg.PerformStep();
                    progressoTot.PerformStep();
                    lbl_porcTot.Text = ((int)(((double)progressoTot.Value / (double)progressoTot.Maximum) * 100)).ToString() + "%";
                }
            }
            if (e.ProgressPercentage == 2)
            {
                lbl_arquivo.Text = status[0];
                if (status[1] == "1")
                {
                    progressoMus.PerformStep();
                    progressoTot.PerformStep();
                    lbl_porcTot.Text = ((int)(((double)progressoTot.Value / (double)progressoTot.Maximum) * 100)).ToString() + "%";
                }
            }
            if (e.ProgressPercentage == 3)
            {
                lbl_arquivo.Text = status[0];
                if (status[1] == "1")
                {
                    progressoVid.PerformStep();
                    progressoTot.PerformStep();
                    lbl_porcTot.Text = ((int)(((double)progressoTot.Value / (double)progressoTot.Maximum) * 100)).ToString() + "%";
                }
            }
            if (e.ProgressPercentage == 4)
            {
                lbl_arquivo.Text = status[0];
                if (status[1] == "1")
                {
                    progressoDoc.PerformStep();
                    progressoTot.PerformStep();
                    lbl_porcTot.Text = ((int)(((double)progressoTot.Value / (double)progressoTot.Maximum) * 100)).ToString() + "%";
                }
            }
        }

        private void backMover_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            lbl_porcTot.Visible = false;
            lbl_arquivo.Text = "";
            if (cancelado)
            {
                lbl_status.Text = "Cancelado";
                DialogResult result = MessageBox.Show("Deseja reverter as alterações ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    groupBox1.Enabled = false;
                    lbl_status.Text = "Revertendo...";
                    progressoTot.Maximum = reverter.Count;
                    backReverter.RunWorkerAsync();
                }
            }
            else
            {
                lbl_status.Text = "Finalizado";
                MessageBox.Show("Finalizado", "Organizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_origem f = (frm_origem)Application.OpenForms[1];
                f.lbl_origem.Text = "Não selecionado";

                for (int i = Application.OpenForms.Count; i > 2; i--)
                {
                    Application.OpenForms[i - 1].Close();
                }
                Application.OpenForms[1].Show();
            }


            btn_finalizar.Enabled = true;
            btn_finalizar.Focus();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            backMover.CancelAsync();
            this.Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (btn_finalizar.Text == "Cancelar")
            {
                cancelado = true;
                btn_finalizar.Text = "Finalizar";
                btn_finalizar.Enabled = false;
                backMover.CancelAsync();
            }
        }

        private void backReverter_DoWork(object sender, DoWorkEventArgs e)
        {
            while (reverter.Count > 0)
            {
                structs.Arquivo arquivo = reverter.Dequeue();
                string destino = arquivo.caminho;
                string origem = "";
                string tipo = Pesquisa.VefTipo(arquivo.extensao);
                backReverter.ReportProgress(0,arquivo.nome);

                if (opcao_destino == enums.Destino.Unico)
                {
                    origem = destino_unico;
                }
                if (opcao_destino == enums.Destino.Multiplo && opcao_destino == enums.Destino.Padrao)
                {
                    if (tipo == "IMG")
                        origem = destino_imagem;
                    if (tipo == "MUS")
                        origem = destino_musica;
                    if (tipo == "VID")
                        origem = destino_video;
                    if (tipo == "DOC")
                        origem = destino_documento;
                }

                try
                {
                    File.Copy(origem+arquivo.nome, destino+arquivo.nome);
                    File.Delete(origem + arquivo.nome);
                }
                catch { }
                backReverter.ReportProgress(1);
            }
        }

        private void backReverter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                lbl_arquivo.Text = e.UserState.ToString();
            }
            if (e.ProgressPercentage == 1)
            {
                progressoTot.PerformStep();
            }
        }

        private void backReverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_finalizar.Enabled = true;
            lbl_arquivo.Text = "";
            lbl_status.Text = "Finalizado - Arquivos Revertidos";
        }
    }
}
