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
            // frmRCS4SolicitanteVisualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 828);
            this.Controls.Add(this.wbImagem);
            this.Controls.Add(this.pbMensagem);
            this.Controls.Add(this.pbCelular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRCS4SolicitanteVisualizacao";
            this.Text = "Visualização";
            this.Load += new System.EventHandler(this.frmRCS4SolicitanteVisualizacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMensagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCelular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCelular;
        private System.Windows.Forms.PictureBox pbMensagem;
        private System.Windows.Forms.WebBrowser wbImagem;
    }
}