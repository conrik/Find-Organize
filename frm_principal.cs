using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Find_And_Organize
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        Button botao_sel = null;

        private void btn_duplicata_Click(object sender, EventArgs e)
        {
            if (botao_sel != (Button)sender)
            {
                lbl_atual.Text = "Duplicata";
                LimparForms();
                pn_form.Controls.Clear();
                botao_sel = (Button)sender;
                frm_inicio dupli = new frm_inicio();
                dupli.TopLevel = false;
                dupli.Size = pn_form.Size;
                pn_form.Controls.Add(dupli);
                dupli.Show();
            }
        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            if (botao_sel != (Button)sender)
            {
                lbl_atual.Text = "Organizar";
                LimparForms();
                pn_form.Controls.Clear();
                botao_sel = (Button)sender;
                frm_origem mov_origem = new frm_origem();
                mov_origem.TopLevel = false;
                mov_origem.Size = pn_form.Size;
                pn_form.Controls.Add(mov_origem);
                mov_origem.Show();
            }
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            botao_sel = btn_home;
            frm_home home = new frm_home();
            home.TopLevel = false;
            home.Size = pn_form.Size;
            pn_form.Controls.Add(home);
            home.Show();
        }

        private void frm_principal_Resize(object sender, EventArgs e)
        {
            if (pn_form.Controls.Count != 0)
                foreach(Control c in pn_form.Controls)
                     c.Size = pn_form.Size;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (botao_sel != (Button)sender)
            {
                lbl_atual.Text = "Home";
                LimparForms();
                pn_form.Controls.Clear();
                botao_sel = (Button)sender;
                frm_home home = new frm_home();
                home.TopLevel = false;
                home.Size = pn_form.Size;
                pn_form.Controls.Add(home);
                home.Show();
            }
        }

        private void LimparForms()
        {
            for (int i = Application.OpenForms.Count; i > 1 ; i--)
            {
                Application.OpenForms[i-1].Close();
            }
        }

        private void btn_renomear_Click(object sender, EventArgs e)
        {
            if (botao_sel != (Button)sender)
            {
                lbl_atual.Text = "Renomear";
                LimparForms();
                pn_form.Controls.Clear();
                botao_sel = (Button)sender;
                frm_renomear ren = new frm_renomear();
                ren.TopLevel = false;
                ren.Size = pn_form.Size;
                pn_form.Controls.Add(ren);
                ren.Show();
            }
        }
    }
}
