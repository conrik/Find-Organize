namespace Find_And_Organize
{
    partial class frm_resultado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_duplicatas = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_sel = new System.Windows.Forms.Button();
            this.btn_des = new System.Windows.Forms.Button();
            this.backArvore = new System.ComponentModel.BackgroundWorker();
            this.backSeparacao = new System.ComponentModel.BackgroundWorker();
            this.backDocumento = new System.ComponentModel.BackgroundWorker();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrir_local = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.backImagem = new System.ComponentModel.BackgroundWorker();
            this.backMusica = new System.ComponentModel.BackgroundWorker();
            this.backVideo = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_status);
            this.flowLayoutPanel1.Controls.Add(this.lbl_duplicatas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 322);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(3, 10);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(125, 61);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Procurando...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_duplicatas
            // 
            this.lbl_duplicatas.AutoSize = true;
            this.lbl_duplicatas.Location = new System.Drawing.Point(3, 91);
            this.lbl_duplicatas.Name = "lbl_duplicatas";
            this.lbl_duplicatas.Size = new System.Drawing.Size(0, 13);
            this.lbl_duplicatas.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(155, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 308);
            this.tabControl1.TabIndex = 1;
            // 
            // progresso
            // 
            this.progresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progresso.Location = new System.Drawing.Point(155, 359);
            this.progresso.MarqueeAnimationSpeed = 10;
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(441, 33);
            this.progresso.Step = 1;
            this.progresso.TabIndex = 2;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 359);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(137, 33);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Cancelar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_sel
            // 
            this.btn_sel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sel.Enabled = false;
            this.btn_sel.Location = new System.Drawing.Point(155, 330);
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.Size = new System.Drawing.Size(137, 23);
            this.btn_sel.TabIndex = 4;
            this.btn_sel.Text = "Selecionar Tudo";
            this.btn_sel.UseVisualStyleBackColor = true;
            this.btn_sel.Click += new System.EventHandler(this.btn_sel_Click);
            // 
            // btn_des
            // 
            this.btn_des.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_des.Enabled = false;
            this.btn_des.Location = new System.Drawing.Point(298, 330);
            this.btn_des.Name = "btn_des";
            this.btn_des.Size = new System.Drawing.Size(137, 23);
            this.btn_des.TabIndex = 5;
            this.btn_des.Text = "Deselecionar Tudo";
            this.btn_des.UseVisualStyleBackColor = true;
            this.btn_des.Click += new System.EventHandler(this.btn_des_Click);
            // 
            // backArvore
            // 
            this.backArvore.WorkerSupportsCancellation = true;
            this.backArvore.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backArvore_DoWork);
            this.backArvore.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backArvore_RunWorkerCompleted);
            // 
            // backSeparacao
            // 
            this.backSeparacao.WorkerReportsProgress = true;
            this.backSeparacao.WorkerSupportsCancellation = true;
            this.backSeparacao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backSeparar_DoWork);
            this.backSeparacao.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backSeparacao_ProgressChanged);
            this.backSeparacao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backSeparacao_RunWorkerCompleted);
            // 
            // backDocumento
            // 
            this.backDocumento.WorkerReportsProgress = true;
            this.backDocumento.WorkerSupportsCancellation = true;
            this.backDocumento.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EqualsDoWork);
            this.backDocumento.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EqualsProgressChanged);
            this.backDocumento.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EqualsRunWorkerCompleted);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deletar.Location = new System.Drawing.Point(466, 359);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(134, 33);
            this.btn_deletar.TabIndex = 6;
            this.btn_deletar.Text = "Deletar Selecionados";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Visible = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrir_local,
            this.abrir_arquivo});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(146, 48);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // abrir_local
            // 
            this.abrir_local.Name = "abrir_local";
            this.abrir_local.Size = new System.Drawing.Size(145, 22);
            this.abrir_local.Text = "Abrir Local";
            this.abrir_local.Click += new System.EventHandler(this.abrir_local_Click);
            // 
            // abrir_arquivo
            // 
            this.abrir_arquivo.Name = "abrir_arquivo";
            this.abrir_arquivo.Size = new System.Drawing.Size(145, 22);
            this.abrir_arquivo.Text = "Abrir Arquivo";
            this.abrir_arquivo.Click += new System.EventHandler(this.abrir_arquivo_Click);
            // 
            // backImagem
            // 
            this.backImagem.WorkerReportsProgress = true;
            this.backImagem.WorkerSupportsCancellation = true;
            this.backImagem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EqualsDoWork);
            this.backImagem.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EqualsProgressChanged);
            this.backImagem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EqualsRunWorkerCompleted);
            // 
            // backMusica
            // 
            this.backMusica.WorkerReportsProgress = true;
            this.backMusica.WorkerSupportsCancellation = true;
            this.backMusica.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EqualsDoWork);
            this.backMusica.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EqualsProgressChanged);
            this.backMusica.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EqualsRunWorkerCompleted);
            // 
            // backVideo
            // 
            this.backVideo.WorkerReportsProgress = true;
            this.backVideo.WorkerSupportsCancellation = true;
            this.backVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EqualsDoWork);
            this.backVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EqualsProgressChanged);
            this.backVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EqualsRunWorkerCompleted);
            // 
            // frm_resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.btn_des);
            this.Controls.Add(this.btn_sel);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_resultado";
            this.Load += new System.EventHandler(this.frm_resultado_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_sel;
        private System.Windows.Forms.Button btn_des;
        private System.ComponentModel.BackgroundWorker backArvore;
        private System.ComponentModel.BackgroundWorker backSeparacao;
        private System.ComponentModel.BackgroundWorker backDocumento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_duplicatas;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem abrir_arquivo;
        private System.Windows.Forms.ToolStripMenuItem abrir_local;
        private System.ComponentModel.BackgroundWorker backImagem;
        private System.ComponentModel.BackgroundWorker backMusica;
        private System.ComponentModel.BackgroundWorker backVideo;
    }
}