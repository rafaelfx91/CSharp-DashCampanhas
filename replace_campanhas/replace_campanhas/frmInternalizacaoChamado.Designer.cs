namespace replace_campanhas
{
    partial class frmInternalizacaoChamado
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
            this.tbInternalisacao = new System.Windows.Forms.TabControl();
            this.tbTabelas = new System.Windows.Forms.TabPage();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.txtCamposTabela = new System.Windows.Forms.TextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.tbSaida = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblChamado = new System.Windows.Forms.Label();
            this.txtChamado = new System.Windows.Forms.TextBox();
            this.tbInternalisacao.SuspendLayout();
            this.tbTabelas.SuspendLayout();
            this.tbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInternalisacao
            // 
            this.tbInternalisacao.Controls.Add(this.tbTabelas);
            this.tbInternalisacao.Controls.Add(this.tbSaida);
            this.tbInternalisacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbInternalisacao.Location = new System.Drawing.Point(12, 12);
            this.tbInternalisacao.Name = "tbInternalisacao";
            this.tbInternalisacao.SelectedIndex = 0;
            this.tbInternalisacao.Size = new System.Drawing.Size(620, 536);
            this.tbInternalisacao.TabIndex = 38;
            // 
            // tbTabelas
            // 
            this.tbTabelas.Controls.Add(this.lblDias);
            this.tbTabelas.Controls.Add(this.txtDias);
            this.tbTabelas.Controls.Add(this.lblPeriodo);
            this.tbTabelas.Controls.Add(this.lblTabela);
            this.tbTabelas.Controls.Add(this.txtTabela);
            this.tbTabelas.Controls.Add(this.lblCampos);
            this.tbTabelas.Controls.Add(this.txtCamposTabela);
            this.tbTabelas.Controls.Add(this.lblMotivo);
            this.tbTabelas.Controls.Add(this.txtMotivo);
            this.tbTabelas.Location = new System.Drawing.Point(4, 34);
            this.tbTabelas.Name = "tbTabelas";
            this.tbTabelas.Padding = new System.Windows.Forms.Padding(3);
            this.tbTabelas.Size = new System.Drawing.Size(612, 498);
            this.tbTabelas.TabIndex = 0;
            this.tbTabelas.Text = "Tabelas";
            this.tbTabelas.UseVisualStyleBackColor = true;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(3, 422);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(600, 64);
            this.txtMotivo.TabIndex = 18;
            this.txtMotivo.Text = "Sera usado nas OSs: ";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(531, 550);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 35;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(427, 550);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(16, 550);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(98, 43);
            this.btnCarregar.TabIndex = 34;
            this.btnCarregar.Text = "Gerar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(0, 394);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(262, 25);
            this.lblMotivo.TabIndex = 19;
            this.lblMotivo.Text = "Motivo da nescecidade:";
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Location = new System.Drawing.Point(-2, 90);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(209, 25);
            this.lblCampos.TabIndex = 21;
            this.lblCampos.Text = "Campos da tabela:";
            // 
            // txtCamposTabela
            // 
            this.txtCamposTabela.Location = new System.Drawing.Point(0, 118);
            this.txtCamposTabela.Multiline = true;
            this.txtCamposTabela.Name = "txtCamposTabela";
            this.txtCamposTabela.Size = new System.Drawing.Size(600, 187);
            this.txtCamposTabela.TabIndex = 20;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(0, 2);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(254, 25);
            this.lblTabela.TabIndex = 23;
            this.lblTabela.Text = "Tabela a ser mapeada:";
            // 
            // txtTabela
            // 
            this.txtTabela.Location = new System.Drawing.Point(0, 30);
            this.txtTabela.Multiline = true;
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(600, 57);
            this.txtTabela.TabIndex = 22;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(1, 308);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(113, 25);
            this.lblPeriodo.TabIndex = 24;
            this.lblPeriodo.Text = "Pedriodo:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(6, 336);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(108, 31);
            this.txtDias.TabIndex = 25;
            this.txtDias.Text = "90";
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(120, 339);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(59, 25);
            this.lblDias.TabIndex = 26;
            this.lblDias.Text = "Dias";
            // 
            // tbSaida
            // 
            this.tbSaida.Controls.Add(this.lblTitulo);
            this.tbSaida.Controls.Add(this.txtTitulo);
            this.tbSaida.Controls.Add(this.lblChamado);
            this.tbSaida.Controls.Add(this.txtChamado);
            this.tbSaida.Location = new System.Drawing.Point(4, 34);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Padding = new System.Windows.Forms.Padding(3);
            this.tbSaida.Size = new System.Drawing.Size(612, 498);
            this.tbSaida.TabIndex = 1;
            this.tbSaida.Text = "Saida";
            this.tbSaida.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 25);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(3, 31);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(600, 57);
            this.txtTitulo.TabIndex = 26;
            // 
            // lblChamado
            // 
            this.lblChamado.AutoSize = true;
            this.lblChamado.Location = new System.Drawing.Point(1, 91);
            this.lblChamado.Name = "lblChamado";
            this.lblChamado.Size = new System.Drawing.Size(111, 25);
            this.lblChamado.TabIndex = 25;
            this.lblChamado.Text = "Chamado";
            // 
            // txtChamado
            // 
            this.txtChamado.Location = new System.Drawing.Point(3, 119);
            this.txtChamado.Multiline = true;
            this.txtChamado.Name = "txtChamado";
            this.txtChamado.Size = new System.Drawing.Size(600, 373);
            this.txtChamado.TabIndex = 24;
            // 
            // frmInternalizacaoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 603);
            this.Controls.Add(this.tbInternalisacao);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Name = "frmInternalizacaoChamado";
            this.Text = "frmInternalizacaoChamado";
            this.Load += new System.EventHandler(this.frmInternalizacaoChamado_Load);
            this.tbInternalisacao.ResumeLayout(false);
            this.tbTabelas.ResumeLayout(false);
            this.tbTabelas.PerformLayout();
            this.tbSaida.ResumeLayout(false);
            this.tbSaida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbInternalisacao;
        private System.Windows.Forms.TabPage tbTabelas;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.TextBox txtTabela;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.TextBox txtCamposTabela;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TabPage tbSaida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblChamado;
        private System.Windows.Forms.TextBox txtChamado;
    }
}