namespace Find_And_Organize
{
    partial class frm_origem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_origem = new System.Windows.Forms.Label();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_origem);
            this.groupBox1.Controls.Add(this.btn_selecionar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origem";
            // 
            // lbl_origem
            // 
            this.lbl_origem.AutoEllipsis = true;
            this.lbl_origem.Location = new System.Drawing.Point(177, 37);
            this.lbl_origem.Name = "lbl_origem";
            this.lbl_origem.Size = new System.Drawing.Size(384, 13);
            this.lbl_origem.TabIndex = 4;
            this.lbl_origem.Text = "Não selecionado";
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(23, 66);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(120, 33);
            this.btn_selecionar.TabIndex = 0;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local para pesquisar arquivos:\r\n";
            // 
            // btn_continuar
            // 
            this.btn_continuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_continuar.Location = new System.Drawing.Point(566, 213);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(120, 33);
            this.btn_continuar.TabIndex = 1;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // frm_origem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 524);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_origem";
            this.Text = "frm_origem";
            this.Load += new System.EventHandler(this.frm_origem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_continuar;
        public System.Windows.Forms.Label lbl_origem;
    }
}

