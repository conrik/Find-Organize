namespace Find_And_Organize
{
    partial class frm_deletar
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
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.lbl_atual = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.backDeletar = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progresso
            // 
            this.progresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progresso.Location = new System.Drawing.Point(12, 324);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(582, 23);
            this.progresso.Step = 1;
            this.progresso.TabIndex = 0;
            // 
            // lbl_atual
            // 
            this.lbl_atual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_atual.Location = new System.Drawing.Point(12, 186);
            this.lbl_atual.Name = "lbl_atual";
            this.lbl_atual.Size = new System.Drawing.Size(582, 47);
            this.lbl_atual.TabIndex = 2;
            this.lbl_atual.Text = "Arquivo";
            this.lbl_atual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(12, 53);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(582, 47);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_finalizar.Location = new System.Drawing.Point(457, 359);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(137, 23);
            this.btn_finalizar.TabIndex = 4;
            this.btn_finalizar.Text = "Cancelar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // backDeletar
            // 
            this.backDeletar.WorkerReportsProgress = true;
            this.backDeletar.WorkerSupportsCancellation = true;
            this.backDeletar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backDeletar_DoWork);
            this.backDeletar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backDeletar_ProgressChanged);
            this.backDeletar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backDeletar_RunWorkerCompleted);
            // 
            // frm_deletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_atual);
            this.Controls.Add(this.progresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_deletar";
            this.Text = "frm_deletar";
            this.Load += new System.EventHandler(this.frm_deletar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Label lbl_atual;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_finalizar;
        private System.ComponentModel.BackgroundWorker backDeletar;
    }
}