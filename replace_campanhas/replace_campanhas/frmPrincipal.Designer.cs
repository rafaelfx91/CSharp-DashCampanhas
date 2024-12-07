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
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaFraseV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSMSSolicitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarFrasePUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claroPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarPUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RCS1validacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RCS2validacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RCS3validacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERRAMENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeSenhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIKEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repicksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringUpLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(694, 639);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(43, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Versao:";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sASToolStripMenuItem,
            this.sMSToolStripMenuItem,
            this.pUSHToolStripMenuItem,
            this.hTMLToolStripMenuItem,
            this.rCSToolStripMenuItem,
            this.fERRAMENTASToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 45);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "mnPrincipal";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sASToolStripMenuItem
            // 
            this.sASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNomeNoSASToolStripMenuItem,
            this.gerarNomeNoSASV2ToolStripMenuItem,
            this.agendamentoCampanhasJIRAToolStripMenuItem});
            this.sASToolStripMenuItem.Name = "sASToolStripMenuItem";
            this.sASToolStripMenuItem.Size = new System.Drawing.Size(78, 41);
            this.sASToolStripMenuItem.Text = "SAS";
            // 
            // gerarNomeNoSASToolStripMenuItem
            // 
            this.gerarNomeNoSASToolStripMenuItem.Name = "gerarNomeNoSASToolStripMenuItem";
            this.gerarNomeNoSASToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.gerarNomeNoSASToolStripMenuItem.Text = "Gerar nome campanha";
            this.gerarNomeNoSASToolStripMenuItem.Click += new System.EventHandler(this.gerarNomeNoSASToolStripMenuItem_Click);
            // 
            // gerarNomeNoSASV2ToolStripMenuItem
            // 
            this.gerarNomeNoSASV2ToolStripMenuItem.Name = "gerarNomeNoSASV2ToolStripMenuItem";
            this.gerarNomeNoSASV2ToolStripMenuItem.Size = new System.Drawing.Size(513, 42);
            this.gerarNomeNoSASV2ToolStripMenuItem.Text = "Gerar nome campanhaV2";
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
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validaFraseV2ToolStripMenuItem,
            this.validaSMSSolicitanteToolStripMenuItem});
            this.sMSToolStripMenuItem.Image = global::replace_campanhas.Properties.Resources.sms;
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(101, 41);
            this.sMSToolStripMenuItem.Text = "SMS";
            // 
            // validaFraseV2ToolStripMenuItem
            // 
            this.validaFraseV2ToolStripMenuItem.Name = "validaFraseV2ToolStripMenuItem";
            this.validaFraseV2ToolStripMenuItem.Size = new System.Drawing.Size(379, 42);
            this.validaFraseV2ToolStripMenuItem.Text = "Fabrica valida SMS V2";
            this.validaFraseV2ToolStripMenuItem.Click += new System.EventHandler(this.validaFraseV2ToolStripMenuItem_Click);
            // 
            // validaSMSSolicitanteToolStripMenuItem
            // 
            this.validaSMSSolicitanteToolStripMenuItem.Name = "validaSMSSolicitanteToolStripMenuItem";
            this.validaSMSSolicitanteToolStripMenuItem.Size = new System.Drawing.Size(379, 42);
            this.validaSMSSolicitanteToolStripMenuItem.Text = "Solicitante valida SMS";
            this.validaSMSSolicitanteToolStripMenuItem.Click += new System.EventHandler(this.validaSMSSolicitanteToolStripMenuItem_Click);
            // 
            // pUSHToolStripMenuItem
            // 
            this.pUSHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarFrasePUSHToolStripMenuItem,
            this.claroPayToolStripMenuItem,
            this.validarPUSHToolStripMenuItem});
            this.pUSHToolStripMenuItem.Image = global::replace_campanhas.Properties.Resources.notificacao_push;
            this.pUSHToolStripMenuItem.Name = "pUSHToolStripMenuItem";
            this.pUSHToolStripMenuItem.Size = new System.Drawing.Size(118, 41);
            this.pUSHToolStripMenuItem.Text = "PUSH";
            // 
            // validarFrasePUSHToolStripMenuItem
            // 
            this.validarFrasePUSHToolStripMenuItem.Name = "validarFrasePUSHToolStripMenuItem";
            this.validarFrasePUSHToolStripMenuItem.Size = new System.Drawing.Size(339, 42);
            this.validarFrasePUSHToolStripMenuItem.Text = "Fabrica valida push";
            this.validarFrasePUSHToolStripMenuItem.Click += new System.EventHandler(this.validarFrasePUSHToolStripMenuItem_Click);
            // 
            // claroPayToolStripMenuItem
            // 
            this.claroPayToolStripMenuItem.Name = "claroPayToolStripMenuItem";
            this.claroPayToolStripMenuItem.Size = new System.Drawing.Size(339, 42);
            this.claroPayToolStripMenuItem.Text = "Fabrica Claro Pay ";
            this.claroPayToolStripMenuItem.Click += new System.EventHandler(this.claroPayToolStripMenuItem_Click);
            // 
            // validarPUSHToolStripMenuItem
            // 
            this.validarPUSHToolStripMenuItem.Name = "validarPUSHToolStripMenuItem";
            this.validarPUSHToolStripMenuItem.Size = new System.Drawing.Size(339, 42);
            this.validarPUSHToolStripMenuItem.Text = "Validar frase push";
            this.validarPUSHToolStripMenuItem.Click += new System.EventHandler(this.validarPUSHToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarHtmlToolStripMenuItem});
            this.hTMLToolStripMenuItem.Image = global::replace_campanhas.Properties.Resources.e_mail;
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(122, 41);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // validarHtmlToolStripMenuItem
            // 
            this.validarHtmlToolStripMenuItem.Name = "validarHtmlToolStripMenuItem";
            this.validarHtmlToolStripMenuItem.Size = new System.Drawing.Size(251, 42);
            this.validarHtmlToolStripMenuItem.Text = "Validar html";
            this.validarHtmlToolStripMenuItem.Click += new System.EventHandler(this.validarHtmlToolStripMenuItem_Click);
            // 
            // rCSToolStripMenuItem
            // 
            this.rCSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RCS1validacaoToolStripMenuItem,
            this.RCS2validacaoToolStripMenuItem,
            this.RCS3validacaoToolStripMenuItem});
            this.rCSToolStripMenuItem.Image = global::replace_campanhas.Properties.Resources.RCS;
            this.rCSToolStripMenuItem.Name = "rCSToolStripMenuItem";
            this.rCSToolStripMenuItem.Size = new System.Drawing.Size(95, 41);
            this.rCSToolStripMenuItem.Text = "RCS";
            // 
            // RCS1validacaoToolStripMenuItem
            // 
            this.RCS1validacaoToolStripMenuItem.Name = "RCS1validacaoToolStripMenuItem";
            this.RCS1validacaoToolStripMenuItem.Size = new System.Drawing.Size(328, 42);
            this.RCS1validacaoToolStripMenuItem.Text = "MSG SIMPLES Dev";
            this.RCS1validacaoToolStripMenuItem.Click += new System.EventHandler(this.RCS1validacaoToolStripMenuItem_Click);
            // 
            // RCS2validacaoToolStripMenuItem
            // 
            this.RCS2validacaoToolStripMenuItem.Name = "RCS2validacaoToolStripMenuItem";
            this.RCS2validacaoToolStripMenuItem.Size = new System.Drawing.Size(328, 42);
            this.RCS2validacaoToolStripMenuItem.Text = "CARD UNICO Dev";
            this.RCS2validacaoToolStripMenuItem.Click += new System.EventHandler(this.RCS2validacaoToolStripMenuItem_Click);
            // 
            // RCS3validacaoToolStripMenuItem
            // 
            this.RCS3validacaoToolStripMenuItem.Name = "RCS3validacaoToolStripMenuItem";
            this.RCS3validacaoToolStripMenuItem.Size = new System.Drawing.Size(328, 42);
            this.RCS3validacaoToolStripMenuItem.Text = "Validacao";
            this.RCS3validacaoToolStripMenuItem.Click += new System.EventHandler(this.RCS3validacaoToolStripMenuItem_Click);
            // 
            // fERRAMENTASToolStripMenuItem
            // 
            this.fERRAMENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeSenhasToolStripMenuItem,
            this.encriptadorToolStripMenuItem,
            this.testeToolStripMenuItem,
            this.porcentagemToolStripMenuItem,
            this.hIKEToolStripMenuItem,
            this.oSsToolStripMenuItem,
            this.repicksToolStripMenuItem,
            this.stringUpLowerToolStripMenuItem});
            this.fERRAMENTASToolStripMenuItem.Image = global::replace_campanhas.Properties.Resources.configuracoes;
            this.fERRAMENTASToolStripMenuItem.Name = "fERRAMENTASToolStripMenuItem";
            this.fERRAMENTASToolStripMenuItem.Size = new System.Drawing.Size(154, 41);
            this.fERRAMENTASToolStripMenuItem.Text = "OUTROS";
            // 
            // geradorDeSenhasToolStripMenuItem
            // 
            this.geradorDeSenhasToolStripMenuItem.Name = "geradorDeSenhasToolStripMenuItem";
            this.geradorDeSenhasToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.geradorDeSenhasToolStripMenuItem.Text = "Gerar senhas";
            this.geradorDeSenhasToolStripMenuItem.Click += new System.EventHandler(this.geradorDeSenhasToolStripMenuItem_Click);
            // 
            // encriptadorToolStripMenuItem
            // 
            this.encriptadorToolStripMenuItem.Name = "encriptadorToolStripMenuItem";
            this.encriptadorToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.encriptadorToolStripMenuItem.Text = "Encriptador 256Bits Dev";
            this.encriptadorToolStripMenuItem.Visible = false;
            this.encriptadorToolStripMenuItem.Click += new System.EventHandler(this.encriptadorToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.testeToolStripMenuItem.Text = "TESTE VS";
            this.testeToolStripMenuItem.Visible = false;
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // porcentagemToolStripMenuItem
            // 
            this.porcentagemToolStripMenuItem.Name = "porcentagemToolStripMenuItem";
            this.porcentagemToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.porcentagemToolStripMenuItem.Text = "Porcentagem Dev";
            this.porcentagemToolStripMenuItem.Click += new System.EventHandler(this.porcentagemToolStripMenuItem_Click);
            // 
            // hIKEToolStripMenuItem
            // 
            this.hIKEToolStripMenuItem.Name = "hIKEToolStripMenuItem";
            this.hIKEToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.hIKEToolStripMenuItem.Text = "HIKE VS";
            this.hIKEToolStripMenuItem.Click += new System.EventHandler(this.hIKEToolStripMenuItem_Click);
            // 
            // oSsToolStripMenuItem
            // 
            this.oSsToolStripMenuItem.Name = "oSsToolStripMenuItem";
            this.oSsToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.oSsToolStripMenuItem.Text = "OSs Dev";
            this.oSsToolStripMenuItem.Click += new System.EventHandler(this.oSsToolStripMenuItem_Click);
            // 
            // repicksToolStripMenuItem
            // 
            this.repicksToolStripMenuItem.Name = "repicksToolStripMenuItem";
            this.repicksToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.repicksToolStripMenuItem.Text = "Repicks Dev";
            this.repicksToolStripMenuItem.Click += new System.EventHandler(this.repicksToolStripMenuItem_Click);
            // 
            // stringUpLowerToolStripMenuItem
            // 
            this.stringUpLowerToolStripMenuItem.Name = "stringUpLowerToolStripMenuItem";
            this.stringUpLowerToolStripMenuItem.Size = new System.Drawing.Size(404, 42);
            this.stringUpLowerToolStripMenuItem.Text = "String Up-Lower Dev";
            this.stringUpLowerToolStripMenuItem.Click += new System.EventHandler(this.stringUpLowerToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Image = global::replace_campanhas.Properties.Resources.desligar;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(106, 41);
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
        private System.Windows.Forms.ToolStripMenuItem encriptadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNomeNoSASV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIKEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repicksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RCS1validacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RCS2validacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RCS3validacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringUpLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaFraseV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSMSSolicitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarPUSHToolStripMenuItem;
    }
}

