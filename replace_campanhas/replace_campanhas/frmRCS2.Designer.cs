namespace replace_campanhas
{
    partial class frmRCS2
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
            this.lblTituloL = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFraseL = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblLinkImg = new System.Windows.Forms.Label();
            this.wbLinkImg = new System.Windows.Forms.WebBrowser();
            this.txtLinkImg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloL
            // 
            this.lblTituloL.AutoSize = true;
            this.lblTituloL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloL.Location = new System.Drawing.Point(337, 6);
            this.lblTituloL.Name = "lblTituloL";
            this.lblTituloL.Size = new System.Drawing.Size(244, 25);
            this.lblTituloL.TabIndex = 40;
            this.lblTituloL.Text = "Titulo limite 200 Char:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 524);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 39;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 524);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 524);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 37;
            this.btnGerar.Text = "Validar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 34);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(617, 90);
            this.txtTitulo.TabIndex = 36;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 25);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFraseL
            // 
            this.lblFraseL.AutoSize = true;
            this.lblFraseL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseL.Location = new System.Drawing.Point(336, 127);
            this.lblFraseL.Name = "lblFraseL";
            this.lblFraseL.Size = new System.Drawing.Size(245, 25);
            this.lblFraseL.TabIndex = 43;
            this.lblFraseL.Text = "Frase limite 250 Char:";
            // 
            // txtFrase
            // 
            this.txtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrase.Location = new System.Drawing.Point(12, 155);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(617, 90);
            this.txtFrase.TabIndex = 42;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(12, 127);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(72, 25);
            this.lblFrase.TabIndex = 41;
            this.lblFrase.Text = "Frase";
            // 
            // lblLinkImg
            // 
            this.lblLinkImg.AutoSize = true;
            this.lblLinkImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkImg.Location = new System.Drawing.Point(12, 252);
            this.lblLinkImg.Name = "lblLinkImg";
            this.lblLinkImg.Size = new System.Drawing.Size(100, 25);
            this.lblLinkImg.TabIndex = 44;
            this.lblLinkImg.Text = "Link img";
            // 
            // wbLinkImg
            // 
            this.wbLinkImg.Location = new System.Drawing.Point(12, 317);
            this.wbLinkImg.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLinkImg.Name = "wbLinkImg";
            this.wbLinkImg.Size = new System.Drawing.Size(617, 201);
            this.wbLinkImg.TabIndex = 45;
            // 
            // txtLinkImg
            // 
            this.txtLinkImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImg.Location = new System.Drawing.Point(12, 280);
            this.txtLinkImg.Name = "txtLinkImg";
            this.txtLinkImg.Size = new System.Drawing.Size(617, 31);
            this.txtLinkImg.TabIndex = 46;
            // 
            // frmRCS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 573);
            this.Controls.Add(this.txtLinkImg);
            this.Controls.Add(this.wbLinkImg);
            this.Controls.Add(this.lblLinkImg);
            this.Controls.Add(this.lblFraseL);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.lblTituloL);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRCS2";
            this.Text = "frmRCS2";
            this.Load += new System.EventHandler(this.frmRCS2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloL;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFraseL;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblLinkImg;
        private System.Windows.Forms.WebBrowser wbLinkImg;
        private System.Windows.Forms.TextBox txtLinkImg;
    }
}