namespace replace_campanhas
{
    partial class frmRCS1
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
            this.txtFraseEntrada = new System.Windows.Forms.TextBox();
            this.lblFraseEntrada = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 195);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 195);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 195);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 31;
            this.btnGerar.Text = "Validar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtFraseEntrada
            // 
            this.txtFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseEntrada.Location = new System.Drawing.Point(12, 37);
            this.txtFraseEntrada.Multiline = true;
            this.txtFraseEntrada.Name = "txtFraseEntrada";
            this.txtFraseEntrada.Size = new System.Drawing.Size(776, 90);
            this.txtFraseEntrada.TabIndex = 28;
            this.txtFraseEntrada.TextChanged += new System.EventHandler(this.txtFraseEntrada_TextChanged);
            // 
            // lblFraseEntrada
            // 
            this.lblFraseEntrada.AutoSize = true;
            this.lblFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblFraseEntrada.Name = "lblFraseEntrada";
            this.lblFraseEntrada.Size = new System.Drawing.Size(72, 25);
            this.lblFraseEntrada.TabIndex = 27;
            this.lblFraseEntrada.Text = "Frase";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(435, 9);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(245, 25);
            this.lblLimite.TabIndex = 34;
            this.lblLimite.Text = "Frase limite 250 Char:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(12, 158);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(776, 31);
            this.txtLink.TabIndex = 35;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(12, 130);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(56, 25);
            this.lblLink.TabIndex = 36;
            this.lblLink.Text = "Link";
            // 
            // frmRCS1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 249);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFraseEntrada);
            this.Controls.Add(this.lblFraseEntrada);
            this.Name = "frmRCS1";
            this.Text = "frmRCS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtFraseEntrada;
        private System.Windows.Forms.Label lblFraseEntrada;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLink;
    }
}