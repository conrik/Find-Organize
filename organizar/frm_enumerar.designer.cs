namespace Find_And_Organize
{
    partial class frm_enumerar
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
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lbl_status = new System.Windows.Forms.Label();
            this.backArvore = new System.ComponentModel.BackgroundWorker();
            this.backSeparacao = new System.ComponentModel.BackgroundWorker();
            this.menuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Abrir_local = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.btn_deselecionar = new System.Windows.Forms.Button();
            this.backMFT = new System.ComponentModel.BackgroundWorker();
            this.menuContexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // progresso
            // 
            this.progresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progresso.Location = new System.Drawing.Point(138, 412);
            this.progresso.MarqueeAnimationSpeed = 10;
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(403, 32);
            this.progresso.Step = 1;
            this.progresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progresso.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 412);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(120, 33);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_continuar
            // 
            this.btn_continuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_continuar.Enabled = false;
            this.btn_continuar.Location = new System.Drawing.Point(550, 412);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(120, 33);
            this.btn_continuar.TabIndex = 2;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 339);
            this.tabControl1.TabIndex = 3;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(12, 9);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(162, 17);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Buscando Arquivos...";
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
            this.backSeparacao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backSeparacao_DoWork);
            this.backSeparacao.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backSeparacao_ProgressChanged);
            this.backSeparacao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backSeparacao_RunWorkerCompleted);
            // 
            // menuContexto
            // 
            this.menuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir_local,
            this.Abrir_arquivo});
            this.menuContexto.Name = "menuContexto";
            this.menuContexto.Size = new System.Drawing.Size(146, 48);
            this.menuContexto.Opening += new System.ComponentModel.CancelEventHandler(this.menuContexto_Opening);
            // 
            // Abrir_local
            // 
            this.Abrir_local.Name = "Abrir_local";
            this.Abrir_local.Size = new System.Drawing.Size(145, 22);
            this.Abrir_local.Text = "Abrir Local";
            this.Abrir_local.Click += new System.EventHandler(this.Abrir_local_Click);
            // 
            // Abrir_arquivo
            // 
            this.Abrir_arquivo.Name = "Abrir_arquivo";
            this.Abrir_arquivo.Size = new System.Drawing.Size(145, 22);
            this.Abrir_arquivo.Text = "Abrir Arquivo";
            this.Abrir_arquivo.Click += new System.EventHandler(this.Abrir_arquivo_Click);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_selecionar.Enabled = false;
            this.btn_selecionar.Location = new System.Drawing.Point(12, 379);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(123, 23);
            this.btn_selecionar.TabIndex = 5;
            this.btn_selecionar.Text = "Selecionar Tudo";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // btn_deselecionar
            // 
            this.btn_deselecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deselecionar.Enabled = false;
            this.btn_deselecionar.Location = new System.Drawing.Point(150, 379);
            this.btn_deselecionar.Name = "btn_deselecionar";
            this.btn_deselecionar.Size = new System.Drawing.Size(123, 23);
            this.btn_deselecionar.TabIndex = 6;
            this.btn_deselecionar.Text = "Deselecionar Tudo";
            this.btn_deselecionar.UseVisualStyleBackColor = true;
            this.btn_deselecionar.Click += new System.EventHandler(this.btn_deselecionar_Click);
            // 
            // backMFT
            // 
            this.backMFT.WorkerSupportsCancellation = true;
            this.backMFT.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backMFT_DoWork);
            this.backMFT.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backMFT_RunWorkerCompleted);
            // 
            // frm_enumerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.btn_deselecionar);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.progresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_enumerar";
            this.Text = "frm_enumerar";
            this.Load += new System.EventHandler(this.frm_enumerar_Load);
            this.menuContexto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_status;
        private System.ComponentModel.BackgroundWorker backArvore;
        private System.ComponentModel.BackgroundWorker backSeparacao;
        private System.Windows.Forms.ContextMenuStrip menuContexto;
        private System.Windows.Forms.ToolStripMenuItem Abrir_local;
        private System.Windows.Forms.ToolStripMenuItem Abrir_arquivo;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Button btn_deselecionar;
        private System.ComponentModel.BackgroundWorker backMFT;
    }
}