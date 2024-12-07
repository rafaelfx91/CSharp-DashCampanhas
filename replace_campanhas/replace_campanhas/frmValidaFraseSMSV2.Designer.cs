namespace replace_campanhas
{
    partial class frmValidaFraseSMSV2
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
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lblCaracteresCampanha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblFraseEntrada = new System.Windows.Forms.Label();
            this.rtxtFraseEntrada = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(115, 134);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(98, 43);
            this.btnCopiar.TabIndex = 36;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lblCaracteresCampanha
            // 
            this.lblCaracteresCampanha.AutoSize = true;
            this.lblCaracteresCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteresCampanha.Location = new System.Drawing.Point(554, 4);
            this.lblCaracteresCampanha.Name = "lblCaracteresCampanha";
            this.lblCaracteresCampanha.Size = new System.Drawing.Size(121, 25);
            this.lblCaracteresCampanha.TabIndex = 35;
            this.lblCaracteresCampanha.Text = "Caracters:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(219, 134);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 34;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(323, 134);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(11, 134);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 32;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblFraseEntrada
            // 
            this.lblFraseEntrada.AutoSize = true;
            this.lblFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseEntrada.Location = new System.Drawing.Point(15, 4);
            this.lblFraseEntrada.Name = "lblFraseEntrada";
            this.lblFraseEntrada.Size = new System.Drawing.Size(72, 25);
            this.lblFraseEntrada.TabIndex = 28;
            this.lblFraseEntrada.Text = "Frase";
            // 
            // rtxtFraseEntrada
            // 
            this.rtxtFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rtxtFraseEntrada.Location = new System.Drawing.Point(12, 32);
            this.rtxtFraseEntrada.Name = "rtxtFraseEntrada";
            this.rtxtFraseEntrada.Size = new System.Drawing.Size(776, 96);
            this.rtxtFraseEntrada.TabIndex = 38;
            this.rtxtFraseEntrada.Text = "";
            this.rtxtFraseEntrada.TextChanged += new System.EventHandler(this.rtxtFraseEntrada_TextChanged);
            // 
            // frmValidaFraseSMSV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 189);
            this.Controls.Add(this.rtxtFraseEntrada);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.lblCaracteresCampanha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblFraseEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmValidaFraseSMSV2";
            this.Text = "frmValidaFraseSMSV2";
            this.Load += new System.EventHandler(this.frmValidaFraseSMSV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblCaracteresCampanha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblFraseEntrada;
        private System.Windows.Forms.RichTextBox rtxtFraseEntrada;
    }
}