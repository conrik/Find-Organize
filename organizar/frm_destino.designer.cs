namespace Find_And_Organize
{
    partial class frm_destino
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
            this.rb_multiplo = new System.Windows.Forms.RadioButton();
            this.rb_padrao = new System.Windows.Forms.RadioButton();
            this.rb_unico = new System.Windows.Forms.RadioButton();
            this.gb_multiplo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_imagem = new System.Windows.Forms.Button();
            this.btn_musica = new System.Windows.Forms.Button();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_documento = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_imagem = new System.Windows.Forms.Label();
            this.lbl_musica = new System.Windows.Forms.Label();
            this.lbl_video = new System.Windows.Forms.Label();
            this.lbl_documento = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_padrao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_drivers = new System.Windows.Forms.ComboBox();
            this.gb_unico = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_destino_unico = new System.Windows.Forms.Label();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_mover = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_multiplo.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gb_padrao.SuspendLayout();
            this.gb_unico.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_multiplo);
            this.groupBox1.Controls.Add(this.rb_padrao);
            this.groupBox1.Controls.Add(this.rb_unico);
            this.groupBox1.Controls.Add(this.gb_multiplo);
            this.groupBox1.Controls.Add(this.gb_padrao);
            this.groupBox1.Controls.Add(this.gb_unico);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // rb_multiplo
            // 
            this.rb_multiplo.AutoSize = true;
            this.rb_multiplo.Location = new System.Drawing.Point(11, 303);
            this.rb_multiplo.Name = "rb_multiplo";
            this.rb_multiplo.Size = new System.Drawing.Size(14, 13);
            this.rb_multiplo.TabIndex = 4;
            this.rb_multiplo.UseVisualStyleBackColor = true;
            this.rb_multiplo.CheckedChanged += new System.EventHandler(this.rb_multiplo_CheckedChanged);
            // 
            // rb_padrao
            // 
            this.rb_padrao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_padrao.AutoSize = true;
            this.rb_padrao.Location = new System.Drawing.Point(11, 82);
            this.rb_padrao.Name = "rb_padrao";
            this.rb_padrao.Size = new System.Drawing.Size(14, 13);
            this.rb_padrao.TabIndex = 3;
            this.rb_padrao.UseVisualStyleBackColor = true;
            this.rb_padrao.CheckedChanged += new System.EventHandler(this.rb_padrao_CheckedChanged);
            // 
            // rb_unico
            // 
            this.rb_unico.AutoSize = true;
            this.rb_unico.Location = new System.Drawing.Point(380, 82);
            this.rb_unico.Name = "rb_unico";
            this.rb_unico.Size = new System.Drawing.Size(14, 13);
            this.rb_unico.TabIndex = 2;
            this.rb_unico.UseVisualStyleBackColor = true;
            this.rb_unico.CheckedChanged += new System.EventHandler(this.rb_unico_CheckedChanged);
            // 
            // gb_multiplo
            // 
            this.gb_multiplo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_multiplo.Controls.Add(this.flowLayoutPanel3);
            this.gb_multiplo.Controls.Add(this.flowLayoutPanel2);
            this.gb_multiplo.Controls.Add(this.flowLayoutPanel1);
            this.gb_multiplo.Enabled = false;
            this.gb_multiplo.Location = new System.Drawing.Point(31, 222);
            this.gb_multiplo.Name = "gb_multiplo";
            this.gb_multiplo.Size = new System.Drawing.Size(624, 163);
            this.gb_multiplo.TabIndex = 1;
            this.gb_multiplo.TabStop = false;
            this.gb_multiplo.Text = "Múltiplo - Selecionar os diretorios de destino separando por tipo de arquivo";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btn_imagem);
            this.flowLayoutPanel3.Controls.Add(this.btn_musica);
            this.flowLayoutPanel3.Controls.Add(this.btn_video);
            this.flowLayoutPanel3.Controls.Add(this.btn_documento);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(491, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 3, 0, 10);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(130, 144);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // btn_imagem
            // 
            this.btn_imagem.Enabled = false;
            this.btn_imagem.Location = new System.Drawing.Point(13, 6);
            this.btn_imagem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btn_imagem.Name = "btn_imagem";
            this.btn_imagem.Size = new System.Drawing.Size(104, 23);
            this.btn_imagem.TabIndex = 3;
            this.btn_imagem.Text = "Selecionar";
            this.btn_imagem.UseVisualStyleBackColor = true;
            this.btn_imagem.Click += new System.EventHandler(this.btn_imagem_Click);
            // 
            // btn_musica
            // 
            this.btn_musica.Enabled = false;
            this.btn_musica.Location = new System.Drawing.Point(13, 40);
            this.btn_musica.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btn_musica.Name = "btn_musica";
            this.btn_musica.Size = new System.Drawing.Size(104, 23);
            this.btn_musica.TabIndex = 5;
            this.btn_musica.Text = "Selecionar";
            this.btn_musica.UseVisualStyleBackColor = true;
            this.btn_musica.Click += new System.EventHandler(this.btn_musica_Click);
            // 
            // btn_video
            // 
            this.btn_video.Enabled = false;
            this.btn_video.Location = new System.Drawing.Point(13, 74);
            this.btn_video.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(104, 23);
            this.btn_video.TabIndex = 7;
            this.btn_video.Text = "Selecionar";
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_documento
            // 
            this.btn_documento.Enabled = false;
            this.btn_documento.Location = new System.Drawing.Point(13, 108);
            this.btn_documento.Name = "btn_documento";
            this.btn_documento.Size = new System.Drawing.Size(104, 23);
            this.btn_documento.TabIndex = 9;
            this.btn_documento.Text = "Selecionar";
            this.btn_documento.UseVisualStyleBackColor = true;
            this.btn_documento.Click += new System.EventHandler(this.btn_documento_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.lbl_imagem);
            this.flowLayoutPanel2.Controls.Add(this.lbl_musica);
            this.flowLayoutPanel2.Controls.Add(this.lbl_video);
            this.flowLayoutPanel2.Controls.Add(this.lbl_documento);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(87, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(407, 144);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // lbl_imagem
            // 
            this.lbl_imagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imagem.AutoEllipsis = true;
            this.lbl_imagem.Location = new System.Drawing.Point(16, 10);
            this.lbl_imagem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_imagem.Name = "lbl_imagem";
            this.lbl_imagem.Size = new System.Drawing.Size(370, 13);
            this.lbl_imagem.TabIndex = 4;
            this.lbl_imagem.Text = "Não Selecionado";
            // 
            // lbl_musica
            // 
            this.lbl_musica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_musica.AutoEllipsis = true;
            this.lbl_musica.Location = new System.Drawing.Point(16, 43);
            this.lbl_musica.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_musica.Name = "lbl_musica";
            this.lbl_musica.Size = new System.Drawing.Size(370, 13);
            this.lbl_musica.TabIndex = 6;
            this.lbl_musica.Text = "Não Selecionado";
            // 
            // lbl_video
            // 
            this.lbl_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_video.AutoEllipsis = true;
            this.lbl_video.Location = new System.Drawing.Point(16, 76);
            this.lbl_video.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_video.Name = "lbl_video";
            this.lbl_video.Size = new System.Drawing.Size(370, 13);
            this.lbl_video.TabIndex = 8;
            this.lbl_video.Text = "Não Selecionado";
            // 
            // lbl_documento
            // 
            this.lbl_documento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_documento.AutoEllipsis = true;
            this.lbl_documento.Location = new System.Drawing.Point(13, 109);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(373, 13);
            this.lbl_documento.TabIndex = 10;
            this.lbl_documento.Text = "Não Selecionado";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 144);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Música";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vídeo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Documento";
            // 
            // gb_padrao
            // 
            this.gb_padrao.Controls.Add(this.label6);
            this.gb_padrao.Controls.Add(this.cb_users);
            this.gb_padrao.Controls.Add(this.label2);
            this.gb_padrao.Controls.Add(this.cb_drivers);
            this.gb_padrao.Enabled = false;
            this.gb_padrao.Location = new System.Drawing.Point(31, 42);
            this.gb_padrao.Name = "gb_padrao";
            this.gb_padrao.Size = new System.Drawing.Size(294, 112);
            this.gb_padrao.TabIndex = 1;
            this.gb_padrao.TabStop = false;
            this.gb_padrao.Text = "Padrão - Biblioteca do Windows";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Usuário";
            // 
            // cb_users
            // 
            this.cb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Location = new System.Drawing.Point(132, 40);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(92, 21);
            this.cb_users.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disco com o sistema";
            // 
            // cb_drivers
            // 
            this.cb_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drivers.FormattingEnabled = true;
            this.cb_drivers.Location = new System.Drawing.Point(13, 40);
            this.cb_drivers.Name = "cb_drivers";
            this.cb_drivers.Size = new System.Drawing.Size(92, 21);
            this.cb_drivers.TabIndex = 0;
            this.cb_drivers.SelectedIndexChanged += new System.EventHandler(this.cb_drivers_SelectedIndexChanged);
            // 
            // gb_unico
            // 
            this.gb_unico.Controls.Add(this.flowLayoutPanel4);
            this.gb_unico.Enabled = false;
            this.gb_unico.Location = new System.Drawing.Point(400, 42);
            this.gb_unico.Name = "gb_unico";
            this.gb_unico.Size = new System.Drawing.Size(265, 112);
            this.gb_unico.TabIndex = 0;
            this.gb_unico.TabStop = false;
            this.gb_unico.Text = "Único - Mover arquivos para um único local";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lbl_destino_unico);
            this.flowLayoutPanel4.Controls.Add(this.btn_selecionar);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(259, 93);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // lbl_destino_unico
            // 
            this.lbl_destino_unico.AutoEllipsis = true;
            this.lbl_destino_unico.Location = new System.Drawing.Point(13, 10);
            this.lbl_destino_unico.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_destino_unico.Name = "lbl_destino_unico";
            this.lbl_destino_unico.Size = new System.Drawing.Size(217, 13);
            this.lbl_destino_unico.TabIndex = 0;
            this.lbl_destino_unico.Text = "Não Selecionado";
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(13, 46);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(120, 33);
            this.btn_selecionar.TabIndex = 3;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 479);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(120, 33);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_mover
            // 
            this.btn_mover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mover.Location = new System.Drawing.Point(566, 479);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(120, 33);
            this.btn_mover.TabIndex = 2;
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = true;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // frm_destino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 524);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_destino";
            this.Text = "frm_destino";
            this.Load += new System.EventHandler(this.frm_destino_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_multiplo.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gb_padrao.ResumeLayout(false);
            this.gb_padrao.PerformLayout();
            this.gb_unico.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.RadioButton rb_multiplo;
        private System.Windows.Forms.RadioButton rb_padrao;
        private System.Windows.Forms.RadioButton rb_unico;
        private System.Windows.Forms.GroupBox gb_multiplo;
        private System.Windows.Forms.GroupBox gb_padrao;
        private System.Windows.Forms.GroupBox gb_unico;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Label lbl_destino_unico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_drivers;
        private System.Windows.Forms.Label lbl_imagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.Label lbl_video;
        private System.Windows.Forms.Label lbl_musica;
        public System.Windows.Forms.Button btn_documento;
        public System.Windows.Forms.Button btn_video;
        public System.Windows.Forms.Button btn_musica;
        public System.Windows.Forms.Button btn_imagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_users;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}