namespace replace_campanhas
{
    partial class frmAgendamentos
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
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblFraseSaida = new System.Windows.Forms.Label();
            this.txtAgendamento = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.tbN2 = new System.Windows.Forms.TabControl();
            this.tbCarregar = new System.Windows.Forms.TabPage();
            this.tbAgendamento = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCaminho = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbN2.SuspendLayout();
            this.tbCarregar.SuspendLayout();
            this.tbAgendamento.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(117, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 43);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Copiar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(221, 391);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(325, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(13, 391);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(98, 43);
            this.btnCarregar.TabIndex = 30;
            this.btnCarregar.Text = "Gerar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // lblFraseSaida
            // 
            this.lblFraseSaida.AutoSize = true;
            this.lblFraseSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseSaida.Location = new System.Drawing.Point(1, 13);
            this.lblFraseSaida.Name = "lblFraseSaida";
            this.lblFraseSaida.Size = new System.Drawing.Size(156, 25);
            this.lblFraseSaida.TabIndex = 28;
            this.lblFraseSaida.Text = "Agendamento";
            // 
            // txtAgendamento
            // 
            this.txtAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendamento.Location = new System.Drawing.Point(6, 41);
            this.txtAgendamento.Multiline = true;
            this.txtAgendamento.Name = "txtAgendamento";
            this.txtAgendamento.Size = new System.Drawing.Size(694, 300);
            this.txtAgendamento.TabIndex = 29;
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(3, 43);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(707, 31);
            this.txtCaminhoArquivo.TabIndex = 34;
            // 
            // tbN2
            // 
            this.tbN2.Controls.Add(this.tbCarregar);
            this.tbN2.Controls.Add(this.tbAgendamento);
            this.tbN2.Controls.Add(this.tabPage3);
            this.tbN2.Controls.Add(this.tabPage4);
            this.tbN2.Location = new System.Drawing.Point(12, 12);
            this.tbN2.Name = "tbN2";
            this.tbN2.SelectedIndex = 0;
            this.tbN2.Size = new System.Drawing.Size(724, 373);
            this.tbN2.TabIndex = 35;
            // 
            // tbCarregar
            // 
            this.tbCarregar.Controls.Add(this.lblCaminho);
            this.tbCarregar.Controls.Add(this.txtCaminhoArquivo);
            this.tbCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbCarregar.Location = new System.Drawing.Point(4, 22);
            this.tbCarregar.Name = "tbCarregar";
            this.tbCarregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarregar.Size = new System.Drawing.Size(716, 347);
            this.tbCarregar.TabIndex = 0;
            this.tbCarregar.Text = "Carregar";
            this.tbCarregar.UseVisualStyleBackColor = true;
            // 
            // tbAgendamento
            // 
            this.tbAgendamento.Controls.Add(this.txtAgendamento);
            this.tbAgendamento.Controls.Add(this.lblFraseSaida);
            this.tbAgendamento.Location = new System.Drawing.Point(4, 22);
            this.tbAgendamento.Name = "tbAgendamento";
            this.tbAgendamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgendamento.Size = new System.Drawing.Size(716, 347);
            this.tbAgendamento.TabIndex = 1;
            this.tbAgendamento.Text = "Agendamento";
            this.tbAgendamento.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminho.Location = new System.Drawing.Point(6, 15);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(189, 25);
            this.lblCaminho.TabIndex = 37;
            this.lblCaminho.Text = "Caminho arquivo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(716, 347);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(694, 300);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Agendamento";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(694, 300);
            this.textBox2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Agendamento";
            // 
            // frmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 707);
            this.Controls.Add(this.tbN2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCarregar);
            this.Name = "frmAgendamentos";
            this.Text = "frmAgendamentos";
            this.Load += new System.EventHandler(this.frmAgendamentos_Load);
            this.tbN2.ResumeLayout(false);
            this.tbCarregar.ResumeLayout(false);
            this.tbCarregar.PerformLayout();
            this.tbAgendamento.ResumeLayout(false);
            this.tbAgendamento.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblFraseSaida;
        private System.Windows.Forms.TextBox txtAgendamento;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.TabControl tbN2;
        private System.Windows.Forms.TabPage tbCarregar;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TabPage tbAgendamento;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}