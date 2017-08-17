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
    public partial class frm_origem : Form
    {
        public frm_origem()
        {
            InitializeComponent();
        }

        private string origem = "";

        private enums.Modos_Pesquisa opcao_pesquisa = enums.Modos_Pesquisa.Nenhum;

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.ShowDialog();
            if(fbd.SelectedPath != "")
            {
                DriveInfo driver = new DriveInfo(new DirectoryInfo(fbd.SelectedPath).Root.ToString());
                if (driver.DriveType == DriveType.Fixed || driver.DriveType == DriveType.Removable)
                {
                    origem = fbd.SelectedPath;
                    lbl_origem.Text = origem;
                    btn_continuar.Focus();
                }
                else
                {
                    MessageBox.Show("Local invalido selecione outro");
                }
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (lbl_origem.Text != "Não selecionado")
            {
                frm_enumerar f = new frm_enumerar();
                DirectoryInfo info = new DirectoryInfo(lbl_origem.Text);
                if (lbl_origem.Text == info.Root.ToString())
                {
                    try
                    {
                        if (new DriveInfo(info.Root.ToString()).DriveFormat == "NTFS")
                        {
                            var identity = WindowsIdentity.GetCurrent();
                            var principal = new WindowsPrincipal(identity);
                            if (principal.IsInRole(WindowsBuiltInRole.Administrator))
                            {
                                opcao_pesquisa = enums.Modos_Pesquisa.MFT;
                            }
                            else
                            {
                               DialogResult resultado = MessageBox.Show("A busca de arquivos pode demorar inicie como administrador para melhorar a performance. \n\nDeseja iniciar assim mesmo ?",
                                   "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if(resultado == System.Windows.Forms.DialogResult.Yes)
                                    opcao_pesquisa = enums.Modos_Pesquisa.Arvore;
                                else
                                    return;
                            }
                        }
                        else
                        {
                            opcao_pesquisa = enums.Modos_Pesquisa.Arvore;
                        }
                    }
                    catch { MessageBox.Show("Local não encontrado selecione outro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); lbl_origem.Text = "Não selecionado"; return; }
                }
                else
                {
                    opcao_pesquisa = enums.Modos_Pesquisa.Arvore;
                }
                foreach (Control c in Application.OpenForms[0].Controls)
                {
                    if (c.Tag != null)
                    {
                        Panel p = (Panel)c;
                        f.origem = origem;
                        f.TopLevel = false;
                        f.Size = p.Size;
                        f.opcao_pesquisa = opcao_pesquisa;
                        this.Hide();
                        p.Controls.Add(f);
                        f.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um local","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void frm_origem_Load(object sender, EventArgs e)
        {
            btn_selecionar.Focus();
        }
    }
}
