namespace replace_campanhas
{
    partial class frmRCS4SolicitanteVisualizacao
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
            this.pbMensagem = new System.Windows.Forms.PictureBox();
            this.pbCelular = new System.Windows.Forms.PictureBox();
            this.wbImagem = new System.Windows.Forms.WebBrowser();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMensagem
            // 
            this.pbMensagem.Image = global::replace_campanhas.Properties.Resources.rcsMensagem2;
            this.pbMensagem.Location = new System.Drawing.Point(23, 449);
            this.pbMensagem.Name = "pbMensagem";
            this.pbMensagem.Size = new System.Drawing.Size(461, 334);
            this.pbMensagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensagem.TabIndex = 1;
            this.pbMensagem.TabStop = false;
            // 
            // pbCelular
            // 
            this.pbCelular.Image = global::replace_campanhas.Properties.Resources.rcsDash2;
            this.pbCelular.Location = new System.Drawing.Point(0, -5);
            this.pbCelular.Name = "pbCelular";
            this.pbCelular.Size = new System.Drawing.Size(513, 835);
            this.pbCelular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCelular.TabIndex = 0;
            this.pbCelular.TabStop = false;
            // 
            // wbImagem
            // 
            this.wbImagem.Location = new System.Drawing.Point(23, 156);
            this.wbImagem.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbImagem.Name = "wbImagem";
            this.wbImagem.Size = new System.Drawing.Size(461, 310);
            this.wbImagem.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(34, 472);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(433, 81);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.ForeColor = System.Drawing.Color.White;
            this.txtMsg.Location = new System.Drawing.Point(34, 559);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(433, 164);
            this.txtMsg.TabIndex = 4;
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnLink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLink.Location = new System.Drawing.Point(34, 729);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(352, 40);
            this.btnLink.TabIndex = 5;
            this.btnLink.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(392, 728);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 42);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRCS4SolicitanteVisualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 828);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.wbImagem);
            this.Controls.Add(this.pbMensagem);
            this.Controls.Add(this.pbCelular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRCS4SolicitanteVisualizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualização";
            this.Load += new System.EventHandler(this.frmRCS4SolicitanteVisualizacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMensagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCelular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCelular;
        private System.Windows.Forms.PictureBox pbMensagem;
        private System.Windows.Forms.WebBrowser wbImagem;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnSair;
    }
}