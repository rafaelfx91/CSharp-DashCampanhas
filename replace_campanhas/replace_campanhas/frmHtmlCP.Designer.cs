namespace replace_campanhas
{
    partial class frmHtmlCP
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbControleDados = new System.Windows.Forms.TabControl();
            this.tbBotoes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbBotoesLink = new System.Windows.Forms.ListBox();
            this.txtAddLinkBtn = new System.Windows.Forms.TextBox();
            this.lblAddtb1 = new System.Windows.Forms.Label();
            this.btnAddBtn = new System.Windows.Forms.Button();
            this.btnExcBtn = new System.Windows.Forms.Button();
            this.btnSalvarTabs = new System.Windows.Forms.Button();
            this.btnCarregaTabs = new System.Windows.Forms.Button();
            this.btnBtnsTestLink = new System.Windows.Forms.Button();
            this.wbView = new System.Windows.Forms.WebBrowser();
            this.tbControleDados.SuspendLayout();
            this.tbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(342, 520);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(238, 520);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 39;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbControleDados
            // 
            this.tbControleDados.Controls.Add(this.tbBotoes);
            this.tbControleDados.Controls.Add(this.tabPage2);
            this.tbControleDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbControleDados.Location = new System.Drawing.Point(12, 12);
            this.tbControleDados.Name = "tbControleDados";
            this.tbControleDados.SelectedIndex = 0;
            this.tbControleDados.Size = new System.Drawing.Size(428, 506);
            this.tbControleDados.TabIndex = 67;
            // 
            // tbBotoes
            // 
            this.tbBotoes.Controls.Add(this.btnBtnsTestLink);
            this.tbBotoes.Controls.Add(this.btnExcBtn);
            this.tbBotoes.Controls.Add(this.btnAddBtn);
            this.tbBotoes.Controls.Add(this.lblAddtb1);
            this.tbBotoes.Controls.Add(this.txtAddLinkBtn);
            this.tbBotoes.Controls.Add(this.lbBotoesLink);
            this.tbBotoes.Location = new System.Drawing.Point(4, 29);
            this.tbBotoes.Name = "tbBotoes";
            this.tbBotoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbBotoes.Size = new System.Drawing.Size(420, 473);
            this.tbBotoes.TabIndex = 0;
            this.tbBotoes.Text = "Botoes";
            this.tbBotoes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbBotoesLink
            // 
            this.lbBotoesLink.FormattingEnabled = true;
            this.lbBotoesLink.ItemHeight = 20;
            this.lbBotoesLink.Items.AddRange(new object[] {
            "a",
            "s",
            "d",
            "f"});
            this.lbBotoesLink.Location = new System.Drawing.Point(6, 6);
            this.lbBotoesLink.Name = "lbBotoesLink";
            this.lbBotoesLink.Size = new System.Drawing.Size(408, 384);
            this.lbBotoesLink.TabIndex = 2;
            // 
            // txtAddLinkBtn
            // 
            this.txtAddLinkBtn.Location = new System.Drawing.Point(58, 392);
            this.txtAddLinkBtn.Name = "txtAddLinkBtn";
            this.txtAddLinkBtn.Size = new System.Drawing.Size(356, 26);
            this.txtAddLinkBtn.TabIndex = 3;
            // 
            // lblAddtb1
            // 
            this.lblAddtb1.AutoSize = true;
            this.lblAddtb1.Location = new System.Drawing.Point(6, 395);
            this.lblAddtb1.Name = "lblAddtb1";
            this.lblAddtb1.Size = new System.Drawing.Size(46, 20);
            this.lblAddtb1.TabIndex = 4;
            this.lblAddtb1.Text = "Add:";
            // 
            // btnAddBtn
            // 
            this.btnAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBtn.Location = new System.Drawing.Point(10, 424);
            this.btnAddBtn.Name = "btnAddBtn";
            this.btnAddBtn.Size = new System.Drawing.Size(98, 43);
            this.btnAddBtn.TabIndex = 38;
            this.btnAddBtn.Text = "Add";
            this.btnAddBtn.UseVisualStyleBackColor = true;
            this.btnAddBtn.Click += new System.EventHandler(this.btnAddBtn_Click);
            // 
            // btnExcBtn
            // 
            this.btnExcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcBtn.Location = new System.Drawing.Point(114, 424);
            this.btnExcBtn.Name = "btnExcBtn";
            this.btnExcBtn.Size = new System.Drawing.Size(98, 43);
            this.btnExcBtn.TabIndex = 39;
            this.btnExcBtn.Text = "Excluir";
            this.btnExcBtn.UseVisualStyleBackColor = true;
            this.btnExcBtn.Click += new System.EventHandler(this.btnExcBtn_Click);
            // 
            // btnSalvarTabs
            // 
            this.btnSalvarTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTabs.Location = new System.Drawing.Point(12, 520);
            this.btnSalvarTabs.Name = "btnSalvarTabs";
            this.btnSalvarTabs.Size = new System.Drawing.Size(98, 43);
            this.btnSalvarTabs.TabIndex = 68;
            this.btnSalvarTabs.Text = "Salvar";
            this.btnSalvarTabs.UseVisualStyleBackColor = true;
            this.btnSalvarTabs.Click += new System.EventHandler(this.btnSalvarTabs_Click);
            // 
            // btnCarregaTabs
            // 
            this.btnCarregaTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaTabs.Location = new System.Drawing.Point(116, 520);
            this.btnCarregaTabs.Name = "btnCarregaTabs";
            this.btnCarregaTabs.Size = new System.Drawing.Size(116, 43);
            this.btnCarregaTabs.TabIndex = 69;
            this.btnCarregaTabs.Text = "Carregar";
            this.btnCarregaTabs.UseVisualStyleBackColor = true;
            this.btnCarregaTabs.Click += new System.EventHandler(this.btnCarregaTabs_Click);
            // 
            // btnBtnsTestLink
            // 
            this.btnBtnsTestLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtnsTestLink.Location = new System.Drawing.Point(356, 424);
            this.btnBtnsTestLink.Name = "btnBtnsTestLink";
            this.btnBtnsTestLink.Size = new System.Drawing.Size(58, 43);
            this.btnBtnsTestLink.TabIndex = 40;
            this.btnBtnsTestLink.Text = "=>";
            this.btnBtnsTestLink.UseVisualStyleBackColor = true;
            this.btnBtnsTestLink.Click += new System.EventHandler(this.btnBtnsTestLink_Click);
            // 
            // wbView
            // 
            this.wbView.Location = new System.Drawing.Point(442, 41);
            this.wbView.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbView.Name = "wbView";
            this.wbView.Size = new System.Drawing.Size(346, 477);
            this.wbView.TabIndex = 70;
            // 
            // frmHtmlCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.wbView);
            this.Controls.Add(this.btnCarregaTabs);
            this.Controls.Add(this.btnSalvarTabs);
            this.Controls.Add(this.tbControleDados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Name = "frmHtmlCP";
            this.Text = "frmHtmlCP";
            this.tbControleDados.ResumeLayout(false);
            this.tbBotoes.ResumeLayout(false);
            this.tbBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TabControl tbControleDados;
        private System.Windows.Forms.TabPage tbBotoes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbBotoesLink;
        private System.Windows.Forms.Label lblAddtb1;
        private System.Windows.Forms.TextBox txtAddLinkBtn;
        private System.Windows.Forms.Button btnAddBtn;
        private System.Windows.Forms.Button btnExcBtn;
        private System.Windows.Forms.Button btnSalvarTabs;
        private System.Windows.Forms.Button btnCarregaTabs;
        private System.Windows.Forms.Button btnBtnsTestLink;
        private System.Windows.Forms.WebBrowser wbView;
    }
}