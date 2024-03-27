namespace replace_campanhas
{
    partial class frmRCS3
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
            this.txtLinkImg = new System.Windows.Forms.TextBox();
            this.wbLinkImg = new System.Windows.Forms.WebBrowser();
            this.lblLinkImg = new System.Windows.Forms.Label();
            this.lblFraseL = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblTituloL = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtLinkBotao = new System.Windows.Forms.TextBox();
            this.wbLinkBotao = new System.Windows.Forms.WebBrowser();
            this.lblLinkBotao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLinkImg
            // 
            this.txtLinkImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImg.Location = new System.Drawing.Point(12, 279);
            this.txtLinkImg.Name = "txtLinkImg";
            this.txtLinkImg.Size = new System.Drawing.Size(460, 31);
            this.txtLinkImg.TabIndex = 58;
            // 
            // wbLinkImg
            // 
            this.wbLinkImg.Location = new System.Drawing.Point(12, 316);
            this.wbLinkImg.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLinkImg.Name = "wbLinkImg";
            this.wbLinkImg.Size = new System.Drawing.Size(460, 201);
            this.wbLinkImg.TabIndex = 57;
            // 
            // lblLinkImg
            // 
            this.lblLinkImg.AutoSize = true;
            this.lblLinkImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkImg.Location = new System.Drawing.Point(12, 251);
            this.lblLinkImg.Name = "lblLinkImg";
            this.lblLinkImg.Size = new System.Drawing.Size(157, 25);
            this.lblLinkImg.TabIndex = 56;
            this.lblLinkImg.Text = "Link Img Card";
            // 
            // lblFraseL
            // 
            this.lblFraseL.AutoSize = true;
            this.lblFraseL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseL.Location = new System.Drawing.Point(189, 126);
            this.lblFraseL.Name = "lblFraseL";
            this.lblFraseL.Size = new System.Drawing.Size(245, 25);
            this.lblFraseL.TabIndex = 55;
            this.lblFraseL.Text = "Frase limite 250 Char:";
            // 
            // txtFrase
            // 
            this.txtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrase.Location = new System.Drawing.Point(12, 154);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(460, 90);
            this.txtFrase.TabIndex = 54;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(12, 126);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(129, 25);
            this.lblFrase.TabIndex = 53;
            this.lblFrase.Text = "Frase Card";
            // 
            // lblTituloL
            // 
            this.lblTituloL.AutoSize = true;
            this.lblTituloL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloL.Location = new System.Drawing.Point(189, 5);
            this.lblTituloL.Name = "lblTituloL";
            this.lblTituloL.Size = new System.Drawing.Size(244, 25);
            this.lblTituloL.TabIndex = 52;
            this.lblTituloL.Text = "Titulo limite 200 Char:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 521);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 51;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 521);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 50;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 521);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 49;
            this.btnGerar.Text = "Validar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 33);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(460, 90);
            this.txtTitulo.TabIndex = 48;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(128, 25);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Titulo Card";
            // 
            // txtLinkBotao
            // 
            this.txtLinkBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkBotao.Location = new System.Drawing.Point(478, 38);
            this.txtLinkBotao.Name = "txtLinkBotao";
            this.txtLinkBotao.Size = new System.Drawing.Size(460, 31);
            this.txtLinkBotao.TabIndex = 61;
            // 
            // wbLinkBotao
            // 
            this.wbLinkBotao.Location = new System.Drawing.Point(478, 75);
            this.wbLinkBotao.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLinkBotao.Name = "wbLinkBotao";
            this.wbLinkBotao.Size = new System.Drawing.Size(460, 201);
            this.wbLinkBotao.TabIndex = 60;
            // 
            // lblLinkBotao
            // 
            this.lblLinkBotao.AutoSize = true;
            this.lblLinkBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkBotao.Location = new System.Drawing.Point(478, 10);
            this.lblLinkBotao.Name = "lblLinkBotao";
            this.lblLinkBotao.Size = new System.Drawing.Size(122, 25);
            this.lblLinkBotao.TabIndex = 59;
            this.lblLinkBotao.Text = "Link botao";
            // 
            // frmRCS3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 576);
            this.Controls.Add(this.txtLinkBotao);
            this.Controls.Add(this.wbLinkBotao);
            this.Controls.Add(this.lblLinkBotao);
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
            this.Name = "frmRCS3";
            this.Text = "frmRCS3";
            this.Load += new System.EventHandler(this.frmRCS3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinkImg;
        private System.Windows.Forms.WebBrowser wbLinkImg;
        private System.Windows.Forms.Label lblLinkImg;
        private System.Windows.Forms.Label lblFraseL;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblTituloL;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtLinkBotao;
        private System.Windows.Forms.WebBrowser wbLinkBotao;
        private System.Windows.Forms.Label lblLinkBotao;
    }
}