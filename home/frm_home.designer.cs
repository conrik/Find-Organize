namespace Find_And_Organize
{
    partial class frm_home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.crt_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.lbl_disp = new System.Windows.Forms.Label();
            this.lbl_usa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_drivers = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_sobre = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.aviso = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.backMFT = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.crt_grafico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aviso)).BeginInit();
            this.SuspendLayout();
            // 
            // crt_grafico
            // 
            this.crt_grafico.BackColor = System.Drawing.Color.Transparent;
            this.crt_grafico.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.crt_grafico.ChartAreas.Add(chartArea2);
            this.crt_grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.crt_grafico.Legends.Add(legend2);
            this.crt_grafico.Location = new System.Drawing.Point(3, 16);
            this.crt_grafico.Name = "crt_grafico";
            this.crt_grafico.Size = new System.Drawing.Size(490, 477);
            this.crt_grafico.TabIndex = 0;
            this.crt_grafico.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_tot);
            this.flowLayoutPanel1.Controls.Add(this.lbl_disp);
            this.flowLayoutPanel1.Controls.Add(this.lbl_usa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 28, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 391);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoEllipsis = true;
            this.lbl_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot.Location = new System.Drawing.Point(13, 28);
            this.lbl_tot.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(145, 40);
            this.lbl_tot.TabIndex = 1;
            this.lbl_tot.Text = "label2";
            // 
            // lbl_disp
            // 
            this.lbl_disp.AutoEllipsis = true;
            this.lbl_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disp.Location = new System.Drawing.Point(13, 83);
            this.lbl_disp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbl_disp.Name = "lbl_disp";
            this.lbl_disp.Size = new System.Drawing.Size(145, 40);
            this.lbl_disp.TabIndex = 3;
            this.lbl_disp.Text = "label2";
            // 
            // lbl_usa
            // 
            this.lbl_usa.AutoEllipsis = true;
            this.lbl_usa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usa.Location = new System.Drawing.Point(13, 138);
            this.lbl_usa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbl_usa.Name = "lbl_usa";
            this.lbl_usa.Size = new System.Drawing.Size(145, 40);
            this.lbl_usa.TabIndex = 5;
            this.lbl_usa.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mídia";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cb_drivers);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(164, 65);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // cb_drivers
            // 
            this.cb_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drivers.Enabled = false;
            this.cb_drivers.FormattingEnabled = true;
            this.cb_drivers.Location = new System.Drawing.Point(23, 23);
            this.cb_drivers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.cb_drivers.Name = "cb_drivers";
            this.cb_drivers.Size = new System.Drawing.Size(126, 21);
            this.cb_drivers.TabIndex = 0;
            this.cb_drivers.SelectedIndexChanged += new System.EventHandler(this.cb_drivers_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbl_sobre);
            this.groupBox3.Controls.Add(this.logo);
            this.groupBox3.Controls.Add(this.aviso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_status);
            this.groupBox3.Controls.Add(this.crt_grafico);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(190, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 496);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // lbl_sobre
            // 
            this.lbl_sobre.AutoSize = true;
            this.lbl_sobre.Location = new System.Drawing.Point(122, 87);
            this.lbl_sobre.Name = "lbl_sobre";
            this.lbl_sobre.Size = new System.Drawing.Size(89, 26);
            this.lbl_sobre.TabIndex = 5;
            this.lbl_sobre.Text = "Find & Organize\r\nVersão: 1.0\r\n";
            this.lbl_sobre.Visible = false;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Find_And_Organize.Properties.Resources.logo4;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(24, 64);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(104, 53);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // aviso
            // 
            this.aviso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aviso.BackgroundImage = global::Find_And_Organize.Properties.Resources.wa;
            this.aviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aviso.Location = new System.Drawing.Point(4, 442);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(35, 35);
            this.aviso.TabIndex = 3;
            this.aviso.TabStop = false;
            this.aviso.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(38, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para uma visualização da representação gráfica execute no modo administrador";
            this.label1.Visible = false;
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(191, 223);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(108, 17);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Carregando...";
            this.lbl_status.Visible = false;
            // 
            // backMFT
            // 
            this.backMFT.WorkerSupportsCancellation = true;
            this.backMFT.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backMFT_DoWork);
            this.backMFT.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backMFT_RunWorkerCompleted);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crt_grafico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aviso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crt_grafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.Label lbl_disp;
        private System.Windows.Forms.Label lbl_usa;
        private System.Windows.Forms.ComboBox cb_drivers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backMFT;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox aviso;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl_sobre;
    }
}

