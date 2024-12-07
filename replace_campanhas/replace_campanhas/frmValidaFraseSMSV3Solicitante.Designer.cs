namespace replace_campanhas
{
    partial class frmValidaFraseSMSV3Solicitante
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
            this.rtxtFraseEntrada = new System.Windows.Forms.RichTextBox();
            this.lblCaracteresCampanha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtSms = new System.Windows.Forms.RichTextBox();
            this.pbSmS = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pbInterfaceSms = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInterfaceSms)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtFraseEntrada
            // 
            this.rtxtFraseEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtFraseEntrada.Location = new System.Drawing.Point(52, 323);
            this.rtxtFraseEntrada.Name = "rtxtFraseEntrada";
            this.rtxtFraseEntrada.Size = new System.Drawing.Size(556, 98);
            this.rtxtFraseEntrada.TabIndex = 45;
            this.rtxtFraseEntrada.Text = "";
            this.rtxtFraseEntrada.TextChanged += new System.EventHandler(this.rtxtFraseEntrada_TextChanged);
            // 
            // lblCaracteresCampanha
            // 
            this.lblCaracteresCampanha.AutoSize = true;
            this.lblCaracteresCampanha.BackColor = System.Drawing.Color.LightGray;
            this.lblCaracteresCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteresCampanha.Location = new System.Drawing.Point(48, 426);
            this.lblCaracteresCampanha.Name = "lblCaracteresCampanha";
            this.lblCaracteresCampanha.Size = new System.Drawing.Size(276, 25);
            this.lblCaracteresCampanha.TabIndex = 43;
            this.lblCaracteresCampanha.Text = "Caracters do sms: 0 /160";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(634, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(634, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(634, 313);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 40;
            this.btnGerar.Text = "Validar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Caracteres especiais permitidos: ! # $ %* + , - . / : = ? @{ } -";
            // 
            // rtxtSms
            // 
            this.rtxtSms.BackColor = System.Drawing.Color.White;
            this.rtxtSms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSms.Location = new System.Drawing.Point(62, 85);
            this.rtxtSms.Name = "rtxtSms";
            this.rtxtSms.Size = new System.Drawing.Size(537, 160);
            this.rtxtSms.TabIndex = 49;
            this.rtxtSms.Text = "";
            // 
            // pbSmS
            // 
            this.pbSmS.BackColor = System.Drawing.Color.White;
            this.pbSmS.Image = global::replace_campanhas.Properties.Resources.sms_dash4;
            this.pbSmS.Location = new System.Drawing.Point(44, 71);
            this.pbSmS.Name = "pbSmS";
            this.pbSmS.Size = new System.Drawing.Size(584, 194);
            this.pbSmS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmS.TabIndex = 50;
            this.pbSmS.TabStop = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.White;
            this.pbAvatar.Image = global::replace_campanhas.Properties.Resources.ClaroLogo2;
            this.pbAvatar.Location = new System.Drawing.Point(634, 164);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(100, 101);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 48;
            this.pbAvatar.TabStop = false;
            // 
            // pbInterfaceSms
            // 
            this.pbInterfaceSms.Image = global::replace_campanhas.Properties.Resources.interface_sms3;
            this.pbInterfaceSms.Location = new System.Drawing.Point(12, 12);
            this.pbInterfaceSms.Name = "pbInterfaceSms";
            this.pbInterfaceSms.Size = new System.Drawing.Size(758, 480);
            this.pbInterfaceSms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInterfaceSms.TabIndex = 47;
            this.pbInterfaceSms.TabStop = false;
            // 
            // frmValidaFraseSMSV3Solicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 527);
            this.Controls.Add(this.rtxtSms);
            this.Controls.Add(this.pbSmS);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblCaracteresCampanha);
            this.Controls.Add(this.rtxtFraseEntrada);
            this.Controls.Add(this.pbInterfaceSms);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmValidaFraseSMSV3Solicitante";
            this.Text = "Valida frase SMS";
            this.Load += new System.EventHandler(this.frmValidaFraseSMSV3Solicitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSmS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInterfaceSms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtFraseEntrada;
        private System.Windows.Forms.Label lblCaracteresCampanha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbInterfaceSms;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.RichTextBox rtxtSms;
        private System.Windows.Forms.PictureBox pbSmS;
    }
}