namespace Find_And_Organize
{
    partial class frm_mover
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
            this.progressoTot = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressoDoc = new System.Windows.Forms.ProgressBar();
            this.progressoVid = new System.Windows.Forms.ProgressBar();
            this.progressoMus = new System.Windows.Forms.ProgressBar();
            this.progressoImg = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_arquivo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.backMover = new System.ComponentModel.BackgroundWorker();
            this.lbl_porcTot = new System.Windows.Forms.Label();
            this.backReverter = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressoTot
            // 
            this.progressoTot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressoTot.Location = new System.Drawing.Point(12, 140);
            this.progressoTot.Name = "progressoTot";
            this.progressoTot.Size = new System.Drawing.Size(622, 23);
            this.progressoTot.Step = 1;
            this.progressoTot.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.progressoDoc);
            this.groupBox1.Controls.Add(this.progressoVid);
            this.groupBox1.Controls.Add(this.progressoMus);
            this.groupBox1.Controls.Add(this.progressoImg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // progressoDoc
            // 
            this.progressoDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressoDoc.Location = new System.Drawing.Point(129, 157);
            this.progressoDoc.Name = "progressoDoc";
            this.progressoDoc.Size = new System.Drawing.Size(394, 13);
            this.progressoDoc.Step = 1;
            this.progressoDoc.TabIndex = 11;
            // 
            // progressoVid
            // 
            this.progressoVid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressoVid.Location = new System.Drawing.Point(129, 114);
            this.progressoVid.Name = "progressoVid";
            this.progressoVid.Size = new System.Drawing.Size(394, 13);
            this.progressoVid.Step = 1;
            this.progressoVid.TabIndex = 10;
            // 
            // progressoMus
            // 
            this.progressoMus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressoMus.Location = new System.Drawing.Point(129, 73);
            this.progressoMus.Name = "progressoMus";
            this.progressoMus.Size = new System.Drawing.Size(394, 13);
            this.progressoMus.Step = 1;
            this.progressoMus.TabIndex = 9;
            // 
            // progressoImg
            // 
            this.progressoImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressoImg.Location = new System.Drawing.Point(129, 36);
            this.progressoImg.Name = "progressoImg";
            this.progressoImg.Size = new System.Drawing.Size(394, 13);
            this.progressoImg.Step = 1;
            this.progressoImg.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vídeo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Música";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Imagem";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(12, 25);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(658, 39);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Calculando Espaço...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_arquivo
            // 
            this.lbl_arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_arquivo.Location = new System.Drawing.Point(12, 64);
            this.lbl_arquivo.Name = "lbl_arquivo";
            this.lbl_arquivo.Size = new System.Drawing.Size(658, 39);
            this.lbl_arquivo.TabIndex = 3;
            this.lbl_arquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_finalizar.Location = new System.Drawing.Point(550, 412);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(120, 33);
            this.btn_finalizar.TabIndex = 6;
            this.btn_finalizar.Text = "Cancelar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // backMover
            // 
            this.backMover.WorkerReportsProgress = true;
            this.backMover.WorkerSupportsCancellation = true;
            this.backMover.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backMover_DoWork);
            this.backMover.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backMover_ProgressChanged);
            this.backMover.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backMover_RunWorkerCompleted);
            // 
            // lbl_porcTot
            // 
            this.lbl_porcTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_porcTot.Location = new System.Drawing.Point(643, 140);
            this.lbl_porcTot.Name = "lbl_porcTot";
            this.lbl_porcTot.Size = new System.Drawing.Size(27, 23);
            this.lbl_porcTot.TabIndex = 7;
            // 
            // backReverter
            // 
            this.backReverter.WorkerReportsProgress = true;
            this.backReverter.WorkerSupportsCancellation = true;
            this.backReverter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backReverter_DoWork);
            this.backReverter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backReverter_ProgressChanged);
            this.backReverter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backReverter_RunWorkerCompleted);
            // 
            // frm_mover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.lbl_porcTot);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_arquivo);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressoTot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mover";
            this.Text = "frm_mover";
            this.Load += new System.EventHandler(this.frm_mover_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressoTot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressoDoc;
        private System.Windows.Forms.ProgressBar progressoVid;
        private System.Windows.Forms.ProgressBar progressoMus;
        private System.Windows.Forms.ProgressBar progressoImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_arquivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_finalizar;
        private System.ComponentModel.BackgroundWorker backMover;
        private System.Windows.Forms.Label lbl_porcTot;
        private System.ComponentModel.BackgroundWorker backReverter;
    }
}