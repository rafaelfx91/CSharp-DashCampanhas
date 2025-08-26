namespace replace_campanhas
{
    partial class frmChamadosRedmine
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.tabCampos = new System.Windows.Forms.TabControl();
            this.tbVisao = new System.Windows.Forms.TabPage();
            this.rdPMEDomicilio = new System.Windows.Forms.RadioButton();
            this.rdPMEPessoaTelefone = new System.Windows.Forms.RadioButton();
            this.rdPMEPessoa = new System.Windows.Forms.RadioButton();
            this.rdPessoa = new System.Windows.Forms.RadioButton();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdDomicilio = new System.Windows.Forms.RadioButton();
            this.rdContrato = new System.Windows.Forms.RadioButton();
            this.rdTelefone = new System.Windows.Forms.RadioButton();
            this.tabTipo = new System.Windows.Forms.TabPage();
            this.lblPara = new System.Windows.Forms.Label();
            this.cbT2 = new System.Windows.Forms.ComboBox();
            this.cbT1 = new System.Windows.Forms.ComboBox();
            this.chkT2 = new System.Windows.Forms.CheckBox();
            this.chkT1 = new System.Windows.Forms.CheckBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblT1Dot = new System.Windows.Forms.Label();
            this.lblCampoT1 = new System.Windows.Forms.Label();
            this.txtCampoT1 = new System.Windows.Forms.TextBox();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblTabelaT1 = new System.Windows.Forms.Label();
            this.txtTabelaT1 = new System.Windows.Forms.TextBox();
            this.lblT2Dot = new System.Windows.Forms.Label();
            this.lblCampoT2 = new System.Windows.Forms.Label();
            this.txtCampoT2 = new System.Windows.Forms.TextBox();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblTabelaT2 = new System.Windows.Forms.Label();
            this.txtTabelaT2 = new System.Windows.Forms.TextBox();
            this.rdNovaColuna = new System.Windows.Forms.RadioButton();
            this.rdNovaTabela = new System.Windows.Forms.RadioButton();
            this.tbColunas = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.tabCampos.SuspendLayout();
            this.tbVisao.SuspendLayout();
            this.tabTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(422, 458);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(526, 458);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 35;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(12, 462);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(98, 43);
            this.btnCarregar.TabIndex = 34;
            this.btnCarregar.Text = "Gerar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // tabCampos
            // 
            this.tabCampos.Controls.Add(this.tbVisao);
            this.tabCampos.Controls.Add(this.tabTipo);
            this.tabCampos.Controls.Add(this.tbColunas);
            this.tabCampos.Controls.Add(this.tabPage3);
            this.tabCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabCampos.Location = new System.Drawing.Point(12, 12);
            this.tabCampos.Name = "tabCampos";
            this.tabCampos.SelectedIndex = 0;
            this.tabCampos.Size = new System.Drawing.Size(620, 444);
            this.tabCampos.TabIndex = 37;
            // 
            // tbVisao
            // 
            this.tbVisao.Controls.Add(this.lblMotivo);
            this.tbVisao.Controls.Add(this.txtMotivo);
            this.tbVisao.Controls.Add(this.rdPMEDomicilio);
            this.tbVisao.Controls.Add(this.rdPMEPessoaTelefone);
            this.tbVisao.Controls.Add(this.rdPMEPessoa);
            this.tbVisao.Controls.Add(this.rdPessoa);
            this.tbVisao.Controls.Add(this.rdEmail);
            this.tbVisao.Controls.Add(this.rdDomicilio);
            this.tbVisao.Controls.Add(this.rdContrato);
            this.tbVisao.Controls.Add(this.rdTelefone);
            this.tbVisao.Location = new System.Drawing.Point(4, 34);
            this.tbVisao.Name = "tbVisao";
            this.tbVisao.Padding = new System.Windows.Forms.Padding(3);
            this.tbVisao.Size = new System.Drawing.Size(612, 406);
            this.tbVisao.TabIndex = 0;
            this.tbVisao.Text = "Visao";
            this.tbVisao.UseVisualStyleBackColor = true;
            // 
            // rdPMEDomicilio
            // 
            this.rdPMEDomicilio.AutoSize = true;
            this.rdPMEDomicilio.Location = new System.Drawing.Point(155, 111);
            this.rdPMEDomicilio.Name = "rdPMEDomicilio";
            this.rdPMEDomicilio.Size = new System.Drawing.Size(188, 29);
            this.rdPMEDomicilio.TabIndex = 7;
            this.rdPMEDomicilio.TabStop = true;
            this.rdPMEDomicilio.Text = "PME_Domicilio";
            this.rdPMEDomicilio.UseVisualStyleBackColor = true;
            // 
            // rdPMEPessoaTelefone
            // 
            this.rdPMEPessoaTelefone.AutoSize = true;
            this.rdPMEPessoaTelefone.Location = new System.Drawing.Point(155, 76);
            this.rdPMEPessoaTelefone.Name = "rdPMEPessoaTelefone";
            this.rdPMEPessoaTelefone.Size = new System.Drawing.Size(275, 29);
            this.rdPMEPessoaTelefone.TabIndex = 6;
            this.rdPMEPessoaTelefone.TabStop = true;
            this.rdPMEPessoaTelefone.Text = "PME_Pessoa_Telefone";
            this.rdPMEPessoaTelefone.UseVisualStyleBackColor = true;
            // 
            // rdPMEPessoa
            // 
            this.rdPMEPessoa.AutoSize = true;
            this.rdPMEPessoa.Location = new System.Drawing.Point(155, 41);
            this.rdPMEPessoa.Name = "rdPMEPessoa";
            this.rdPMEPessoa.Size = new System.Drawing.Size(170, 29);
            this.rdPMEPessoa.TabIndex = 5;
            this.rdPMEPessoa.TabStop = true;
            this.rdPMEPessoa.Text = "PME_Pessoa";
            this.rdPMEPessoa.UseVisualStyleBackColor = true;
            // 
            // rdPessoa
            // 
            this.rdPessoa.AutoSize = true;
            this.rdPessoa.Location = new System.Drawing.Point(155, 6);
            this.rdPessoa.Name = "rdPessoa";
            this.rdPessoa.Size = new System.Drawing.Size(108, 29);
            this.rdPessoa.TabIndex = 4;
            this.rdPessoa.TabStop = true;
            this.rdPessoa.Text = "Pessoa";
            this.rdPessoa.UseVisualStyleBackColor = true;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.Location = new System.Drawing.Point(6, 111);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(96, 29);
            this.rdEmail.TabIndex = 3;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "E-mail";
            this.rdEmail.UseVisualStyleBackColor = true;
            // 
            // rdDomicilio
            // 
            this.rdDomicilio.AutoSize = true;
            this.rdDomicilio.Location = new System.Drawing.Point(6, 76);
            this.rdDomicilio.Name = "rdDomicilio";
            this.rdDomicilio.Size = new System.Drawing.Size(126, 29);
            this.rdDomicilio.TabIndex = 2;
            this.rdDomicilio.TabStop = true;
            this.rdDomicilio.Text = "Domicilio";
            this.rdDomicilio.UseVisualStyleBackColor = true;
            // 
            // rdContrato
            // 
            this.rdContrato.AutoSize = true;
            this.rdContrato.Location = new System.Drawing.Point(6, 41);
            this.rdContrato.Name = "rdContrato";
            this.rdContrato.Size = new System.Drawing.Size(120, 29);
            this.rdContrato.TabIndex = 1;
            this.rdContrato.TabStop = true;
            this.rdContrato.Text = "Contrato";
            this.rdContrato.UseVisualStyleBackColor = true;
            // 
            // rdTelefone
            // 
            this.rdTelefone.AutoSize = true;
            this.rdTelefone.Location = new System.Drawing.Point(6, 6);
            this.rdTelefone.Name = "rdTelefone";
            this.rdTelefone.Size = new System.Drawing.Size(122, 29);
            this.rdTelefone.TabIndex = 0;
            this.rdTelefone.TabStop = true;
            this.rdTelefone.Text = "Telefone";
            this.rdTelefone.UseVisualStyleBackColor = true;
            // 
            // tabTipo
            // 
            this.tabTipo.Controls.Add(this.lblPara);
            this.tabTipo.Controls.Add(this.cbT2);
            this.tabTipo.Controls.Add(this.cbT1);
            this.tabTipo.Controls.Add(this.chkT2);
            this.tabTipo.Controls.Add(this.chkT1);
            this.tabTipo.Controls.Add(this.lblObs);
            this.tabTipo.Controls.Add(this.lblT1Dot);
            this.tabTipo.Controls.Add(this.lblCampoT1);
            this.tabTipo.Controls.Add(this.txtCampoT1);
            this.tabTipo.Controls.Add(this.lblT1);
            this.tabTipo.Controls.Add(this.lblTabelaT1);
            this.tabTipo.Controls.Add(this.txtTabelaT1);
            this.tabTipo.Controls.Add(this.lblT2Dot);
            this.tabTipo.Controls.Add(this.lblCampoT2);
            this.tabTipo.Controls.Add(this.txtCampoT2);
            this.tabTipo.Controls.Add(this.lblT2);
            this.tabTipo.Controls.Add(this.lblTabelaT2);
            this.tabTipo.Controls.Add(this.txtTabelaT2);
            this.tabTipo.Controls.Add(this.rdNovaColuna);
            this.tabTipo.Controls.Add(this.rdNovaTabela);
            this.tabTipo.Location = new System.Drawing.Point(4, 34);
            this.tabTipo.Name = "tabTipo";
            this.tabTipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipo.Size = new System.Drawing.Size(612, 406);
            this.tabTipo.TabIndex = 1;
            this.tabTipo.Text = "Tipo";
            this.tabTipo.UseVisualStyleBackColor = true;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(90, 325);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(61, 25);
            this.lblPara.TabIndex = 27;
            this.lblPara.Text = "Para";
            // 
            // cbT2
            // 
            this.cbT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT2.FormattingEnabled = true;
            this.cbT2.Items.AddRange(new object[] {
            "1",
            "N"});
            this.cbT2.Location = new System.Drawing.Point(157, 322);
            this.cbT2.Name = "cbT2";
            this.cbT2.Size = new System.Drawing.Size(73, 33);
            this.cbT2.TabIndex = 26;
            // 
            // cbT1
            // 
            this.cbT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT1.FormattingEnabled = true;
            this.cbT1.Items.AddRange(new object[] {
            "1",
            "N"});
            this.cbT1.Location = new System.Drawing.Point(11, 322);
            this.cbT1.Name = "cbT1";
            this.cbT1.Size = new System.Drawing.Size(73, 33);
            this.cbT1.TabIndex = 25;
            // 
            // chkT2
            // 
            this.chkT2.AutoSize = true;
            this.chkT2.Location = new System.Drawing.Point(11, 287);
            this.chkT2.Name = "chkT2";
            this.chkT2.Size = new System.Drawing.Size(239, 29);
            this.chkT2.TabIndex = 24;
            this.chkT2.Text = "T2 Sem duplicidade";
            this.chkT2.UseVisualStyleBackColor = true;
            this.chkT2.CheckedChanged += new System.EventHandler(this.trocaStatusT2);
            // 
            // chkT1
            // 
            this.chkT1.AutoSize = true;
            this.chkT1.Location = new System.Drawing.Point(11, 252);
            this.chkT1.Name = "chkT1";
            this.chkT1.Size = new System.Drawing.Size(239, 29);
            this.chkT1.TabIndex = 23;
            this.chkT1.Text = "T1 Sem duplicidade";
            this.chkT1.UseVisualStyleBackColor = true;
            this.chkT1.CheckedChanged += new System.EventHandler(this.trocaStatusT1);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(6, 224);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(145, 25);
            this.lblObs.TabIndex = 22;
            this.lblObs.Text = "Observacao:";
            // 
            // lblT1Dot
            // 
            this.lblT1Dot.AutoSize = true;
            this.lblT1Dot.Location = new System.Drawing.Point(98, 81);
            this.lblT1Dot.Name = "lblT1Dot";
            this.lblT1Dot.Size = new System.Drawing.Size(46, 25);
            this.lblT1Dot.TabIndex = 21;
            this.lblT1Dot.Text = "T1.";
            // 
            // lblCampoT1
            // 
            this.lblCampoT1.AutoSize = true;
            this.lblCampoT1.Location = new System.Drawing.Point(6, 81);
            this.lblCampoT1.Name = "lblCampoT1";
            this.lblCampoT1.Size = new System.Drawing.Size(99, 25);
            this.lblCampoT1.TabIndex = 20;
            this.lblCampoT1.Text = "Campo: ";
            // 
            // txtCampoT1
            // 
            this.txtCampoT1.Location = new System.Drawing.Point(148, 78);
            this.txtCampoT1.Name = "txtCampoT1";
            this.txtCampoT1.Size = new System.Drawing.Size(416, 31);
            this.txtCampoT1.TabIndex = 19;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(570, 41);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(39, 25);
            this.lblT1.TabIndex = 18;
            this.lblT1.Text = "T1";
            // 
            // lblTabelaT1
            // 
            this.lblTabelaT1.AutoSize = true;
            this.lblTabelaT1.Location = new System.Drawing.Point(6, 38);
            this.lblTabelaT1.Name = "lblTabelaT1";
            this.lblTabelaT1.Size = new System.Drawing.Size(91, 25);
            this.lblTabelaT1.TabIndex = 17;
            this.lblTabelaT1.Text = "Tabela:";
            // 
            // txtTabelaT1
            // 
            this.txtTabelaT1.Location = new System.Drawing.Point(103, 38);
            this.txtTabelaT1.Name = "txtTabelaT1";
            this.txtTabelaT1.Size = new System.Drawing.Size(461, 31);
            this.txtTabelaT1.TabIndex = 16;
            // 
            // lblT2Dot
            // 
            this.lblT2Dot.AutoSize = true;
            this.lblT2Dot.Location = new System.Drawing.Point(98, 171);
            this.lblT2Dot.Name = "lblT2Dot";
            this.lblT2Dot.Size = new System.Drawing.Size(46, 25);
            this.lblT2Dot.TabIndex = 15;
            this.lblT2Dot.Text = "T2.";
            // 
            // lblCampoT2
            // 
            this.lblCampoT2.AutoSize = true;
            this.lblCampoT2.Location = new System.Drawing.Point(6, 171);
            this.lblCampoT2.Name = "lblCampoT2";
            this.lblCampoT2.Size = new System.Drawing.Size(99, 25);
            this.lblCampoT2.TabIndex = 14;
            this.lblCampoT2.Text = "Campo: ";
            // 
            // txtCampoT2
            // 
            this.txtCampoT2.Location = new System.Drawing.Point(148, 168);
            this.txtCampoT2.Name = "txtCampoT2";
            this.txtCampoT2.Size = new System.Drawing.Size(416, 31);
            this.txtCampoT2.TabIndex = 13;
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(570, 131);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(39, 25);
            this.lblT2.TabIndex = 12;
            this.lblT2.Text = "T2";
            // 
            // lblTabelaT2
            // 
            this.lblTabelaT2.AutoSize = true;
            this.lblTabelaT2.Location = new System.Drawing.Point(6, 128);
            this.lblTabelaT2.Name = "lblTabelaT2";
            this.lblTabelaT2.Size = new System.Drawing.Size(91, 25);
            this.lblTabelaT2.TabIndex = 11;
            this.lblTabelaT2.Text = "Tabela:";
            // 
            // txtTabelaT2
            // 
            this.txtTabelaT2.Location = new System.Drawing.Point(103, 128);
            this.txtTabelaT2.Name = "txtTabelaT2";
            this.txtTabelaT2.Size = new System.Drawing.Size(461, 31);
            this.txtTabelaT2.TabIndex = 10;
            // 
            // rdNovaColuna
            // 
            this.rdNovaColuna.AutoSize = true;
            this.rdNovaColuna.Location = new System.Drawing.Point(165, 6);
            this.rdNovaColuna.Name = "rdNovaColuna";
            this.rdNovaColuna.Size = new System.Drawing.Size(161, 29);
            this.rdNovaColuna.TabIndex = 9;
            this.rdNovaColuna.Text = "Nova coluna";
            this.rdNovaColuna.UseVisualStyleBackColor = true;
            this.rdNovaColuna.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PopulaCampos);
            // 
            // rdNovaTabela
            // 
            this.rdNovaTabela.AutoSize = true;
            this.rdNovaTabela.Checked = true;
            this.rdNovaTabela.Location = new System.Drawing.Point(3, 6);
            this.rdNovaTabela.Name = "rdNovaTabela";
            this.rdNovaTabela.Size = new System.Drawing.Size(156, 29);
            this.rdNovaTabela.TabIndex = 8;
            this.rdNovaTabela.TabStop = true;
            this.rdNovaTabela.Text = "Nova tabela";
            this.rdNovaTabela.UseVisualStyleBackColor = true;
            this.rdNovaTabela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PopulaCampos);
            // 
            // tbColunas
            // 
            this.tbColunas.Location = new System.Drawing.Point(4, 34);
            this.tbColunas.Name = "tbColunas";
            this.tbColunas.Padding = new System.Windows.Forms.Padding(3);
            this.tbColunas.Size = new System.Drawing.Size(612, 406);
            this.tbColunas.TabIndex = 2;
            this.tbColunas.Text = "Colunas";
            this.tbColunas.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 406);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(6, 179);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(262, 25);
            this.lblMotivo.TabIndex = 19;
            this.lblMotivo.Text = "Motivo da nescecidade:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(3, 207);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(600, 193);
            this.txtMotivo.TabIndex = 18;
            // 
            // frmChamadosRedmine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 513);
            this.Controls.Add(this.tabCampos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCarregar);
            this.Name = "frmChamadosRedmine";
            this.Text = "frmChamadosRedmine";
            this.Load += new System.EventHandler(this.frmChamadosRedmine_Load);
            this.tabCampos.ResumeLayout(false);
            this.tbVisao.ResumeLayout(false);
            this.tbVisao.PerformLayout();
            this.tabTipo.ResumeLayout(false);
            this.tabTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TabControl tabCampos;
        private System.Windows.Forms.TabPage tbVisao;
        private System.Windows.Forms.TabPage tabTipo;
        private System.Windows.Forms.RadioButton rdTelefone;
        private System.Windows.Forms.RadioButton rdContrato;
        private System.Windows.Forms.RadioButton rdPMEDomicilio;
        private System.Windows.Forms.RadioButton rdPMEPessoaTelefone;
        private System.Windows.Forms.RadioButton rdPMEPessoa;
        private System.Windows.Forms.RadioButton rdPessoa;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdDomicilio;
        private System.Windows.Forms.TabPage tbColunas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rdNovaColuna;
        private System.Windows.Forms.RadioButton rdNovaTabela;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblTabelaT2;
        private System.Windows.Forms.TextBox txtTabelaT2;
        private System.Windows.Forms.Label lblT2Dot;
        private System.Windows.Forms.Label lblCampoT2;
        private System.Windows.Forms.TextBox txtCampoT2;
        private System.Windows.Forms.Label lblT1Dot;
        private System.Windows.Forms.Label lblCampoT1;
        private System.Windows.Forms.TextBox txtCampoT1;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblTabelaT1;
        private System.Windows.Forms.TextBox txtTabelaT1;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.CheckBox chkT2;
        private System.Windows.Forms.CheckBox chkT1;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.ComboBox cbT2;
        private System.Windows.Forms.ComboBox cbT1;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}