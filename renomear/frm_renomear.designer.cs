namespace Find_And_Organize
{
    partial class frm_renomear
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lst_Arquivos = new System.Windows.Forms.ListBox();
            this.lst_Renomear = new System.Windows.Forms.ListBox();
            this.btn_Renomear = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.gpb_Opcoes = new System.Windows.Forms.GroupBox();
            this.pnl_Adicionar = new System.Windows.Forms.Panel();
            this.txt_Trecho = new System.Windows.Forms.TextBox();
            this.rdb_Fim_Adicionar = new System.Windows.Forms.RadioButton();
            this.rdb_Inicio_Adicionar = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_Adicionar_Trecho = new System.Windows.Forms.CheckBox();
            this.pnl_Retirar = new System.Windows.Forms.Panel();
            this.msk_Tamanho_Trecho = new System.Windows.Forms.MaskedTextBox();
            this.rdb_Fim_Retirar = new System.Windows.Forms.RadioButton();
            this.rdb_Inicio_Retirar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Numerar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Digitos = new System.Windows.Forms.TextBox();
            this.txt_Inicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_Numerar = new System.Windows.Forms.CheckBox();
            this.chk_Retirar_Trecho = new System.Windows.Forms.CheckBox();
            this.pnl_Substituir = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Substituir = new System.Windows.Forms.TextBox();
            this.txt_Localizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Substituir = new System.Windows.Forms.CheckBox();
            this.lst_Extencao = new System.Windows.Forms.ListBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Desfazer = new System.Windows.Forms.Button();
            this.lst_Desfazer = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_Opcoes.SuspendLayout();
            this.pnl_Adicionar.SuspendLayout();
            this.pnl_Retirar.SuspendLayout();
            this.pnl_Numerar.SuspendLayout();
            this.pnl_Substituir.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "C:";
            this.openFileDialog1.Multiselect = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(12, 12);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(120, 33);
            this.btn_Adicionar.TabIndex = 0;
            this.btn_Adicionar.Text = "Selecionar arquivo(s)";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lst_Arquivos
            // 
            this.lst_Arquivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Arquivos.FormattingEnabled = true;
            this.lst_Arquivos.Location = new System.Drawing.Point(138, 12);
            this.lst_Arquivos.Name = "lst_Arquivos";
            this.lst_Arquivos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Arquivos.Size = new System.Drawing.Size(548, 108);
            this.lst_Arquivos.TabIndex = 2;
            this.lst_Arquivos.TabStop = false;
            this.lst_Arquivos.SelectedIndexChanged += new System.EventHandler(this.lst_Arquivos_SelectedIndexChanged);
            // 
            // lst_Renomear
            // 
            this.lst_Renomear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Renomear.FormattingEnabled = true;
            this.lst_Renomear.Location = new System.Drawing.Point(138, 321);
            this.lst_Renomear.Name = "lst_Renomear";
            this.lst_Renomear.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_Renomear.Size = new System.Drawing.Size(548, 147);
            this.lst_Renomear.TabIndex = 3;
            this.lst_Renomear.TabStop = false;
            // 
            // btn_Renomear
            // 
            this.btn_Renomear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Renomear.Location = new System.Drawing.Point(564, 282);
            this.btn_Renomear.Name = "btn_Renomear";
            this.btn_Renomear.Size = new System.Drawing.Size(120, 33);
            this.btn_Renomear.TabIndex = 9;
            this.btn_Renomear.Text = "Aplicar alterações";
            this.btn_Renomear.UseVisualStyleBackColor = true;
            this.btn_Renomear.Click += new System.EventHandler(this.btn_Renomear_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.Location = new System.Drawing.Point(440, 479);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(120, 33);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.Text = "Renomear";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // gpb_Opcoes
            // 
            this.gpb_Opcoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpb_Opcoes.Controls.Add(this.pnl_Adicionar);
            this.gpb_Opcoes.Controls.Add(this.chk_Adicionar_Trecho);
            this.gpb_Opcoes.Controls.Add(this.pnl_Retirar);
            this.gpb_Opcoes.Controls.Add(this.pnl_Numerar);
            this.gpb_Opcoes.Controls.Add(this.chk_Numerar);
            this.gpb_Opcoes.Controls.Add(this.chk_Retirar_Trecho);
            this.gpb_Opcoes.Controls.Add(this.pnl_Substituir);
            this.gpb_Opcoes.Controls.Add(this.chk_Substituir);
            this.gpb_Opcoes.Location = new System.Drawing.Point(138, 140);
            this.gpb_Opcoes.Name = "gpb_Opcoes";
            this.gpb_Opcoes.Size = new System.Drawing.Size(546, 136);
            this.gpb_Opcoes.TabIndex = 6;
            this.gpb_Opcoes.TabStop = false;
            this.gpb_Opcoes.Text = "Opções de renomeamento";
            // 
            // pnl_Adicionar
            // 
            this.pnl_Adicionar.Controls.Add(this.txt_Trecho);
            this.pnl_Adicionar.Controls.Add(this.rdb_Fim_Adicionar);
            this.pnl_Adicionar.Controls.Add(this.rdb_Inicio_Adicionar);
            this.pnl_Adicionar.Controls.Add(this.label6);
            this.pnl_Adicionar.Location = new System.Drawing.Point(412, 36);
            this.pnl_Adicionar.Name = "pnl_Adicionar";
            this.pnl_Adicionar.Size = new System.Drawing.Size(114, 89);
            this.pnl_Adicionar.TabIndex = 14;
            // 
            // txt_Trecho
            // 
            this.txt_Trecho.Location = new System.Drawing.Point(6, 45);
            this.txt_Trecho.Name = "txt_Trecho";
            this.txt_Trecho.Size = new System.Drawing.Size(100, 20);
            this.txt_Trecho.TabIndex = 12;
            this.txt_Trecho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Prefixo_KeyPress);
            // 
            // rdb_Fim_Adicionar
            // 
            this.rdb_Fim_Adicionar.AutoSize = true;
            this.rdb_Fim_Adicionar.Location = new System.Drawing.Point(53, 6);
            this.rdb_Fim_Adicionar.Name = "rdb_Fim_Adicionar";
            this.rdb_Fim_Adicionar.Size = new System.Drawing.Size(41, 17);
            this.rdb_Fim_Adicionar.TabIndex = 11;
            this.rdb_Fim_Adicionar.TabStop = true;
            this.rdb_Fim_Adicionar.Text = "Fim";
            this.rdb_Fim_Adicionar.UseVisualStyleBackColor = true;
            // 
            // rdb_Inicio_Adicionar
            // 
            this.rdb_Inicio_Adicionar.AutoSize = true;
            this.rdb_Inicio_Adicionar.Location = new System.Drawing.Point(6, 6);
            this.rdb_Inicio_Adicionar.Name = "rdb_Inicio_Adicionar";
            this.rdb_Inicio_Adicionar.Size = new System.Drawing.Size(50, 17);
            this.rdb_Inicio_Adicionar.TabIndex = 10;
            this.rdb_Inicio_Adicionar.TabStop = true;
            this.rdb_Inicio_Adicionar.Text = "Inicio";
            this.rdb_Inicio_Adicionar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trecho";
            // 
            // chk_Adicionar_Trecho
            // 
            this.chk_Adicionar_Trecho.AutoSize = true;
            this.chk_Adicionar_Trecho.Location = new System.Drawing.Point(412, 19);
            this.chk_Adicionar_Trecho.Name = "chk_Adicionar_Trecho";
            this.chk_Adicionar_Trecho.Size = new System.Drawing.Size(103, 17);
            this.chk_Adicionar_Trecho.TabIndex = 13;
            this.chk_Adicionar_Trecho.Text = "Adicionar trecho";
            this.chk_Adicionar_Trecho.UseVisualStyleBackColor = true;
            this.chk_Adicionar_Trecho.CheckedChanged += new System.EventHandler(this.chk_Adicionar_Trecho_CheckedChanged);
            // 
            // pnl_Retirar
            // 
            this.pnl_Retirar.Controls.Add(this.msk_Tamanho_Trecho);
            this.pnl_Retirar.Controls.Add(this.rdb_Fim_Retirar);
            this.pnl_Retirar.Controls.Add(this.rdb_Inicio_Retirar);
            this.pnl_Retirar.Controls.Add(this.label2);
            this.pnl_Retirar.Location = new System.Drawing.Point(6, 36);
            this.pnl_Retirar.Name = "pnl_Retirar";
            this.pnl_Retirar.Size = new System.Drawing.Size(114, 89);
            this.pnl_Retirar.TabIndex = 12;
            // 
            // msk_Tamanho_Trecho
            // 
            this.msk_Tamanho_Trecho.Location = new System.Drawing.Point(6, 45);
            this.msk_Tamanho_Trecho.Name = "msk_Tamanho_Trecho";
            this.msk_Tamanho_Trecho.Size = new System.Drawing.Size(100, 20);
            this.msk_Tamanho_Trecho.TabIndex = 12;
            // 
            // rdb_Fim_Retirar
            // 
            this.rdb_Fim_Retirar.AutoSize = true;
            this.rdb_Fim_Retirar.Location = new System.Drawing.Point(53, 6);
            this.rdb_Fim_Retirar.Name = "rdb_Fim_Retirar";
            this.rdb_Fim_Retirar.Size = new System.Drawing.Size(41, 17);
            this.rdb_Fim_Retirar.TabIndex = 11;
            this.rdb_Fim_Retirar.TabStop = true;
            this.rdb_Fim_Retirar.Text = "Fim";
            this.rdb_Fim_Retirar.UseVisualStyleBackColor = true;
            // 
            // rdb_Inicio_Retirar
            // 
            this.rdb_Inicio_Retirar.AutoSize = true;
            this.rdb_Inicio_Retirar.Location = new System.Drawing.Point(6, 6);
            this.rdb_Inicio_Retirar.Name = "rdb_Inicio_Retirar";
            this.rdb_Inicio_Retirar.Size = new System.Drawing.Size(50, 17);
            this.rdb_Inicio_Retirar.TabIndex = 10;
            this.rdb_Inicio_Retirar.TabStop = true;
            this.rdb_Inicio_Retirar.Text = "Inicio";
            this.rdb_Inicio_Retirar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tamanho do trecho";
            // 
            // pnl_Numerar
            // 
            this.pnl_Numerar.Controls.Add(this.label4);
            this.pnl_Numerar.Controls.Add(this.txt_Digitos);
            this.pnl_Numerar.Controls.Add(this.txt_Inicial);
            this.pnl_Numerar.Controls.Add(this.label5);
            this.pnl_Numerar.Location = new System.Drawing.Point(276, 36);
            this.pnl_Numerar.Name = "pnl_Numerar";
            this.pnl_Numerar.Size = new System.Drawing.Size(114, 89);
            this.pnl_Numerar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade de casas";
            // 
            // txt_Digitos
            // 
            this.txt_Digitos.Location = new System.Drawing.Point(6, 61);
            this.txt_Digitos.Name = "txt_Digitos";
            this.txt_Digitos.Size = new System.Drawing.Size(100, 20);
            this.txt_Digitos.TabIndex = 8;
            this.txt_Digitos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Prefixo_KeyPress);
            // 
            // txt_Inicial
            // 
            this.txt_Inicial.Location = new System.Drawing.Point(6, 22);
            this.txt_Inicial.Name = "txt_Inicial";
            this.txt_Inicial.Size = new System.Drawing.Size(100, 20);
            this.txt_Inicial.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_Inicial, "Número inicial da numeração");
            this.txt_Inicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Prefixo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Iniciar em";
            // 
            // chk_Numerar
            // 
            this.chk_Numerar.AutoSize = true;
            this.chk_Numerar.Location = new System.Drawing.Point(276, 19);
            this.chk_Numerar.Name = "chk_Numerar";
            this.chk_Numerar.Size = new System.Drawing.Size(66, 17);
            this.chk_Numerar.TabIndex = 9;
            this.chk_Numerar.Text = "Numerar";
            this.chk_Numerar.UseVisualStyleBackColor = true;
            this.chk_Numerar.CheckedChanged += new System.EventHandler(this.chk_Numerar_CheckedChanged);
            // 
            // chk_Retirar_Trecho
            // 
            this.chk_Retirar_Trecho.AutoSize = true;
            this.chk_Retirar_Trecho.Location = new System.Drawing.Point(6, 19);
            this.chk_Retirar_Trecho.Name = "chk_Retirar_Trecho";
            this.chk_Retirar_Trecho.Size = new System.Drawing.Size(90, 17);
            this.chk_Retirar_Trecho.TabIndex = 11;
            this.chk_Retirar_Trecho.Text = "Retirar trecho";
            this.chk_Retirar_Trecho.UseVisualStyleBackColor = true;
            this.chk_Retirar_Trecho.CheckedChanged += new System.EventHandler(this.chk_Retirar_Trecho_CheckedChanged);
            // 
            // pnl_Substituir
            // 
            this.pnl_Substituir.Controls.Add(this.label3);
            this.pnl_Substituir.Controls.Add(this.txt_Substituir);
            this.pnl_Substituir.Controls.Add(this.txt_Localizar);
            this.pnl_Substituir.Controls.Add(this.label1);
            this.pnl_Substituir.Location = new System.Drawing.Point(139, 36);
            this.pnl_Substituir.Name = "pnl_Substituir";
            this.pnl_Substituir.Size = new System.Drawing.Size(114, 89);
            this.pnl_Substituir.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Substituir";
            // 
            // txt_Substituir
            // 
            this.txt_Substituir.Location = new System.Drawing.Point(6, 61);
            this.txt_Substituir.Name = "txt_Substituir";
            this.txt_Substituir.Size = new System.Drawing.Size(100, 20);
            this.txt_Substituir.TabIndex = 8;
            this.txt_Substituir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Prefixo_KeyPress);
            // 
            // txt_Localizar
            // 
            this.txt_Localizar.Location = new System.Drawing.Point(6, 22);
            this.txt_Localizar.Name = "txt_Localizar";
            this.txt_Localizar.Size = new System.Drawing.Size(100, 20);
            this.txt_Localizar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_Localizar, "Palavra-chave do nome de arquivo");
            this.txt_Localizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Prefixo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localizar";
            // 
            // chk_Substituir
            // 
            this.chk_Substituir.AutoSize = true;
            this.chk_Substituir.Location = new System.Drawing.Point(139, 19);
            this.chk_Substituir.Name = "chk_Substituir";
            this.chk_Substituir.Size = new System.Drawing.Size(69, 17);
            this.chk_Substituir.TabIndex = 5;
            this.chk_Substituir.Text = "Substituir";
            this.chk_Substituir.UseVisualStyleBackColor = true;
            this.chk_Substituir.CheckedChanged += new System.EventHandler(this.chk_Substituir_CheckedChanged);
            // 
            // lst_Extencao
            // 
            this.lst_Extencao.FormattingEnabled = true;
            this.lst_Extencao.Location = new System.Drawing.Point(138, 334);
            this.lst_Extencao.Name = "lst_Extencao";
            this.lst_Extencao.Size = new System.Drawing.Size(532, 108);
            this.lst_Extencao.TabIndex = 13;
            this.lst_Extencao.TabStop = false;
            this.lst_Extencao.Visible = false;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpar.Location = new System.Drawing.Point(566, 479);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(120, 33);
            this.btn_Limpar.TabIndex = 11;
            this.btn_Limpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btn_Limpar, "Limpar");
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(12, 51);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(120, 33);
            this.btn_Remover.TabIndex = 14;
            this.btn_Remover.Text = "Remover da lista";
            this.toolTip1.SetToolTip(this.btn_Remover, "Remover");
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Desfazer
            // 
            this.btn_Desfazer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Desfazer.Location = new System.Drawing.Point(314, 479);
            this.btn_Desfazer.Name = "btn_Desfazer";
            this.btn_Desfazer.Size = new System.Drawing.Size(120, 33);
            this.btn_Desfazer.TabIndex = 15;
            this.btn_Desfazer.Text = "Desfazer";
            this.toolTip1.SetToolTip(this.btn_Desfazer, "Desfazer");
            this.btn_Desfazer.UseVisualStyleBackColor = true;
            this.btn_Desfazer.Click += new System.EventHandler(this.btn_Desfazer_Click);
            // 
            // lst_Desfazer
            // 
            this.lst_Desfazer.FormattingEnabled = true;
            this.lst_Desfazer.Location = new System.Drawing.Point(138, 25);
            this.lst_Desfazer.Name = "lst_Desfazer";
            this.lst_Desfazer.Size = new System.Drawing.Size(532, 108);
            this.lst_Desfazer.TabIndex = 16;
            this.lst_Desfazer.TabStop = false;
            this.lst_Desfazer.Visible = false;
            // 
            // frm_renomear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 524);
            this.Controls.Add(this.gpb_Opcoes);
            this.Controls.Add(this.lst_Desfazer);
            this.Controls.Add(this.btn_Desfazer);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lst_Extencao);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Renomear);
            this.Controls.Add(this.lst_Renomear);
            this.Controls.Add(this.lst_Arquivos);
            this.Controls.Add(this.btn_Adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(698, 524);
            this.Name = "frm_renomear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomear";
            this.Shown += new System.EventHandler(this.frm_Renomear_Shown);
            this.gpb_Opcoes.ResumeLayout(false);
            this.gpb_Opcoes.PerformLayout();
            this.pnl_Adicionar.ResumeLayout(false);
            this.pnl_Adicionar.PerformLayout();
            this.pnl_Retirar.ResumeLayout(false);
            this.pnl_Retirar.PerformLayout();
            this.pnl_Numerar.ResumeLayout(false);
            this.pnl_Numerar.PerformLayout();
            this.pnl_Substituir.ResumeLayout(false);
            this.pnl_Substituir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ListBox lst_Arquivos;
        private System.Windows.Forms.ListBox lst_Renomear;
        private System.Windows.Forms.Button btn_Renomear;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox gpb_Opcoes;
        private System.Windows.Forms.Panel pnl_Substituir;
        private System.Windows.Forms.TextBox txt_Substituir;
        private System.Windows.Forms.TextBox txt_Localizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Substituir;
        private System.Windows.Forms.ListBox lst_Extencao;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Desfazer;
        private System.Windows.Forms.ListBox lst_Desfazer;
        private System.Windows.Forms.CheckBox chk_Numerar;
        private System.Windows.Forms.Panel pnl_Numerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Digitos;
        private System.Windows.Forms.TextBox txt_Inicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnl_Retirar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_Retirar_Trecho;
        private System.Windows.Forms.Panel pnl_Adicionar;
        private System.Windows.Forms.RadioButton rdb_Fim_Adicionar;
        private System.Windows.Forms.RadioButton rdb_Inicio_Adicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_Adicionar_Trecho;
        private System.Windows.Forms.RadioButton rdb_Fim_Retirar;
        private System.Windows.Forms.RadioButton rdb_Inicio_Retirar;
        private System.Windows.Forms.TextBox txt_Trecho;
        private System.Windows.Forms.MaskedTextBox msk_Tamanho_Trecho;
    }
}

