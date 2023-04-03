namespace replace_campanhas
{
    partial class frmValidaHtml
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
            this.wbPecaEmail = new System.Windows.Forms.WebBrowser();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.txtCoringas = new System.Windows.Forms.TextBox();
            this.lblCaminhoArquivo = new System.Windows.Forms.Label();
            this.lblCoringas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wbPecaEmail
            // 
            this.wbPecaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbPecaEmail.Location = new System.Drawing.Point(12, 162);
            this.wbPecaEmail.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPecaEmail.Name = "wbPecaEmail";
            this.wbPecaEmail.Size = new System.Drawing.Size(805, 396);
            this.wbPecaEmail.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(696, 61);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 43);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(696, 113);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 43);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(696, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(121, 43);
            this.btnAbrir.TabIndex = 27;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(12, 29);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(678, 26);
            this.txtCaminhoArquivo.TabIndex = 28;
            // 
            // txtCoringas
            // 
            this.txtCoringas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoringas.Location = new System.Drawing.Point(12, 86);
            this.txtCoringas.Multiline = true;
            this.txtCoringas.Name = "txtCoringas";
            this.txtCoringas.Size = new System.Drawing.Size(678, 70);
            this.txtCoringas.TabIndex = 29;
            // 
            // lblCaminhoArquivo
            // 
            this.lblCaminhoArquivo.AutoSize = true;
            this.lblCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoArquivo.Location = new System.Drawing.Point(12, 1);
            this.lblCaminhoArquivo.Name = "lblCaminhoArquivo";
            this.lblCaminhoArquivo.Size = new System.Drawing.Size(189, 25);
            this.lblCaminhoArquivo.TabIndex = 30;
            this.lblCaminhoArquivo.Text = "Caminho arquivo";
            // 
            // lblCoringas
            // 
            this.lblCoringas.AutoSize = true;
            this.lblCoringas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoringas.Location = new System.Drawing.Point(12, 58);
            this.lblCoringas.Name = "lblCoringas";
            this.lblCoringas.Size = new System.Drawing.Size(106, 25);
            this.lblCoringas.TabIndex = 31;
            this.lblCoringas.Text = "Coringas";
            // 
            // frmValidaHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 570);
            this.Controls.Add(this.lblCoringas);
            this.Controls.Add(this.lblCaminhoArquivo);
            this.Controls.Add(this.txtCoringas);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.wbPecaEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmValidaHtml";
            this.Text = "frmValidaHtml";
            this.Load += new System.EventHandler(this.frmValidaHtml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPecaEmail;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.TextBox txtCoringas;
        private System.Windows.Forms.Label lblCaminhoArquivo;
        private System.Windows.Forms.Label lblCoringas;
    }
}