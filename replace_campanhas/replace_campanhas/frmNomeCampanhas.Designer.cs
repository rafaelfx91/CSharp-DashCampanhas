namespace replace_campanhas
{
    partial class frmNomeCampanhas
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
            this.txtFraseEntrada = new System.Windows.Forms.TextBox();
            this.lblFraseEntrada = new System.Windows.Forms.Label();
            this.lblFraseSaida = new System.Windows.Forms.Label();
            this.txtFraseSaida = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblCaracteresCampanha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFraseEntrada
            // 
            this.txtFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseEntrada.Location = new System.Drawing.Point(12, 35);
            this.txtFraseEntrada.Multiline = true;
            this.txtFraseEntrada.Name = "txtFraseEntrada";
            this.txtFraseEntrada.Size = new System.Drawing.Size(776, 90);
            this.txtFraseEntrada.TabIndex = 5;
            this.txtFraseEntrada.TextChanged += new System.EventHandler(this.txtFraseEntrada_TextChanged);
            // 
            // lblFraseEntrada
            // 
            this.lblFraseEntrada.AutoSize = true;
            this.lblFraseEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseEntrada.Location = new System.Drawing.Point(15, 7);
            this.lblFraseEntrada.Name = "lblFraseEntrada";
            this.lblFraseEntrada.Size = new System.Drawing.Size(274, 25);
            this.lblFraseEntrada.TabIndex = 4;
            this.lblFraseEntrada.Text = "Nome campanha entrada";
            // 
            // lblFraseSaida
            // 
            this.lblFraseSaida.AutoSize = true;
            this.lblFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseSaida.Location = new System.Drawing.Point(12, 137);
            this.lblFraseSaida.Name = "lblFraseSaida";
            this.lblFraseSaida.Size = new System.Drawing.Size(251, 25);
            this.lblFraseSaida.TabIndex = 6;
            this.lblFraseSaida.Text = "Nome campanha saida";
            // 
            // txtFraseSaida
            // 
            this.txtFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseSaida.Location = new System.Drawing.Point(12, 165);
            this.txtFraseSaida.Multiline = true;
            this.txtFraseSaida.Name = "txtFraseSaida";
            this.txtFraseSaida.Size = new System.Drawing.Size(776, 100);
            this.txtFraseSaida.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 271);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 271);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 271);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 14;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblCaracteresCampanha
            // 
            this.lblCaracteresCampanha.AutoSize = true;
            this.lblCaracteresCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteresCampanha.Location = new System.Drawing.Point(614, 9);
            this.lblCaracteresCampanha.Name = "lblCaracteresCampanha";
            this.lblCaracteresCampanha.Size = new System.Drawing.Size(121, 25);
            this.lblCaracteresCampanha.TabIndex = 17;
            this.lblCaracteresCampanha.Text = "Caracters:";
            // 
            // frmNomeCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.lblCaracteresCampanha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFraseEntrada);
            this.Controls.Add(this.lblFraseEntrada);
            this.Controls.Add(this.lblFraseSaida);
            this.Controls.Add(this.txtFraseSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNomeCampanhas";
            this.Text = "Nome campanhas SAS";
            this.Load += new System.EventHandler(this.frmNomeCampanhas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFraseEntrada;
        private System.Windows.Forms.Label lblFraseEntrada;
        private System.Windows.Forms.Label lblFraseSaida;
        private System.Windows.Forms.TextBox txtFraseSaida;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblCaracteresCampanha;
    }
}