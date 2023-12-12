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
            this.gerarNomeNoSASV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoCampanhasJIRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoEmailJIRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailDeDiagramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeExcellStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarFraseSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarFrasePUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claroPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectiveMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERRAMENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeSenhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoEmUmaLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(702, 9);
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
            this.hTMLToolStripMenuItem,
            this.fERRAMENTASToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 45);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "mnPrincipal";
            // 
            // sASToolStripMenuItem
            // 
            this.sASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNomeNoSASToolStripMenuItem,
            this.gerarNomeNoSASV2ToolStripMenuItem,
            this.agendamentoCampanhasJIRAToolStripMenuItem,
            this.agendamentoEmailJIRAToolStripMenuItem,
            this.emailDeDiagramaToolStripMenuItem,
            this.geradorDeExcellStripMenuItem});
            this.sASToolStripMenuItem.Name = "sASToolStripMenuItem";
            this.sASToolStripMenuItem.Size = new System.Drawing.Size(78, 41);
            this.sASToolStripMenuItem.Text = "SAS";
            // 
            // gerarNomeNoSASToolStripMenuItem
            // 
            this.gerarNomeNoSASToolStripMenuItem.Name = "gerarNomeNoSASToolStripMenuItem";
            this.gerarNomeNoSASToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.gerarNomeNoSASToolStripMenuItem.Text = "Gerar nome no SAS";
            this.gerarNomeNoSASToolStripMenuItem.Click += new System.EventHandler(this.gerarNomeNoSASToolStripMenuItem_Click);
            // 
            // gerarNomeNoSASV2ToolStripMenuItem
            // 
            this.gerarNomeNoSASV2ToolStripMenuItem.Name = "gerarNomeNoSASV2ToolStripMenuItem";
            this.gerarNomeNoSASV2ToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.gerarNomeNoSASV2ToolStripMenuItem.Text = "Gerar nome no SAS V2";
            this.gerarNomeNoSASV2ToolStripMenuItem.Visible = false;
            this.gerarNomeNoSASV2ToolStripMenuItem.Click += new System.EventHandler(this.gerarNomeNoSASV2ToolStripMenuItem_Click);
            // 
            // agendamentoCampanhasJIRAToolStripMenuItem
            // 
            this.agendamentoCampanhasJIRAToolStripMenuItem.Name = "agendamentoCampanhasJIRAToolStripMenuItem";
            this.agendamentoCampanhasJIRAToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.agendamentoCampanhasJIRAToolStripMenuItem.Text = "Agendamento campanhas (JIRA)";
            this.agendamentoCampanhasJIRAToolStripMenuItem.Click += new System.EventHandler(this.agendamentoCampanhasJIRAToolStripMenuItem_Click);
            // 
            // agendamentoEmailJIRAToolStripMenuItem
            // 
            this.agendamentoEmailJIRAToolStripMenuItem.Name = "agendamentoEmailJIRAToolStripMenuItem";
            this.agendamentoEmailJIRAToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.agendamentoEmailJIRAToolStripMenuItem.Text = "Agendamento email (CP)(JIRA)";
            this.agendamentoEmailJIRAToolStripMenuItem.Visible = false;
            this.agendamentoEmailJIRAToolStripMenuItem.Click += new System.EventHandler(this.agendamentoEmailJIRAToolStripMenuItem_Click);
            // 
            // emailDeDiagramaToolStripMenuItem
            // 
            this.emailDeDiagramaToolStripMenuItem.Name = "emailDeDiagramaToolStripMenuItem";
            this.emailDeDiagramaToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.emailDeDiagramaToolStripMenuItem.Text = "Envio de diagrama (CP)";
            this.emailDeDiagramaToolStripMenuItem.Visible = false;
            this.emailDeDiagramaToolStripMenuItem.Click += new System.EventHandler(this.emailDeDiagramaToolStripMenuItem_Click);
            // 
            // geradorDeExcellStripMenuItem
            // 
            this.geradorDeExcellStripMenuItem.Name = "geradorDeExcellStripMenuItem";
            this.geradorDeExcellStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.geradorDeExcellStripMenuItem.Text = "Gerador de excell (CP)";
            this.geradorDeExcellStripMenuItem.Click += new System.EventHandler(this.geradorDeExcellStripMenuItem_Click);
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
            this.validarFraseSMSToolStripMenuItem.Size = new System.Drawing.Size(254, 42);
            this.validarFraseSMSToolStripMenuItem.Text = "Validar frase";
            this.validarFraseSMSToolStripMenuItem.Click += new System.EventHandler(this.validarFraseSMSToolStripMenuItem_Click);
            // 
            // pUSHToolStripMenuItem
            // 
            this.pUSHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarFrasePUSHToolStripMenuItem,
            this.claroPayToolStripMenuItem});
            this.pUSHToolStripMenuItem.Name = "pUSHToolStripMenuItem";
            this.pUSHToolStripMenuItem.Size = new System.Drawing.Size(102, 41);
            this.pUSHToolStripMenuItem.Text = "PUSH";
            // 
            // validarFrasePUSHToolStripMenuItem
            // 
            this.validarFrasePUSHToolStripMenuItem.Name = "validarFrasePUSHToolStripMenuItem";
            this.validarFrasePUSHToolStripMenuItem.Size = new System.Drawing.Size(254, 42);
            this.validarFrasePUSHToolStripMenuItem.Text = "Validar frase";
            this.validarFrasePUSHToolStripMenuItem.Click += new System.EventHandler(this.validarFrasePUSHToolStripMenuItem_Click);
            // 
            // claroPayToolStripMenuItem
            // 
            this.claroPayToolStripMenuItem.Name = "claroPayToolStripMenuItem";
            this.claroPayToolStripMenuItem.Size = new System.Drawing.Size(254, 42);
            this.claroPayToolStripMenuItem.Text = "Claro Pay ";
            this.claroPayToolStripMenuItem.Click += new System.EventHandler(this.claroPayToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarHtmlToolStripMenuItem,
            this.effectiveMailToolStripMenuItem});
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(106, 41);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // validarHtmlToolStripMenuItem
            // 
            this.validarHtmlToolStripMenuItem.Name = "validarHtmlToolStripMenuItem";
            this.validarHtmlToolStripMenuItem.Size = new System.Drawing.Size(269, 42);
            this.validarHtmlToolStripMenuItem.Text = "Validar html";
            this.validarHtmlToolStripMenuItem.Click += new System.EventHandler(this.validarHtmlToolStripMenuItem_Click);
            // 
            // effectiveMailToolStripMenuItem
            // 
            this.effectiveMailToolStripMenuItem.Name = "effectiveMailToolStripMenuItem";
            this.effectiveMailToolStripMenuItem.Size = new System.Drawing.Size(269, 42);
            this.effectiveMailToolStripMenuItem.Text = "Effective Mail";
            this.effectiveMailToolStripMenuItem.Click += new System.EventHandler(this.effectiveMailToolStripMenuItem_Click);
            // 
            // fERRAMENTASToolStripMenuItem
            // 
            this.fERRAMENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeSenhasToolStripMenuItem,
            this.encriptadorToolStripMenuItem,
            this.testeToolStripMenuItem,
            this.textoEmUmaLinhaToolStripMenuItem});
            this.fERRAMENTASToolStripMenuItem.Name = "fERRAMENTASToolStripMenuItem";
            this.fERRAMENTASToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.fERRAMENTASToolStripMenuItem.Text = "FERRAMENTAS";
            // 
            // geradorDeSenhasToolStripMenuItem
            // 
            this.geradorDeSenhasToolStripMenuItem.Name = "geradorDeSenhasToolStripMenuItem";
            this.geradorDeSenhasToolStripMenuItem.Size = new System.Drawing.Size(347, 42);
            this.geradorDeSenhasToolStripMenuItem.Text = "Gerar senhas";
            this.geradorDeSenhasToolStripMenuItem.Click += new System.EventHandler(this.geradorDeSenhasToolStripMenuItem_Click);
            // 
            // encriptadorToolStripMenuItem
            // 
            this.encriptadorToolStripMenuItem.Name = "encriptadorToolStripMenuItem";
            this.encriptadorToolStripMenuItem.Size = new System.Drawing.Size(347, 42);
            this.encriptadorToolStripMenuItem.Text = "Encriptador 256Bits";
            this.encriptadorToolStripMenuItem.Visible = false;
            this.encriptadorToolStripMenuItem.Click += new System.EventHandler(this.encriptadorToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(347, 42);
            this.testeToolStripMenuItem.Text = "TESTE";
            this.testeToolStripMenuItem.Visible = false;
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // textoEmUmaLinhaToolStripMenuItem
            // 
            this.textoEmUmaLinhaToolStripMenuItem.Name = "textoEmUmaLinhaToolStripMenuItem";
            this.textoEmUmaLinhaToolStripMenuItem.Size = new System.Drawing.Size(347, 42);
            this.textoEmUmaLinhaToolStripMenuItem.Text = "Texto em uma linha";
            this.textoEmUmaLinhaToolStripMenuItem.Visible = false;
            this.textoEmUmaLinhaToolStripMenuItem.Click += new System.EventHandler(this.textoEmUmaLinhaToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(90, 41);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::replace_campanhas.Properties.Resources.plusoft;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                         ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNomeNoSASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarFraseSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fERRAMENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradorDeSenhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarFrasePUSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarHtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claroPayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoCampanhasJIRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoEmailJIRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailDeDiagramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encriptadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradorDeExcellStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNomeNoSASV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoEmUmaLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectiveMailToolStripMenuItem;
    }
}

