namespace Find_And_Organize
{
    partial class frm_inicio
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
            this.lbl_origem = new System.Windows.Forms.Label();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ck_imagem = new System.Windows.Forms.CheckBox();
            this.ck_musica = new System.Windows.Forms.CheckBox();
            this.ck_video = new System.Windows.Forms.CheckBox();
            this.ck_documento = new System.Windows.Forms.CheckBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_origem
            // 
            this.lbl_origem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_origem.AutoEllipsis = true;
            this.lbl_origem.Location = new System.Drawing.Point(32, 45);
            this.lbl_origem.Name = "lbl_origem";
            this.lbl_origem.Size = new System.Drawing.Size(620, 13);
            this.lbl_origem.TabIndex = 1;
            this.lbl_origem.Text = "Não selecionado";
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(35, 76);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(120, 33);
            this.btn_selecionar.TabIndex = 0;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_selecionar);
            this.groupBox1.Controls.Add(this.lbl_origem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o local a procurar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procurar por:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ck_imagem);
            this.flowLayoutPanel1.Controls.Add(this.ck_musica);
            this.flowLayoutPanel1.Controls.Add(this.ck_video);
            this.flowLayoutPanel1.Controls.Add(this.ck_documento);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 141);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ck_imagem
            // 
            this.ck_imagem.AutoSize = true;
            this.ck_imagem.Checked = true;
            this.ck_imagem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_imagem.Location = new System.Drawing.Point(13, 3);
            this.ck_imagem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.ck_imagem.Name = "ck_imagem";
            this.ck_imagem.Size = new System.Drawing.Size(66, 17);
            this.ck_imagem.TabIndex = 2;
            this.ck_imagem.Text = "Imagens";
            this.ck_imagem.UseVisualStyleBackColor = true;
            // 
            // ck_musica
            // 
            this.ck_musica.AutoSize = true;
            this.ck_musica.Checked = true;
            this.ck_musica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_musica.Location = new System.Drawing.Point(13, 37);
            this.ck_musica.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.ck_musica.Name = "ck_musica";
            this.ck_musica.Size = new System.Drawing.Size(65, 17);
            this.ck_musica.TabIndex = 2;
            this.ck_musica.Text = "Músicas";
            this.ck_musica.UseVisualStyleBackColor = true;
            // 
            // ck_video
            // 
            this.ck_video.AutoSize = true;
            this.ck_video.Checked = true;
            this.ck_video.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_video.Location = new System.Drawing.Point(13, 71);
            this.ck_video.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.ck_video.Name = "ck_video";
            this.ck_video.Size = new System.Drawing.Size(60, 17);
            this.ck_video.TabIndex = 3;
            this.ck_video.Text = "Vídeos";
            this.ck_video.UseVisualStyleBackColor = true;
            // 
            // ck_documento
            // 
            this.ck_documento.AutoSize = true;
            this.ck_documento.Checked = true;
            this.ck_documento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_documento.Location = new System.Drawing.Point(13, 105);
            this.ck_documento.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.ck_documento.Name = "ck_documento";
            this.ck_documento.Size = new System.Drawing.Size(86, 17);
            this.ck_documento.TabIndex = 4;
            this.ck_documento.Text = "Documentos";
            this.ck_documento.UseVisualStyleBackColor = true;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_procurar.Location = new System.Drawing.Point(550, 412);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(120, 33);
            this.btn_procurar.TabIndex = 7;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_procurar;
        public System.Windows.Forms.Label lbl_origem;
        public System.Windows.Forms.CheckBox ck_imagem;
        public System.Windows.Forms.CheckBox ck_musica;
        public System.Windows.Forms.CheckBox ck_video;
        public System.Windows.Forms.CheckBox ck_documento;
    }
}

