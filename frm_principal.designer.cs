namespace Find_And_Organize
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_atual = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pn_form = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_mover = new System.Windows.Forms.Button();
            this.btn_duplicata = new System.Windows.Forms.Button();
            this.btn_renomear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 530);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_mover);
            this.flowLayoutPanel1.Controls.Add(this.btn_duplicata);
            this.flowLayoutPanel1.Controls.Add(this.btn_renomear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(101, 524);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.lbl_atual);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 70);
            this.panel2.TabIndex = 4;
            // 
            // lbl_atual
            // 
            this.lbl_atual.AutoSize = true;
            this.lbl_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_atual.Location = new System.Drawing.Point(141, 34);
            this.lbl_atual.Name = "lbl_atual";
            this.lbl_atual.Size = new System.Drawing.Size(64, 25);
            this.lbl_atual.TabIndex = 1;
            this.lbl_atual.Text = "Home";
            // 
            // pn_form
            // 
            this.pn_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_form.Location = new System.Drawing.Point(107, 70);
            this.pn_form.Name = "pn_form";
            this.pn_form.Size = new System.Drawing.Size(713, 524);
            this.pn_form.TabIndex = 5;
            this.pn_form.Tag = "form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::Find_And_Organize.Properties.Resources.logo_3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Image = global::Find_And_Organize.Properties.Resources.home;
            this.btn_home.Location = new System.Drawing.Point(3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(101, 81);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_home, "Home");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_mover
            // 
            this.btn_mover.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_mover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mover.Image = global::Find_And_Organize.Properties.Resources.organizar;
            this.btn_mover.Location = new System.Drawing.Point(3, 90);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(101, 81);
            this.btn_mover.TabIndex = 2;
            this.btn_mover.Text = "Organizar";
            this.btn_mover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_mover, "Organizar");
            this.btn_mover.UseVisualStyleBackColor = false;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // btn_duplicata
            // 
            this.btn_duplicata.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_duplicata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_duplicata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_duplicata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_duplicata.Image = global::Find_And_Organize.Properties.Resources.duplicatas;
            this.btn_duplicata.Location = new System.Drawing.Point(3, 177);
            this.btn_duplicata.Name = "btn_duplicata";
            this.btn_duplicata.Size = new System.Drawing.Size(101, 81);
            this.btn_duplicata.TabIndex = 1;
            this.btn_duplicata.Text = "Duplicata";
            this.btn_duplicata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_duplicata, "Duplicata");
            this.btn_duplicata.UseVisualStyleBackColor = false;
            this.btn_duplicata.Click += new System.EventHandler(this.btn_duplicata_Click);
            // 
            // btn_renomear
            // 
            this.btn_renomear.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_renomear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_renomear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renomear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_renomear.Image = global::Find_And_Organize.Properties.Resources.rename;
            this.btn_renomear.Location = new System.Drawing.Point(3, 264);
            this.btn_renomear.Name = "btn_renomear";
            this.btn_renomear.Size = new System.Drawing.Size(101, 81);
            this.btn_renomear.TabIndex = 0;
            this.btn_renomear.Text = "Renomear";
            this.btn_renomear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_renomear, "Renomear");
            this.btn_renomear.UseVisualStyleBackColor = false;
            this.btn_renomear.Click += new System.EventHandler(this.btn_renomear_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.Controls.Add(this.pn_form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(836, 633);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find & Organize";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.Resize += new System.EventHandler(this.frm_principal_Resize);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_renomear;
        private System.Windows.Forms.Button btn_duplicata;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pn_form;
        private System.Windows.Forms.Label lbl_atual;

    }
}

