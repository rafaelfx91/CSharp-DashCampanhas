namespace replace_campanhas
{
    partial class frmEncriptador
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblFraseEntrada = new System.Windows.Forms.Label();
            this.txtFraseEntrada = new System.Windows.Forms.TextBox();
            this.txtFraseSaida = new System.Windows.Forms.TextBox();
            this.lblFraseSaida = new System.Windows.Forms.Label();
            this.rdrEncripta = new System.Windows.Forms.RadioButton();
            this.rdrDecripta = new System.Windows.Forms.RadioButton();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 395);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 53;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 52;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 395);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 51;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(79, 7);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(173, 22);
            this.txtSenha.TabIndex = 55;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(12, 9);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 20);
            this.lblSenha.TabIndex = 54;
            this.lblSenha.Text = "Senha";
            // 
            // lblFraseEntrada
            // 
            this.lblFraseEntrada.AutoSize = true;
            this.lblFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseEntrada.Location = new System.Drawing.Point(12, 47);
            this.lblFraseEntrada.Name = "lblFraseEntrada";
            this.lblFraseEntrada.Size = new System.Drawing.Size(147, 20);
            this.lblFraseEntrada.TabIndex = 56;
            this.lblFraseEntrada.Text = "Frase de entrada";
            // 
            // txtFraseEntrada
            // 
            this.txtFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseEntrada.Location = new System.Drawing.Point(16, 70);
            this.txtFraseEntrada.Multiline = true;
            this.txtFraseEntrada.Name = "txtFraseEntrada";
            this.txtFraseEntrada.Size = new System.Drawing.Size(427, 131);
            this.txtFraseEntrada.TabIndex = 57;
            // 
            // txtFraseSaida
            // 
            this.txtFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseSaida.Location = new System.Drawing.Point(16, 232);
            this.txtFraseSaida.Multiline = true;
            this.txtFraseSaida.Name = "txtFraseSaida";
            this.txtFraseSaida.Size = new System.Drawing.Size(427, 131);
            this.txtFraseSaida.TabIndex = 59;
            // 
            // lblFraseSaida
            // 
            this.lblFraseSaida.AutoSize = true;
            this.lblFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseSaida.Location = new System.Drawing.Point(12, 209);
            this.lblFraseSaida.Name = "lblFraseSaida";
            this.lblFraseSaida.Size = new System.Drawing.Size(128, 20);
            this.lblFraseSaida.TabIndex = 58;
            this.lblFraseSaida.Text = "Frase de saida";
            // 
            // rdrEncripta
            // 
            this.rdrEncripta.AutoSize = true;
            this.rdrEncripta.Checked = true;
            this.rdrEncripta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrEncripta.Location = new System.Drawing.Point(349, 5);
            this.rdrEncripta.Name = "rdrEncripta";
            this.rdrEncripta.Size = new System.Drawing.Size(94, 24);
            this.rdrEncripta.TabIndex = 60;
            this.rdrEncripta.Text = "Encripta";
            this.rdrEncripta.UseVisualStyleBackColor = true;
            // 
            // rdrDecripta
            // 
            this.rdrDecripta.AutoSize = true;
            this.rdrDecripta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrDecripta.Location = new System.Drawing.Point(349, 35);
            this.rdrDecripta.Name = "rdrDecripta";
            this.rdrDecripta.Size = new System.Drawing.Size(95, 24);
            this.rdrDecripta.TabIndex = 61;
            this.rdrDecripta.Text = "Decripta";
            this.rdrDecripta.UseVisualStyleBackColor = true;
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.BackgroundImage = global::replace_campanhas.Properties.Resources.olho;
            this.btnVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerSenha.Location = new System.Drawing.Point(258, 7);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(27, 22);
            this.btnVerSenha.TabIndex = 62;
            this.btnVerSenha.UseVisualStyleBackColor = true;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // frmEncriptador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.btnVerSenha);
            this.Controls.Add(this.rdrDecripta);
            this.Controls.Add(this.rdrEncripta);
            this.Controls.Add(this.txtFraseSaida);
            this.Controls.Add(this.lblFraseSaida);
            this.Controls.Add(this.txtFraseEntrada);
            this.Controls.Add(this.lblFraseEntrada);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Name = "frmEncriptador";
            this.Text = "Encriptador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblFraseEntrada;
        private System.Windows.Forms.TextBox txtFraseEntrada;
        private System.Windows.Forms.TextBox txtFraseSaida;
        private System.Windows.Forms.Label lblFraseSaida;
        private System.Windows.Forms.RadioButton rdrEncripta;
        private System.Windows.Forms.RadioButton rdrDecripta;
        private System.Windows.Forms.Button btnVerSenha;
    }
}