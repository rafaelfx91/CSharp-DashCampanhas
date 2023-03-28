namespace replace_campanhas
{
    partial class frmValidarFrasePush
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
            this.lblCaracterTitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtTituloEntrada = new System.Windows.Forms.TextBox();
            this.lblTituloPush = new System.Windows.Forms.Label();
            this.lblMensagemEntrada = new System.Windows.Forms.Label();
            this.txtMsgEntrada = new System.Windows.Forms.TextBox();
            this.txtTituloSaida = new System.Windows.Forms.TextBox();
            this.lblTituloSaida = new System.Windows.Forms.Label();
            this.lblCaracterMsg = new System.Windows.Forms.Label();
            this.txtMsgSaida = new System.Windows.Forms.TextBox();
            this.lblMsgSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaracterTitulo
            // 
            this.lblCaracterTitulo.AutoSize = true;
            this.lblCaracterTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterTitulo.Location = new System.Drawing.Point(606, 9);
            this.lblCaracterTitulo.Name = "lblCaracterTitulo";
            this.lblCaracterTitulo.Size = new System.Drawing.Size(121, 25);
            this.lblCaracterTitulo.TabIndex = 33;
            this.lblCaracterTitulo.Text = "Caracters:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 422);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(220, 422);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 422);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 30;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtTituloEntrada
            // 
            this.txtTituloEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloEntrada.Location = new System.Drawing.Point(12, 37);
            this.txtTituloEntrada.Name = "txtTituloEntrada";
            this.txtTituloEntrada.Size = new System.Drawing.Size(776, 31);
            this.txtTituloEntrada.TabIndex = 27;
            this.txtTituloEntrada.TextChanged += new System.EventHandler(this.txtTituloEntrada_TextChanged);
            // 
            // lblTituloPush
            // 
            this.lblTituloPush.AutoSize = true;
            this.lblTituloPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPush.Location = new System.Drawing.Point(12, 9);
            this.lblTituloPush.Name = "lblTituloPush";
            this.lblTituloPush.Size = new System.Drawing.Size(158, 25);
            this.lblTituloPush.TabIndex = 26;
            this.lblTituloPush.Text = "Titulo entrada";
            // 
            // lblMensagemEntrada
            // 
            this.lblMensagemEntrada.AutoSize = true;
            this.lblMensagemEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemEntrada.Location = new System.Drawing.Point(12, 79);
            this.lblMensagemEntrada.Name = "lblMensagemEntrada";
            this.lblMensagemEntrada.Size = new System.Drawing.Size(213, 25);
            this.lblMensagemEntrada.TabIndex = 28;
            this.lblMensagemEntrada.Text = "Mensagem entrada";
            // 
            // txtMsgEntrada
            // 
            this.txtMsgEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgEntrada.Location = new System.Drawing.Point(12, 107);
            this.txtMsgEntrada.Multiline = true;
            this.txtMsgEntrada.Name = "txtMsgEntrada";
            this.txtMsgEntrada.Size = new System.Drawing.Size(776, 100);
            this.txtMsgEntrada.TabIndex = 29;
            this.txtMsgEntrada.TextChanged += new System.EventHandler(this.txtFraseSaida_TextChanged);
            // 
            // txtTituloSaida
            // 
            this.txtTituloSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloSaida.Location = new System.Drawing.Point(12, 245);
            this.txtTituloSaida.Name = "txtTituloSaida";
            this.txtTituloSaida.Size = new System.Drawing.Size(776, 31);
            this.txtTituloSaida.TabIndex = 35;
            // 
            // lblTituloSaida
            // 
            this.lblTituloSaida.AutoSize = true;
            this.lblTituloSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSaida.Location = new System.Drawing.Point(12, 217);
            this.lblTituloSaida.Name = "lblTituloSaida";
            this.lblTituloSaida.Size = new System.Drawing.Size(135, 25);
            this.lblTituloSaida.TabIndex = 34;
            this.lblTituloSaida.Text = "Titulo saida";
            // 
            // lblCaracterMsg
            // 
            this.lblCaracterMsg.AutoSize = true;
            this.lblCaracterMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterMsg.Location = new System.Drawing.Point(606, 71);
            this.lblCaracterMsg.Name = "lblCaracterMsg";
            this.lblCaracterMsg.Size = new System.Drawing.Size(121, 25);
            this.lblCaracterMsg.TabIndex = 36;
            this.lblCaracterMsg.Text = "Caracters:";
            // 
            // txtMsgSaida
            // 
            this.txtMsgSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgSaida.Location = new System.Drawing.Point(12, 316);
            this.txtMsgSaida.Multiline = true;
            this.txtMsgSaida.Name = "txtMsgSaida";
            this.txtMsgSaida.Size = new System.Drawing.Size(776, 100);
            this.txtMsgSaida.TabIndex = 38;
            // 
            // lblMsgSaida
            // 
            this.lblMsgSaida.AutoSize = true;
            this.lblMsgSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgSaida.Location = new System.Drawing.Point(11, 288);
            this.lblMsgSaida.Name = "lblMsgSaida";
            this.lblMsgSaida.Size = new System.Drawing.Size(190, 25);
            this.lblMsgSaida.TabIndex = 37;
            this.lblMsgSaida.Text = "Mensagem saida";
            // 
            // frmValidarFrasePush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.txtMsgSaida);
            this.Controls.Add(this.lblMsgSaida);
            this.Controls.Add(this.lblCaracterMsg);
            this.Controls.Add(this.txtTituloSaida);
            this.Controls.Add(this.lblTituloSaida);
            this.Controls.Add(this.lblCaracterTitulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtTituloEntrada);
            this.Controls.Add(this.lblTituloPush);
            this.Controls.Add(this.lblMensagemEntrada);
            this.Controls.Add(this.txtMsgEntrada);
            this.Name = "frmValidarFrasePush";
            this.Text = "Validar frase push";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaracterTitulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtTituloEntrada;
        private System.Windows.Forms.Label lblTituloPush;
        private System.Windows.Forms.Label lblMensagemEntrada;
        private System.Windows.Forms.TextBox txtMsgEntrada;
        private System.Windows.Forms.TextBox txtTituloSaida;
        private System.Windows.Forms.Label lblTituloSaida;
        private System.Windows.Forms.Label lblCaracterMsg;
        private System.Windows.Forms.TextBox txtMsgSaida;
        private System.Windows.Forms.Label lblMsgSaida;
    }
}