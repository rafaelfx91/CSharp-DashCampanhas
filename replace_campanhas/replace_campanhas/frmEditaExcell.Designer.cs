namespace replace_campanhas
{
    partial class frmEditaExcell
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.lblCaminhoArquivo = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.rdrPausa = new System.Windows.Forms.RadioButton();
            this.rdrCancelamento = new System.Windows.Forms.RadioButton();
            this.rdrAgendamento = new System.Windows.Forms.RadioButton();
            this.txtListaDeCampanhas = new System.Windows.Forms.TextBox();
            this.lblListaCampanhas = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 435);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 49;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 435);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 48;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 435);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 47;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(185, 9);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(517, 27);
            this.txtCaminhoArquivo.TabIndex = 54;
            // 
            // lblCaminhoArquivo
            // 
            this.lblCaminhoArquivo.AutoSize = true;
            this.lblCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoArquivo.Location = new System.Drawing.Point(12, 12);
            this.lblCaminhoArquivo.Name = "lblCaminhoArquivo";
            this.lblCaminhoArquivo.Size = new System.Drawing.Size(167, 20);
            this.lblCaminhoArquivo.TabIndex = 53;
            this.lblCaminhoArquivo.Text = "Caminho do arquivo";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAbrir.Location = new System.Drawing.Point(708, 6);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(80, 32);
            this.btnAbrir.TabIndex = 55;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // rdrPausa
            // 
            this.rdrPausa.AutoSize = true;
            this.rdrPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrPausa.Location = new System.Drawing.Point(309, 48);
            this.rdrPausa.Name = "rdrPausa";
            this.rdrPausa.Size = new System.Drawing.Size(77, 24);
            this.rdrPausa.TabIndex = 36;
            this.rdrPausa.Text = "Pausa";
            this.rdrPausa.UseVisualStyleBackColor = true;
            // 
            // rdrCancelamento
            // 
            this.rdrCancelamento.AutoSize = true;
            this.rdrCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrCancelamento.Location = new System.Drawing.Point(157, 48);
            this.rdrCancelamento.Name = "rdrCancelamento";
            this.rdrCancelamento.Size = new System.Drawing.Size(146, 24);
            this.rdrCancelamento.TabIndex = 35;
            this.rdrCancelamento.Text = "Camcelamento";
            this.rdrCancelamento.UseVisualStyleBackColor = true;
            // 
            // rdrAgendamento
            // 
            this.rdrAgendamento.AutoSize = true;
            this.rdrAgendamento.Checked = true;
            this.rdrAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrAgendamento.Location = new System.Drawing.Point(12, 48);
            this.rdrAgendamento.Name = "rdrAgendamento";
            this.rdrAgendamento.Size = new System.Drawing.Size(139, 24);
            this.rdrAgendamento.TabIndex = 34;
            this.rdrAgendamento.TabStop = true;
            this.rdrAgendamento.Text = "Agendamento";
            this.rdrAgendamento.UseVisualStyleBackColor = true;
            // 
            // txtListaDeCampanhas
            // 
            this.txtListaDeCampanhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtListaDeCampanhas.Location = new System.Drawing.Point(12, 98);
            this.txtListaDeCampanhas.Multiline = true;
            this.txtListaDeCampanhas.Name = "txtListaDeCampanhas";
            this.txtListaDeCampanhas.Size = new System.Drawing.Size(306, 331);
            this.txtListaDeCampanhas.TabIndex = 56;
            // 
            // lblListaCampanhas
            // 
            this.lblListaCampanhas.AutoSize = true;
            this.lblListaCampanhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCampanhas.Location = new System.Drawing.Point(12, 75);
            this.lblListaCampanhas.Name = "lblListaCampanhas";
            this.lblListaCampanhas.Size = new System.Drawing.Size(170, 20);
            this.lblListaCampanhas.TabIndex = 57;
            this.lblListaCampanhas.Text = "Lista de campanhas";
            // 
            // btnTeste
            // 
            this.btnTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(690, 424);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(98, 43);
            this.btnTeste.TabIndex = 58;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // frmEditaExcell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblListaCampanhas);
            this.Controls.Add(this.txtListaDeCampanhas);
            this.Controls.Add(this.rdrPausa);
            this.Controls.Add(this.rdrCancelamento);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.rdrAgendamento);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.lblCaminhoArquivo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Name = "frmEditaExcell";
            this.Text = "Gerador de excell";
            this.Load += new System.EventHandler(this.frmEditaExcell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.Label lblCaminhoArquivo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.RadioButton rdrPausa;
        private System.Windows.Forms.RadioButton rdrCancelamento;
        private System.Windows.Forms.RadioButton rdrAgendamento;
        private System.Windows.Forms.TextBox txtListaDeCampanhas;
        private System.Windows.Forms.Label lblListaCampanhas;
        private System.Windows.Forms.Button btnTeste;
    }
}