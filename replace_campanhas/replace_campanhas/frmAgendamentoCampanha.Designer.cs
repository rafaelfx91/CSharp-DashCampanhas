namespace replace_campanhas
{
    partial class frmAgendamentoCampanha
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.chkCancelamento = new System.Windows.Forms.CheckBox();
            this.chkHold = new System.Windows.Forms.CheckBox();
            this.chkInclusao = new System.Windows.Forms.CheckBox();
            this.lclChamado = new System.Windows.Forms.Label();
            this.txtChamado = new System.Windows.Forms.TextBox();
            this.lblAssuntoemail = new System.Windows.Forms.Label();
            this.lblTituloemail = new System.Windows.Forms.Label();
            this.txtAssuntoEmail = new System.Windows.Forms.TextBox();
            this.lblNumerochamado = new System.Windows.Forms.Label();
            this.txtTituloEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroChamado = new System.Windows.Forms.TextBox();
            this.txtAmx = new System.Windows.Forms.TextBox();
            this.lblamx = new System.Windows.Forms.Label();
            this.rdrBoanoite = new System.Windows.Forms.RadioButton();
            this.rdrBoatarde = new System.Windows.Forms.RadioButton();
            this.rdrBomdia = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 300);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 300);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 300);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 25;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // chkCancelamento
            // 
            this.chkCancelamento.AutoSize = true;
            this.chkCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelamento.Location = new System.Drawing.Point(662, 81);
            this.chkCancelamento.Name = "chkCancelamento";
            this.chkCancelamento.Size = new System.Drawing.Size(173, 24);
            this.chkCancelamento.TabIndex = 43;
            this.chkCancelamento.Text = "OS Cancelamento";
            this.chkCancelamento.UseVisualStyleBackColor = true;
            // 
            // chkHold
            // 
            this.chkHold.AutoSize = true;
            this.chkHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHold.Location = new System.Drawing.Point(537, 81);
            this.chkHold.Name = "chkHold";
            this.chkHold.Size = new System.Drawing.Size(119, 24);
            this.chkHold.TabIndex = 42;
            this.chkHold.Text = "OS Holding";
            this.chkHold.UseVisualStyleBackColor = true;
            // 
            // chkInclusao
            // 
            this.chkInclusao.AutoSize = true;
            this.chkInclusao.Checked = true;
            this.chkInclusao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInclusao.Location = new System.Drawing.Point(405, 81);
            this.chkInclusao.Name = "chkInclusao";
            this.chkInclusao.Size = new System.Drawing.Size(126, 24);
            this.chkInclusao.TabIndex = 41;
            this.chkInclusao.Text = "OS Inclusao";
            this.chkInclusao.UseVisualStyleBackColor = true;
            // 
            // lclChamado
            // 
            this.lclChamado.AutoSize = true;
            this.lclChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclChamado.Location = new System.Drawing.Point(74, 263);
            this.lclChamado.Name = "lclChamado";
            this.lclChamado.Size = new System.Drawing.Size(85, 20);
            this.lclChamado.TabIndex = 40;
            this.lclChamado.Text = "Chamado";
            // 
            // txtChamado
            // 
            this.txtChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamado.Location = new System.Drawing.Point(165, 257);
            this.txtChamado.Name = "txtChamado";
            this.txtChamado.Size = new System.Drawing.Size(670, 26);
            this.txtChamado.TabIndex = 39;
            // 
            // lblAssuntoemail
            // 
            this.lblAssuntoemail.AutoSize = true;
            this.lblAssuntoemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssuntoemail.Location = new System.Drawing.Point(37, 145);
            this.lblAssuntoemail.Name = "lblAssuntoemail";
            this.lblAssuntoemail.Size = new System.Drawing.Size(122, 20);
            this.lblAssuntoemail.TabIndex = 38;
            this.lblAssuntoemail.Text = "Assunto email";
            // 
            // lblTituloemail
            // 
            this.lblTituloemail.AutoSize = true;
            this.lblTituloemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloemail.Location = new System.Drawing.Point(57, 116);
            this.lblTituloemail.Name = "lblTituloemail";
            this.lblTituloemail.Size = new System.Drawing.Size(102, 20);
            this.lblTituloemail.TabIndex = 37;
            this.lblTituloemail.Text = "Titulo Email";
            // 
            // txtAssuntoEmail
            // 
            this.txtAssuntoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssuntoEmail.Location = new System.Drawing.Point(165, 145);
            this.txtAssuntoEmail.Multiline = true;
            this.txtAssuntoEmail.Name = "txtAssuntoEmail";
            this.txtAssuntoEmail.Size = new System.Drawing.Size(670, 106);
            this.txtAssuntoEmail.TabIndex = 36;
            // 
            // lblNumerochamado
            // 
            this.lblNumerochamado.AutoSize = true;
            this.lblNumerochamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerochamado.Location = new System.Drawing.Point(12, 81);
            this.lblNumerochamado.Name = "lblNumerochamado";
            this.lblNumerochamado.Size = new System.Drawing.Size(149, 20);
            this.lblNumerochamado.TabIndex = 35;
            this.lblNumerochamado.Text = "Numero chamado";
            // 
            // txtTituloEmail
            // 
            this.txtTituloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloEmail.Location = new System.Drawing.Point(165, 113);
            this.txtTituloEmail.Name = "txtTituloEmail";
            this.txtTituloEmail.Size = new System.Drawing.Size(670, 26);
            this.txtTituloEmail.TabIndex = 34;
            // 
            // txtNumeroChamado
            // 
            this.txtNumeroChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroChamado.Location = new System.Drawing.Point(165, 78);
            this.txtNumeroChamado.Name = "txtNumeroChamado";
            this.txtNumeroChamado.Size = new System.Drawing.Size(234, 26);
            this.txtNumeroChamado.TabIndex = 33;
            // 
            // txtAmx
            // 
            this.txtAmx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmx.Location = new System.Drawing.Point(165, 42);
            this.txtAmx.Name = "txtAmx";
            this.txtAmx.Size = new System.Drawing.Size(670, 26);
            this.txtAmx.TabIndex = 32;
            // 
            // lblamx
            // 
            this.lblamx.AutoSize = true;
            this.lblamx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamx.Location = new System.Drawing.Point(12, 45);
            this.lblamx.Name = "lblamx";
            this.lblamx.Size = new System.Drawing.Size(147, 20);
            this.lblamx.TabIndex = 31;
            this.lblamx.Text = "AMX Campanhas";
            // 
            // rdrBoanoite
            // 
            this.rdrBoanoite.AutoSize = true;
            this.rdrBoanoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrBoanoite.Location = new System.Drawing.Point(222, 12);
            this.rdrBoanoite.Name = "rdrBoanoite";
            this.rdrBoanoite.Size = new System.Drawing.Size(104, 24);
            this.rdrBoanoite.TabIndex = 30;
            this.rdrBoanoite.Text = "Boa noite";
            this.rdrBoanoite.UseVisualStyleBackColor = true;
            // 
            // rdrBoatarde
            // 
            this.rdrBoatarde.AutoSize = true;
            this.rdrBoatarde.Checked = true;
            this.rdrBoatarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrBoatarde.Location = new System.Drawing.Point(110, 12);
            this.rdrBoatarde.Name = "rdrBoatarde";
            this.rdrBoatarde.Size = new System.Drawing.Size(106, 24);
            this.rdrBoatarde.TabIndex = 29;
            this.rdrBoatarde.TabStop = true;
            this.rdrBoatarde.Text = "Boa tarde";
            this.rdrBoatarde.UseVisualStyleBackColor = true;
            // 
            // rdrBomdia
            // 
            this.rdrBomdia.AutoSize = true;
            this.rdrBomdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrBomdia.Location = new System.Drawing.Point(12, 12);
            this.rdrBomdia.Name = "rdrBomdia";
            this.rdrBomdia.Size = new System.Drawing.Size(92, 24);
            this.rdrBomdia.TabIndex = 28;
            this.rdrBomdia.Text = "Bom dia";
            this.rdrBomdia.UseVisualStyleBackColor = true;
            // 
            // frmAgendamentoCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 354);
            this.Controls.Add(this.chkCancelamento);
            this.Controls.Add(this.chkHold);
            this.Controls.Add(this.chkInclusao);
            this.Controls.Add(this.lclChamado);
            this.Controls.Add(this.txtChamado);
            this.Controls.Add(this.lblAssuntoemail);
            this.Controls.Add(this.lblTituloemail);
            this.Controls.Add(this.txtAssuntoEmail);
            this.Controls.Add(this.lblNumerochamado);
            this.Controls.Add(this.txtTituloEmail);
            this.Controls.Add(this.txtNumeroChamado);
            this.Controls.Add(this.txtAmx);
            this.Controls.Add(this.lblamx);
            this.Controls.Add(this.rdrBoanoite);
            this.Controls.Add(this.rdrBoatarde);
            this.Controls.Add(this.rdrBomdia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAgendamentoCampanha";
            this.Text = "Agendamento de campanhas";
            this.Load += new System.EventHandler(this.frmAgendamentoCampanha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.CheckBox chkCancelamento;
        private System.Windows.Forms.CheckBox chkHold;
        private System.Windows.Forms.CheckBox chkInclusao;
        private System.Windows.Forms.Label lclChamado;
        private System.Windows.Forms.TextBox txtChamado;
        private System.Windows.Forms.Label lblAssuntoemail;
        private System.Windows.Forms.Label lblTituloemail;
        private System.Windows.Forms.TextBox txtAssuntoEmail;
        private System.Windows.Forms.Label lblNumerochamado;
        private System.Windows.Forms.TextBox txtTituloEmail;
        private System.Windows.Forms.TextBox txtNumeroChamado;
        private System.Windows.Forms.TextBox txtAmx;
        private System.Windows.Forms.Label lblamx;
        private System.Windows.Forms.RadioButton rdrBoanoite;
        private System.Windows.Forms.RadioButton rdrBoatarde;
        private System.Windows.Forms.RadioButton rdrBomdia;
    }
}