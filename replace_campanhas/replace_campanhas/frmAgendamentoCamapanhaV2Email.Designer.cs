namespace replace_campanhas
{
    partial class frmAgendamentoCamapanhaV2Email
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
            this.lblCorpoEmail = new System.Windows.Forms.Label();
            this.lblAssuntoEmail = new System.Windows.Forms.Label();
            this.txtTituloEmail = new System.Windows.Forms.TextBox();
            this.chkDev = new System.Windows.Forms.CheckBox();
            this.rdrAlteracao = new System.Windows.Forms.RadioButton();
            this.rdrPausa = new System.Windows.Forms.RadioButton();
            this.rdrCancelamento = new System.Windows.Forms.RadioButton();
            this.rdrAgendamento = new System.Windows.Forms.RadioButton();
            this.txtCorpoEmail = new System.Windows.Forms.TextBox();
            this.gbAgendamento = new System.Windows.Forms.GroupBox();
            this.gbBoasVindas = new System.Windows.Forms.GroupBox();
            this.rdrBomdia = new System.Windows.Forms.RadioButton();
            this.rdrBoatarde = new System.Windows.Forms.RadioButton();
            this.rdrBoanoite = new System.Windows.Forms.RadioButton();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtAmx = new System.Windows.Forms.TextBox();
            this.lblamx = new System.Windows.Forms.Label();
            this.lblAgendamento = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbAgendamento = new System.Windows.Forms.TabPage();
            this.tbEnvioEmail = new System.Windows.Forms.TabPage();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tbInsert = new System.Windows.Forms.TabPage();
            this.txtInsertFinal = new System.Windows.Forms.TextBox();
            this.btnGeraInsert = new System.Windows.Forms.Button();
            this.gbAgendamento.SuspendLayout();
            this.gbBoasVindas.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tbAgendamento.SuspendLayout();
            this.tbEnvioEmail.SuspendLayout();
            this.tbInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorpoEmail
            // 
            this.lblCorpoEmail.AutoSize = true;
            this.lblCorpoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorpoEmail.Location = new System.Drawing.Point(5, 378);
            this.lblCorpoEmail.Name = "lblCorpoEmail";
            this.lblCorpoEmail.Size = new System.Drawing.Size(106, 20);
            this.lblCorpoEmail.TabIndex = 73;
            this.lblCorpoEmail.Text = "Corpo Email";
            // 
            // lblAssuntoEmail
            // 
            this.lblAssuntoEmail.AutoSize = true;
            this.lblAssuntoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssuntoEmail.Location = new System.Drawing.Point(366, 6);
            this.lblAssuntoEmail.Name = "lblAssuntoEmail";
            this.lblAssuntoEmail.Size = new System.Drawing.Size(124, 20);
            this.lblAssuntoEmail.TabIndex = 72;
            this.lblAssuntoEmail.Text = "Assunto Email";
            // 
            // txtTituloEmail
            // 
            this.txtTituloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloEmail.Location = new System.Drawing.Point(366, 29);
            this.txtTituloEmail.Multiline = true;
            this.txtTituloEmail.Name = "txtTituloEmail";
            this.txtTituloEmail.Size = new System.Drawing.Size(161, 120);
            this.txtTituloEmail.TabIndex = 70;
            // 
            // chkDev
            // 
            this.chkDev.AutoSize = true;
            this.chkDev.Location = new System.Drawing.Point(482, 495);
            this.chkDev.Name = "chkDev";
            this.chkDev.Size = new System.Drawing.Size(44, 17);
            this.chkDev.TabIndex = 69;
            this.chkDev.Text = "dev";
            this.chkDev.UseVisualStyleBackColor = true;
            this.chkDev.Visible = false;
            this.chkDev.CheckedChanged += new System.EventHandler(this.chkDev_CheckedChanged);
            // 
            // rdrAlteracao
            // 
            this.rdrAlteracao.AutoSize = true;
            this.rdrAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrAlteracao.Location = new System.Drawing.Point(15, 109);
            this.rdrAlteracao.Name = "rdrAlteracao";
            this.rdrAlteracao.Size = new System.Drawing.Size(104, 24);
            this.rdrAlteracao.TabIndex = 37;
            this.rdrAlteracao.Text = "Alteracao";
            this.rdrAlteracao.UseVisualStyleBackColor = true;
            // 
            // rdrPausa
            // 
            this.rdrPausa.AutoSize = true;
            this.rdrPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrPausa.Location = new System.Drawing.Point(16, 79);
            this.rdrPausa.Name = "rdrPausa";
            this.rdrPausa.Size = new System.Drawing.Size(77, 24);
            this.rdrPausa.TabIndex = 36;
            this.rdrPausa.Text = "Pausa";
            this.rdrPausa.UseVisualStyleBackColor = true;
            // 
            // rdrCancelamento
            // 
            this.rdrCancelamento.AutoSize = true;
            this.rdrCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrCancelamento.Location = new System.Drawing.Point(16, 49);
            this.rdrCancelamento.Name = "rdrCancelamento";
            this.rdrCancelamento.Size = new System.Drawing.Size(146, 24);
            this.rdrCancelamento.TabIndex = 35;
            this.rdrCancelamento.Text = "Camcelamento";
            this.rdrCancelamento.UseVisualStyleBackColor = true;
            // 
            // rdrAgendamento
            // 
            this.rdrAgendamento.AutoSize = true;
            this.rdrAgendamento.Checked = true;
            this.rdrAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrAgendamento.Location = new System.Drawing.Point(16, 19);
            this.rdrAgendamento.Name = "rdrAgendamento";
            this.rdrAgendamento.Size = new System.Drawing.Size(139, 24);
            this.rdrAgendamento.TabIndex = 34;
            this.rdrAgendamento.TabStop = true;
            this.rdrAgendamento.Text = "Agendamento";
            this.rdrAgendamento.UseVisualStyleBackColor = true;
            // 
            // txtCorpoEmail
            // 
            this.txtCorpoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpoEmail.Location = new System.Drawing.Point(5, 401);
            this.txtCorpoEmail.Multiline = true;
            this.txtCorpoEmail.Name = "txtCorpoEmail";
            this.txtCorpoEmail.Size = new System.Drawing.Size(521, 62);
            this.txtCorpoEmail.TabIndex = 71;
            // 
            // gbAgendamento
            // 
            this.gbAgendamento.Controls.Add(this.rdrAlteracao);
            this.gbAgendamento.Controls.Add(this.rdrPausa);
            this.gbAgendamento.Controls.Add(this.rdrCancelamento);
            this.gbAgendamento.Controls.Add(this.rdrAgendamento);
            this.gbAgendamento.Location = new System.Drawing.Point(192, 6);
            this.gbAgendamento.Name = "gbAgendamento";
            this.gbAgendamento.Size = new System.Drawing.Size(168, 143);
            this.gbAgendamento.TabIndex = 67;
            this.gbAgendamento.TabStop = false;
            // 
            // gbBoasVindas
            // 
            this.gbBoasVindas.Controls.Add(this.rdrBomdia);
            this.gbBoasVindas.Controls.Add(this.rdrBoatarde);
            this.gbBoasVindas.Controls.Add(this.rdrBoanoite);
            this.gbBoasVindas.Location = new System.Drawing.Point(6, 6);
            this.gbBoasVindas.Name = "gbBoasVindas";
            this.gbBoasVindas.Size = new System.Drawing.Size(180, 143);
            this.gbBoasVindas.TabIndex = 66;
            this.gbBoasVindas.TabStop = false;
            // 
            // rdrBomdia
            // 
            this.rdrBomdia.AutoSize = true;
            this.rdrBomdia.Checked = true;
            this.rdrBomdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrBomdia.Location = new System.Drawing.Point(17, 19);
            this.rdrBomdia.Name = "rdrBomdia";
            this.rdrBomdia.Size = new System.Drawing.Size(92, 24);
            this.rdrBomdia.TabIndex = 31;
            this.rdrBomdia.TabStop = true;
            this.rdrBomdia.Text = "Bom dia";
            this.rdrBomdia.UseVisualStyleBackColor = true;
            // 
            // rdrBoatarde
            // 
            this.rdrBoatarde.AutoSize = true;
            this.rdrBoatarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrBoatarde.Location = new System.Drawing.Point(17, 49);
            this.rdrBoatarde.Name = "rdrBoatarde";
            this.rdrBoatarde.Size = new System.Drawing.Size(106, 24);
            this.rdrBoatarde.TabIndex = 32;
            this.rdrBoatarde.Text = "Boa tarde";
            this.rdrBoatarde.UseVisualStyleBackColor = true;
            // 
            // rdrBoanoite
            // 
            this.rdrBoanoite.AutoSize = true;
            this.rdrBoanoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrBoanoite.Location = new System.Drawing.Point(17, 79);
            this.rdrBoanoite.Name = "rdrBoanoite";
            this.rdrBoanoite.Size = new System.Drawing.Size(104, 24);
            this.rdrBoanoite.TabIndex = 33;
            this.rdrBoanoite.Text = "Boa noite";
            this.rdrBoanoite.UseVisualStyleBackColor = true;
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.Location = new System.Drawing.Point(6, 290);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(521, 84);
            this.txtSaida.TabIndex = 64;
            // 
            // txtAmx
            // 
            this.txtAmx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmx.Location = new System.Drawing.Point(6, 176);
            this.txtAmx.Multiline = true;
            this.txtAmx.Name = "txtAmx";
            this.txtAmx.Size = new System.Drawing.Size(521, 86);
            this.txtAmx.TabIndex = 63;
            // 
            // lblamx
            // 
            this.lblamx.AutoSize = true;
            this.lblamx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamx.Location = new System.Drawing.Point(6, 152);
            this.lblamx.Name = "lblamx";
            this.lblamx.Size = new System.Drawing.Size(147, 20);
            this.lblamx.TabIndex = 62;
            this.lblamx.Text = "AMX Campanhas";
            // 
            // lblAgendamento
            // 
            this.lblAgendamento.AutoSize = true;
            this.lblAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamento.Location = new System.Drawing.Point(6, 267);
            this.lblAgendamento.Name = "lblAgendamento";
            this.lblAgendamento.Size = new System.Drawing.Size(144, 20);
            this.lblAgendamento.TabIndex = 65;
            this.lblAgendamento.Text = "Mensagem saida";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(109, 469);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 61;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(213, 469);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 60;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(5, 469);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 59;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click_1);
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbAgendamento);
            this.tbControl.Controls.Add(this.tbEnvioEmail);
            this.tbControl.Controls.Add(this.tbInsert);
            this.tbControl.Location = new System.Drawing.Point(12, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(556, 551);
            this.tbControl.TabIndex = 74;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tbAgendamento
            // 
            this.tbAgendamento.Controls.Add(this.gbBoasVindas);
            this.tbAgendamento.Controls.Add(this.lblCorpoEmail);
            this.tbAgendamento.Controls.Add(this.btnGerar);
            this.tbAgendamento.Controls.Add(this.lblAssuntoEmail);
            this.tbAgendamento.Controls.Add(this.btnSair);
            this.tbAgendamento.Controls.Add(this.txtTituloEmail);
            this.tbAgendamento.Controls.Add(this.btnLimpar);
            this.tbAgendamento.Controls.Add(this.chkDev);
            this.tbAgendamento.Controls.Add(this.lblAgendamento);
            this.tbAgendamento.Controls.Add(this.lblamx);
            this.tbAgendamento.Controls.Add(this.txtCorpoEmail);
            this.tbAgendamento.Controls.Add(this.txtAmx);
            this.tbAgendamento.Controls.Add(this.gbAgendamento);
            this.tbAgendamento.Controls.Add(this.txtSaida);
            this.tbAgendamento.Location = new System.Drawing.Point(4, 22);
            this.tbAgendamento.Name = "tbAgendamento";
            this.tbAgendamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgendamento.Size = new System.Drawing.Size(548, 525);
            this.tbAgendamento.TabIndex = 0;
            this.tbAgendamento.Text = "Agendamento";
            this.tbAgendamento.UseVisualStyleBackColor = true;
            // 
            // tbEnvioEmail
            // 
            this.tbEnvioEmail.Controls.Add(this.lblSenha);
            this.tbEnvioEmail.Controls.Add(this.txtSenha);
            this.tbEnvioEmail.Controls.Add(this.lblDestinatario);
            this.tbEnvioEmail.Controls.Add(this.txtDestinatario);
            this.tbEnvioEmail.Controls.Add(this.btnEnviarEmail);
            this.tbEnvioEmail.Controls.Add(this.lblEmail);
            this.tbEnvioEmail.Controls.Add(this.txtEmail);
            this.tbEnvioEmail.Location = new System.Drawing.Point(4, 22);
            this.tbEnvioEmail.Name = "tbEnvioEmail";
            this.tbEnvioEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tbEnvioEmail.Size = new System.Drawing.Size(548, 525);
            this.tbEnvioEmail.TabIndex = 1;
            this.tbEnvioEmail.Text = "Envio de email";
            this.tbEnvioEmail.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(47, 40);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 20);
            this.lblSenha.TabIndex = 78;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(119, 40);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(423, 22);
            this.txtSenha.TabIndex = 77;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.Location = new System.Drawing.Point(6, 68);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(107, 20);
            this.lblDestinatario.TabIndex = 76;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatario.Location = new System.Drawing.Point(119, 68);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(423, 22);
            this.txtDestinatario.TabIndex = 75;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Location = new System.Drawing.Point(10, 476);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(98, 43);
            this.btnEnviarEmail.TabIndex = 74;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(55, 12);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 73;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(119, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(423, 22);
            this.txtEmail.TabIndex = 71;
            // 
            // tbInsert
            // 
            this.tbInsert.Controls.Add(this.btnGeraInsert);
            this.tbInsert.Controls.Add(this.txtInsertFinal);
            this.tbInsert.Location = new System.Drawing.Point(4, 22);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsert.Size = new System.Drawing.Size(548, 525);
            this.tbInsert.TabIndex = 2;
            this.tbInsert.Text = "Insert";
            this.tbInsert.UseVisualStyleBackColor = true;
            // 
            // txtInsertFinal
            // 
            this.txtInsertFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertFinal.Location = new System.Drawing.Point(6, 277);
            this.txtInsertFinal.Multiline = true;
            this.txtInsertFinal.Name = "txtInsertFinal";
            this.txtInsertFinal.Size = new System.Drawing.Size(536, 193);
            this.txtInsertFinal.TabIndex = 74;
            // 
            // btnGeraInsert
            // 
            this.btnGeraInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraInsert.Location = new System.Drawing.Point(6, 476);
            this.btnGeraInsert.Name = "btnGeraInsert";
            this.btnGeraInsert.Size = new System.Drawing.Size(98, 43);
            this.btnGeraInsert.TabIndex = 75;
            this.btnGeraInsert.Text = "Gerar";
            this.btnGeraInsert.UseVisualStyleBackColor = true;
            this.btnGeraInsert.Click += new System.EventHandler(this.btnGeraInsert_Click);
            // 
            // frmAgendamentoCamapanhaV2Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 574);
            this.Controls.Add(this.tbControl);
            this.Name = "frmAgendamentoCamapanhaV2Email";
            this.Text = "frmAgendamentoCamapanhaV2Email";
            this.Load += new System.EventHandler(this.frmAgendamentoCamapanhaV2Email_Load);
            this.gbAgendamento.ResumeLayout(false);
            this.gbAgendamento.PerformLayout();
            this.gbBoasVindas.ResumeLayout(false);
            this.gbBoasVindas.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tbAgendamento.ResumeLayout(false);
            this.tbAgendamento.PerformLayout();
            this.tbEnvioEmail.ResumeLayout(false);
            this.tbEnvioEmail.PerformLayout();
            this.tbInsert.ResumeLayout(false);
            this.tbInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCorpoEmail;
        private System.Windows.Forms.Label lblAssuntoEmail;
        private System.Windows.Forms.TextBox txtTituloEmail;
        private System.Windows.Forms.CheckBox chkDev;
        private System.Windows.Forms.RadioButton rdrAlteracao;
        private System.Windows.Forms.RadioButton rdrPausa;
        private System.Windows.Forms.RadioButton rdrCancelamento;
        private System.Windows.Forms.RadioButton rdrAgendamento;
        private System.Windows.Forms.TextBox txtCorpoEmail;
        private System.Windows.Forms.GroupBox gbAgendamento;
        private System.Windows.Forms.GroupBox gbBoasVindas;
        private System.Windows.Forms.RadioButton rdrBomdia;
        private System.Windows.Forms.RadioButton rdrBoatarde;
        private System.Windows.Forms.RadioButton rdrBoanoite;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtAmx;
        private System.Windows.Forms.Label lblamx;
        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbAgendamento;
        private System.Windows.Forms.TabPage tbEnvioEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TabPage tbInsert;
        private System.Windows.Forms.TextBox txtInsertFinal;
        private System.Windows.Forms.Button btnGeraInsert;
    }
}