namespace replace_campanhas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarNomeNoSASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGENDAMENTOCAMPANHASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarFraseSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERRAMENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeSenhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1166, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Version:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sASToolStripMenuItem,
            this.sMSToolStripMenuItem,
            this.pUSHToolStripMenuItem,
            this.fERRAMENTASToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 45);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "mnPrincipal";
            // 
            // sASToolStripMenuItem
            // 
            this.sASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNomeNoSASToolStripMenuItem,
            this.aGENDAMENTOCAMPANHASToolStripMenuItem});
            this.sASToolStripMenuItem.Name = "sASToolStripMenuItem";
            this.sASToolStripMenuItem.Size = new System.Drawing.Size(78, 41);
            this.sASToolStripMenuItem.Text = "SAS";
            // 
            // gerarNomeNoSASToolStripMenuItem
            // 
            this.gerarNomeNoSASToolStripMenuItem.Name = "gerarNomeNoSASToolStripMenuItem";
            this.gerarNomeNoSASToolStripMenuItem.Size = new System.Drawing.Size(428, 42);
            this.gerarNomeNoSASToolStripMenuItem.Text = "Gerar nome no SAS";
            this.gerarNomeNoSASToolStripMenuItem.Click += new System.EventHandler(this.gerarNomeNoSASToolStripMenuItem_Click);
            // 
            // aGENDAMENTOCAMPANHASToolStripMenuItem
            // 
            this.aGENDAMENTOCAMPANHASToolStripMenuItem.Name = "aGENDAMENTOCAMPANHASToolStripMenuItem";
            this.aGENDAMENTOCAMPANHASToolStripMenuItem.Size = new System.Drawing.Size(428, 42);
            this.aGENDAMENTOCAMPANHASToolStripMenuItem.Text = "Agendamento campanhas";
            this.aGENDAMENTOCAMPANHASToolStripMenuItem.Click += new System.EventHandler(this.aGENDAMENTOCAMPANHASToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarFraseSMSToolStripMenuItem});
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(85, 41);
            this.sMSToolStripMenuItem.Text = "SMS";
            // 
            // validarFraseSMSToolStripMenuItem
            // 
            this.validarFraseSMSToolStripMenuItem.Name = "validarFraseSMSToolStripMenuItem";
            this.validarFraseSMSToolStripMenuItem.Size = new System.Drawing.Size(317, 42);
            this.validarFraseSMSToolStripMenuItem.Text = "Validar frase SMS";
            this.validarFraseSMSToolStripMenuItem.Click += new System.EventHandler(this.validarFraseSMSToolStripMenuItem_Click);
            // 
            // pUSHToolStripMenuItem
            // 
            this.pUSHToolStripMenuItem.Name = "pUSHToolStripMenuItem";
            this.pUSHToolStripMenuItem.Size = new System.Drawing.Size(102, 41);
            this.pUSHToolStripMenuItem.Text = "PUSH";
            // 
            // fERRAMENTASToolStripMenuItem
            // 
            this.fERRAMENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeSenhasToolStripMenuItem});
            this.fERRAMENTASToolStripMenuItem.Name = "fERRAMENTASToolStripMenuItem";
            this.fERRAMENTASToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.fERRAMENTASToolStripMenuItem.Text = "FERRAMENTAS";
            // 
            // geradorDeSenhasToolStripMenuItem
            // 
            this.geradorDeSenhasToolStripMenuItem.Name = "geradorDeSenhasToolStripMenuItem";
            this.geradorDeSenhasToolStripMenuItem.Size = new System.Drawing.Size(331, 42);
            this.geradorDeSenhasToolStripMenuItem.Text = "Gerador de senhas";
            this.geradorDeSenhasToolStripMenuItem.Click += new System.EventHandler(this.geradorDeSenhasToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(90, 41);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::replace_campanhas.Properties.Resources.plusoft;
            this.pictureBox1.Location = new System.Drawing.Point(1103, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campanhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNomeNoSASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarFraseSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fERRAMENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGENDAMENTOCAMPANHASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradorDeSenhasToolStripMenuItem;
    }
}

