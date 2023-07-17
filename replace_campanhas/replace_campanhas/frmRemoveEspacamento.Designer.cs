namespace replace_campanhas
{
    partial class frmRemoveEspacamento
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
            this.txtTextoEntrada = new System.Windows.Forms.TextBox();
            this.lblTextoEntrada = new System.Windows.Forms.Label();
            this.lblTextoSaida = new System.Windows.Forms.Label();
            this.txtTextoSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(113, 273);
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
            this.btnSair.Location = new System.Drawing.Point(217, 273);
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
            this.btnGerar.Location = new System.Drawing.Point(9, 273);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 31;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtTextoEntrada
            // 
            this.txtTextoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoEntrada.Location = new System.Drawing.Point(9, 37);
            this.txtTextoEntrada.Multiline = true;
            this.txtTextoEntrada.Name = "txtTextoEntrada";
            this.txtTextoEntrada.Size = new System.Drawing.Size(776, 90);
            this.txtTextoEntrada.TabIndex = 28;
            // 
            // lblTextoEntrada
            // 
            this.lblTextoEntrada.AutoSize = true;
            this.lblTextoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblTextoEntrada.Name = "lblTextoEntrada";
            this.lblTextoEntrada.Size = new System.Drawing.Size(191, 25);
            this.lblTextoEntrada.TabIndex = 27;
            this.lblTextoEntrada.Text = "Texto de entrada";
            // 
            // lblTextoSaida
            // 
            this.lblTextoSaida.AutoSize = true;
            this.lblTextoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSaida.Location = new System.Drawing.Point(9, 139);
            this.lblTextoSaida.Name = "lblTextoSaida";
            this.lblTextoSaida.Size = new System.Drawing.Size(136, 25);
            this.lblTextoSaida.TabIndex = 29;
            this.lblTextoSaida.Text = "Frase saida";
            // 
            // txtTextoSaida
            // 
            this.txtTextoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoSaida.Location = new System.Drawing.Point(9, 167);
            this.txtTextoSaida.Multiline = true;
            this.txtTextoSaida.Name = "txtTextoSaida";
            this.txtTextoSaida.Size = new System.Drawing.Size(776, 100);
            this.txtTextoSaida.TabIndex = 30;
            // 
            // frmRemoveEspacamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtTextoEntrada);
            this.Controls.Add(this.lblTextoEntrada);
            this.Controls.Add(this.lblTextoSaida);
            this.Controls.Add(this.txtTextoSaida);
            this.Name = "frmRemoveEspacamento";
            this.Text = "frmRemoveEspacamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtTextoEntrada;
        private System.Windows.Forms.Label lblTextoEntrada;
        private System.Windows.Forms.Label lblTextoSaida;
        private System.Windows.Forms.TextBox txtTextoSaida;
    }
}