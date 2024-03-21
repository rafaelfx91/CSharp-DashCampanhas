namespace replace_campanhas
{
    partial class frmOSs
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
            this.lbFazer = new System.Windows.Forms.ListBox();
            this.txtNomeOs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHomologacao = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAgendamento = new System.Windows.Forms.ListBox();
            this.btnAdicionaALista = new System.Windows.Forms.Button();
            this.btnMoveEsquerda = new System.Windows.Forms.Button();
            this.btnMoveDireita = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(868, 24);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 55;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbFazer
            // 
            this.lbFazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbFazer.FormattingEnabled = true;
            this.lbFazer.ItemHeight = 20;
            this.lbFazer.Location = new System.Drawing.Point(12, 107);
            this.lbFazer.Name = "lbFazer";
            this.lbFazer.Size = new System.Drawing.Size(314, 244);
            this.lbFazer.TabIndex = 57;
            this.lbFazer.SelectedIndexChanged += new System.EventHandler(this.lbFazer_SelectedIndexChanged);
            // 
            // txtNomeOs
            // 
            this.txtNomeOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNomeOs.Location = new System.Drawing.Point(12, 34);
            this.txtNomeOs.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeOs.Name = "txtNomeOs";
            this.txtNomeOs.Size = new System.Drawing.Size(476, 26);
            this.txtNomeOs.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Adicionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fazer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(328, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Homologacao / Entrega";
            // 
            // lbHomologacao
            // 
            this.lbHomologacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbHomologacao.FormattingEnabled = true;
            this.lbHomologacao.ItemHeight = 20;
            this.lbHomologacao.Location = new System.Drawing.Point(332, 107);
            this.lbHomologacao.Name = "lbHomologacao";
            this.lbHomologacao.Size = new System.Drawing.Size(314, 244);
            this.lbHomologacao.TabIndex = 61;
            this.lbHomologacao.SelectedIndexChanged += new System.EventHandler(this.lbHomologacao_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(646, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Agendamento / Repick";
            // 
            // lbAgendamento
            // 
            this.lbAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbAgendamento.FormattingEnabled = true;
            this.lbAgendamento.ItemHeight = 20;
            this.lbAgendamento.Location = new System.Drawing.Point(652, 107);
            this.lbAgendamento.Name = "lbAgendamento";
            this.lbAgendamento.Size = new System.Drawing.Size(314, 244);
            this.lbAgendamento.TabIndex = 63;
            this.lbAgendamento.SelectedIndexChanged += new System.EventHandler(this.lbAgendamento_SelectedIndexChanged);
            // 
            // btnAdicionaALista
            // 
            this.btnAdicionaALista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaALista.Location = new System.Drawing.Point(496, 24);
            this.btnAdicionaALista.Name = "btnAdicionaALista";
            this.btnAdicionaALista.Size = new System.Drawing.Size(69, 43);
            this.btnAdicionaALista.TabIndex = 65;
            this.btnAdicionaALista.Text = "ADD";
            this.btnAdicionaALista.UseVisualStyleBackColor = true;
            this.btnAdicionaALista.Click += new System.EventHandler(this.btnAdicionaALista_Click);
            // 
            // btnMoveEsquerda
            // 
            this.btnMoveEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveEsquerda.Location = new System.Drawing.Point(571, 24);
            this.btnMoveEsquerda.Name = "btnMoveEsquerda";
            this.btnMoveEsquerda.Size = new System.Drawing.Size(69, 43);
            this.btnMoveEsquerda.TabIndex = 66;
            this.btnMoveEsquerda.Text = "<--";
            this.btnMoveEsquerda.UseVisualStyleBackColor = true;
            this.btnMoveEsquerda.Click += new System.EventHandler(this.btnMoveEsquerda_Click);
            // 
            // btnMoveDireita
            // 
            this.btnMoveDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDireita.Location = new System.Drawing.Point(646, 24);
            this.btnMoveDireita.Name = "btnMoveDireita";
            this.btnMoveDireita.Size = new System.Drawing.Size(69, 43);
            this.btnMoveDireita.TabIndex = 67;
            this.btnMoveDireita.Text = "-->";
            this.btnMoveDireita.UseVisualStyleBackColor = true;
            this.btnMoveDireita.Click += new System.EventHandler(this.btnMoveDireita_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(721, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 43);
            this.btnRemove.TabIndex = 68;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmOSs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 359);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMoveDireita);
            this.Controls.Add(this.btnMoveEsquerda);
            this.Controls.Add(this.btnAdicionaALista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAgendamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHomologacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeOs);
            this.Controls.Add(this.lbFazer);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOSs";
            this.Text = "frmOSs";
            this.Load += new System.EventHandler(this.frmOSs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lbFazer;
        private System.Windows.Forms.TextBox txtNomeOs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbHomologacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbAgendamento;
        private System.Windows.Forms.Button btnAdicionaALista;
        private System.Windows.Forms.Button btnMoveEsquerda;
        private System.Windows.Forms.Button btnMoveDireita;
        private System.Windows.Forms.Button btnRemove;
    }
}