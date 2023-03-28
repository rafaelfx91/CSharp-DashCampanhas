namespace replace_campanhas
{
    partial class frmValidaFraseSMS
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
            this.lblCaracteresCampanha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtFraseEntrada = new System.Windows.Forms.TextBox();
            this.lblFraseEntrada = new System.Windows.Forms.Label();
            this.lblFraseSaida = new System.Windows.Forms.Label();
            this.txtFraseSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCaracteresCampanha
            // 
            this.lblCaracteresCampanha.AutoSize = true;
            this.lblCaracteresCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteresCampanha.Location = new System.Drawing.Point(614, 12);
            this.lblCaracteresCampanha.Name = "lblCaracteresCampanha";
            this.lblCaracteresCampanha.Size = new System.Drawing.Size(121, 25);
            this.lblCaracteresCampanha.TabIndex = 25;
            this.lblCaracteresCampanha.Text = "Caracters:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 274);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 274);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 274);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 22;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtFraseEntrada
            // 
            this.txtFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseEntrada.Location = new System.Drawing.Point(12, 38);
            this.txtFraseEntrada.Multiline = true;
            this.txtFraseEntrada.Name = "txtFraseEntrada";
            this.txtFraseEntrada.Size = new System.Drawing.Size(776, 90);
            this.txtFraseEntrada.TabIndex = 19;
            this.txtFraseEntrada.TextChanged += new System.EventHandler(this.txtFraseEntrada_TextChanged);
            // 
            // lblFraseEntrada
            // 
            this.lblFraseEntrada.AutoSize = true;
            this.lblFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseEntrada.Location = new System.Drawing.Point(15, 10);
            this.lblFraseEntrada.Name = "lblFraseEntrada";
            this.lblFraseEntrada.Size = new System.Drawing.Size(159, 25);
            this.lblFraseEntrada.TabIndex = 18;
            this.lblFraseEntrada.Text = "Frase entrada";
            // 
            // lblFraseSaida
            // 
            this.lblFraseSaida.AutoSize = true;
            this.lblFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseSaida.Location = new System.Drawing.Point(12, 140);
            this.lblFraseSaida.Name = "lblFraseSaida";
            this.lblFraseSaida.Size = new System.Drawing.Size(136, 25);
            this.lblFraseSaida.TabIndex = 20;
            this.lblFraseSaida.Text = "Frase saida";
            // 
            // txtFraseSaida
            // 
            this.txtFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseSaida.Location = new System.Drawing.Point(12, 168);
            this.txtFraseSaida.Multiline = true;
            this.txtFraseSaida.Name = "txtFraseSaida";
            this.txtFraseSaida.Size = new System.Drawing.Size(776, 100);
            this.txtFraseSaida.TabIndex = 21;
            // 
            // frmValidaFraseSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.lblCaracteresCampanha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFraseEntrada);
            this.Controls.Add(this.lblFraseEntrada);
            this.Controls.Add(this.lblFraseSaida);
            this.Controls.Add(this.txtFraseSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmValidaFraseSMS";
            this.Text = "Validar frase do SMS";
            this.Load += new System.EventHandler(this.frmValidaFraseSMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaracteresCampanha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtFraseEntrada;
        private System.Windows.Forms.Label lblFraseEntrada;
        private System.Windows.Forms.Label lblFraseSaida;
        private System.Windows.Forms.TextBox txtFraseSaida;
    }
}