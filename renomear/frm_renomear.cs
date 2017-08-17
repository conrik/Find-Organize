using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Find_And_Organize
{
    public partial class frm_renomear : Form
    {
        string var_Caminho = "";
        string var_Nome = "";
        char[] Restricao = { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };

        public frm_renomear()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var_Nome = "";
            bool Copia = false;
            bool Teste = false;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                if (var_Caminho == "")
                    var_Caminho = Path.GetDirectoryName(openFileDialog1.FileName);
                if (var_Caminho == Path.GetDirectoryName(openFileDialog1.FileName))
                {
                    if (lst_Arquivos.Items.Count == 0)
                    {
                        Adicionar_Arquivos();
                    }
                    else
                    {
                        Lista_Desfazer();
                        int Fim = lst_Arquivos.Items.Count - 1;
                        for (int X = 0; X <= openFileDialog1.FileNames.Count() - 1; X++)
                        {
                            Teste = false;
                            for (int Y = 0; Y <= Fim; Y++)
                            {
                                string Nome = Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[X]);
                                if (Nome == lst_Arquivos.Items[Y].ToString())
                                {
                                    Teste = true;
                                    Copia = true;
                                }
                            }
                            if (Teste == false)
                            {
                                lst_Arquivos.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[X]));
                                lst_Extencao.Items.Add(Path.GetExtension(openFileDialog1.FileNames[X]));
                            }
                        }
                    }
                    
                    gpb_Opcoes.Enabled = true;
                    btn_Renomear.Enabled = true;
                    btn_Salvar.Enabled = true;
                    btn_Limpar.Enabled = true;
                    btn_Remover.Enabled = true;
                    if (Copia)
                        MessageBox.Show("Alguns arquivos não foram adicionados, pois já estavam na lista de arquivos.", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Busque arquivos apenas da mesma pasta, se deseja renomear arquivos de outra pasta, aperte o botão 'Limpar' e então escolha os arquivos desejados", "Caminho incorreto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Nenhum item foi selecionado", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            openFileDialog1.FileName = "";
        }

        private void Adicionar_Arquivos()
        {
            for (int X = 0; X <= openFileDialog1.FileNames.Count() - 1; X++)
            {
                lst_Arquivos.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[X]));
                lst_Extencao.Items.Add(Path.GetExtension(openFileDialog1.FileNames[X]));
            }
        }

        private void frm_Renomear_Shown(object sender, EventArgs e)
        {
            gpb_Opcoes.Enabled = false;
            pnl_Retirar.Enabled = false;
            pnl_Adicionar.Enabled = false;
            pnl_Substituir.Enabled = false;
            pnl_Numerar.Enabled = false;
            rdb_Inicio_Adicionar.Checked = true;
            rdb_Inicio_Retirar.Checked = true;
            btn_Renomear.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Limpar.Enabled = false;
            btn_Remover.Enabled = false;
            btn_Desfazer.Enabled = false;
        }

        private void chk_Substituir_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Substituir.Checked)
            {
                txt_Localizar.Enabled = true;
                txt_Substituir.Enabled = true;
                pnl_Substituir.Enabled = true;
                txt_Localizar.Focus();
            }
            else
            {
                txt_Localizar.Clear();
                txt_Substituir.Clear();
                txt_Localizar.Enabled = false;
                txt_Substituir.Enabled = false;
                pnl_Substituir.Enabled = false;
            }
        }

        private void btn_Renomear_Click(object sender, EventArgs e)
        {
            var_Nome = "";
            if ((chk_Retirar_Trecho.Checked) || (chk_Substituir.Checked) || (chk_Adicionar_Trecho.Checked) || (chk_Numerar.Checked))
            {
                if (lst_Renomear.Items.Count != 0)
                    Lista_Desfazer();
                else
                {
                    lst_Desfazer.Items.Clear();
                    lst_Desfazer.Items.AddRange(lst_Arquivos.Items);
                    btn_Desfazer.Enabled = true;
                }

                if (chk_Retirar_Trecho.Checked && msk_Tamanho_Trecho.Text != "")
                {
                    bool erro = false;
                    for (int i = 0; i < lst_Arquivos.Items.Count; i++)
			        {
                        if (int.Parse(msk_Tamanho_Trecho.Text) >= lst_Arquivos.Items[i].ToString().Length)
                        {
                            erro = true;
                        }

                        if (lst_Renomear.Items.Count != 0)
                            if (int.Parse(msk_Tamanho_Trecho.Text) >= lst_Renomear.Items[i].ToString().Length)
                                erro = true;
			        }

                    if (erro)
                    {
                        MessageBox.Show("O Valor digitado para retirar é maior que a quantidade de letras nos nomes", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                    Lista_Renomear();
                    for (int X = 0; X < lst_Renomear.Items.Count; X++)
                    {
                        var_Nome = lst_Renomear.Items[X].ToString();
                        int Tamanho = var_Nome.Count();
                        Tamanho = Tamanho - int.Parse(msk_Tamanho_Trecho.Text);
                        if (rdb_Inicio_Retirar.Checked)
                        {
                            var_Nome = var_Nome.Substring(int.Parse(msk_Tamanho_Trecho.Text), Tamanho);
                        }
                        else
                        {
                            var_Nome = var_Nome.Substring(0, Tamanho);
                        }
                        lst_Renomear.Items[X] = var_Nome;
                    }
                    chk_Retirar_Trecho.Checked = false;
                    msk_Tamanho_Trecho.Clear();
                }

                if (chk_Adicionar_Trecho.Checked && txt_Trecho.Text != "")
                {
                    Lista_Renomear();
                    for (int X = 0; X < lst_Renomear.Items.Count; X++)
                    {
                        var_Nome = lst_Renomear.Items[X].ToString();
                        if (rdb_Inicio_Adicionar.Checked)
                            var_Nome = txt_Trecho.Text + var_Nome;
                        else
                            var_Nome = var_Nome + txt_Trecho.Text;
                        lst_Renomear.Items[X] = var_Nome;
                    }
                    rdb_Inicio_Adicionar.Checked = true;
                    chk_Adicionar_Trecho.Checked = false;
                    txt_Trecho.Clear();
                }

                if (chk_Numerar.Checked)
                {
                    if (txt_Inicial.Text == "")
                    {
                        MessageBox.Show("Digite um valor inicial para a numeração", "Numerar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Inicial.Focus();
                    }
                    else
                    {
                        try
                        {
                            int Teste = int.Parse(txt_Inicial.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Digite apenas números", "Numeração", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txt_Inicial.Clear();
                            txt_Inicial.Focus();
                            return;
                        }
                        if (txt_Digitos.Text == "")
                        {
                            MessageBox.Show("Digite a quantidade desejada de digitos, ou '0' para usar apenas o necessáio", "Numerar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Digitos.Focus();
                        }
                        else
                        {
                            try
                            {
                                int Teste = int.Parse(txt_Digitos.Text);
                            }
                            catch
                            {
                                MessageBox.Show("Digite apenas números", "Numeração", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txt_Digitos.Clear();
                                txt_Digitos.Focus();
                                return;
                            }
                            int var_Digitos = int.Parse(txt_Digitos.Text);
                            int var_Inicio = int.Parse(txt_Inicial.Text);
                            Lista_Renomear();
                            string var_Numerador = var_Inicio.ToString();
                            for (int X = 0; X <= lst_Renomear.Items.Count - 1; X++)
                            {
                                if (var_Digitos > 1)
                                    while (var_Numerador.Length < var_Digitos)
                                    {
                                        var_Numerador = "0" + var_Numerador;
                                    }
                                var_Nome = lst_Renomear.Items[X].ToString();
                                lst_Renomear.Items[X] = var_Numerador + " " + var_Nome;
                                var_Numerador = (int.Parse(var_Numerador) + 1).ToString();
                            }
                            chk_Numerar.Checked = false;
                            txt_Inicial.Clear();
                            txt_Digitos.Clear();
                            pnl_Numerar.Enabled = false;
                        }
                    }
                }

                bool Localizar = false;


                if (chk_Substituir.Checked)
                {
                    if (txt_Localizar.Text == "")
                    {
                        MessageBox.Show("Campo substituir vazio. Digite o que gostaria localizar para substituir.", "Substituir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Localizar.Focus();
                    }
                    else
                    {
                        Lista_Renomear();
                        for (int X = 0; X < lst_Renomear.Items.Count; X++)
                        {
                            string var_Nome_Novo = "";
                            var_Nome = lst_Renomear.Items[X].ToString();
                            var_Nome_Novo = var_Nome.Replace(txt_Localizar.Text, txt_Substituir.Text);
                            lst_Renomear.Items[X] = var_Nome_Novo;
                            if (var_Nome != var_Nome_Novo)
                                Localizar = true;
                        }
                        if (!Localizar)
                            MessageBox.Show("Não foi localizado nada para a substituição", "Substituir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            chk_Substituir.Checked = false;
                            txt_Localizar.Clear();
                            txt_Substituir.Clear();
                            txt_Localizar.Enabled = false;
                            txt_Substituir.Enabled = false;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Escolha uma das opções de alteração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Lista_Desfazer()
        {
            lst_Desfazer.Items.Clear();
            lst_Desfazer.Items.AddRange(lst_Renomear.Items);
            btn_Desfazer.Enabled = true;
        }

        private void Lista_Renomear()
        {
            if (lst_Renomear.Items.Count == 0)
            {
                lst_Renomear.Items.AddRange(lst_Arquivos.Items);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                for (int X = 0; X < lst_Renomear.Items.Count; X++)
                {
                    bool Erro = true;
                    int I = 1;
                    while (Erro)
                    {
                        try
                        {
                            if (I == 1)
                                File.Move(var_Caminho + @"\" + lst_Arquivos.Items[X] + lst_Extencao.Items[X], var_Caminho + @"\" + lst_Renomear.Items[X].ToString().Trim() + lst_Extencao.Items[X]);
                            else
                                File.Move(var_Caminho + @"\" + lst_Arquivos.Items[X] + lst_Extencao.Items[X], var_Caminho + @"\" + lst_Renomear.Items[X].ToString().Trim() + " (" + I + ")" + lst_Extencao.Items[X]);
                            Erro = false;
                        }
                        catch
                        {
                            I++;
                        }
                    }
                }
                MessageBox.Show("Salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                btn_Adicionar.Focus();
                btn_Desfazer.Enabled = false;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja limpar as listas?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Limpar();
                btn_Desfazer.Enabled = false;
            }
        }

        private void Limpar()
        {
            lst_Arquivos.Items.Clear();
            lst_Extencao.Items.Clear();
            lst_Renomear.Items.Clear();
            if (lst_Desfazer.Items.Count != 0)
                lst_Desfazer.Items.Clear();
            chk_Adicionar_Trecho.Checked = false;
            chk_Substituir.Checked = false;
            chk_Retirar_Trecho.Checked = false;
            chk_Numerar.Checked = false;
            rdb_Inicio_Adicionar.Checked = true;
            rdb_Inicio_Retirar.Checked = true;
            btn_Limpar.Enabled = false;
            btn_Salvar.Enabled = false;
            gpb_Opcoes.Enabled = false;
            btn_Renomear.Enabled = false;
            btn_Remover.Enabled = false;
            btn_Limpar.Enabled = false;
            var_Caminho = "";
            lst_Desfazer.Items.Clear();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (lst_Arquivos.SelectedIndex == -1)
                MessageBox.Show("Escolha um item que deseja remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (lst_Arquivos.SelectedIndices.Count>1)
                {
                    for (int X = lst_Arquivos.Items.Count - 1; X >= 0; X--)
                    {
                        if (lst_Arquivos.GetSelected(X))
                        {
                            if (lst_Desfazer.Items.Count != 0)
                                lst_Desfazer.Items.RemoveAt(X);
                            lst_Extencao.Items.RemoveAt(X);
                            if (lst_Renomear.Items.Count != 0)
                                lst_Renomear.Items.RemoveAt(X);
                            lst_Arquivos.Items.RemoveAt(X);
                        }
                    }
                    if (lst_Desfazer.Items.Count == 0)
                        btn_Desfazer.Enabled = false;
                    if (lst_Arquivos.Items.Count == 0)
                        Limpar();
                }
                else
                {
                    if (lst_Desfazer.Items.Count != 0)
                        lst_Desfazer.Items.RemoveAt(lst_Arquivos.SelectedIndex);
                    lst_Extencao.Items.RemoveAt(lst_Arquivos.SelectedIndex);
                    if (lst_Renomear.Items.Count != 0)
                        lst_Renomear.Items.RemoveAt(lst_Arquivos.SelectedIndex);
                    lst_Arquivos.Items.RemoveAt(lst_Arquivos.SelectedIndex);
                    if (lst_Desfazer.Items.Count == 0)
                        btn_Desfazer.Enabled = false;
                    if (lst_Arquivos.Items.Count == 0)
                        Limpar();
                }
            }
        }

        private void lst_Arquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Arquivos.Items.Count == 0)
            {
                lst_Arquivos.Items.Clear();
                lst_Extencao.Items.Clear();
                lst_Renomear.Items.Clear();
                chk_Adicionar_Trecho.Checked = false;
                chk_Substituir.Checked = false;
                chk_Numerar.Checked = false;
                chk_Retirar_Trecho.Checked = false;
                btn_Limpar.Enabled = false;
                btn_Salvar.Enabled = false;
                gpb_Opcoes.Enabled = false;
                btn_Renomear.Enabled = false;
                btn_Remover.Enabled = false;
            }
        }

        private void btn_Desfazer_Click(object sender, EventArgs e)
        {
            lst_Renomear.Items.Clear();
            lst_Renomear.Items.AddRange(lst_Desfazer.Items);
            lst_Desfazer.Items.Clear();
            btn_Desfazer.Enabled = false;
            while (lst_Arquivos.Items.Count != lst_Renomear.Items.Count)
            {
                int Indice = lst_Arquivos.Items.Count - 1;
                lst_Extencao.Items.RemoveAt(Indice);
                lst_Arquivos.Items.RemoveAt(Indice);
            }
            
        }

        private void chk_Numerar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Numerar.Checked)
            {
                pnl_Numerar.Enabled = true;
                txt_Inicial.Focus();
            }
            else
            {
                txt_Inicial.Clear();
                txt_Digitos.Clear();
                pnl_Numerar.Enabled = false;
            }
        }

        private void txt_Prefixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int X = 0; X < 9; X++)
            {
                if (e.KeyChar == Restricao[X])
                    e.Handled = true;
            }
        }

        private void chk_Adicionar_Trecho_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Adicionar_Trecho.Checked)
            {
                pnl_Adicionar.Enabled = true;
                txt_Trecho.Focus();
            }
            else
            {
                pnl_Adicionar.Enabled = false;
                txt_Trecho.Clear();
            }
        }

        private void chk_Retirar_Trecho_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Retirar_Trecho.Checked)
            {
                pnl_Retirar.Enabled = true;
                msk_Tamanho_Trecho.Focus();
            }
            else
            {
                rdb_Inicio_Retirar.Checked = true;
                msk_Tamanho_Trecho.Clear();
                pnl_Retirar.Enabled = false;
            }
        }

        private void msk_Tamanho_Trecho_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Back))
                e.SuppressKeyPress = true;
        }
    }
}