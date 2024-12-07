namespace replace_campanhas
{
    partial class frmValidaFrasePushV3Solicitante
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
            this.lblCaracterMsg = new System.Windows.Forms.Label();
            this.lblCaracterTitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTituloEntrada = new System.Windows.Forms.TextBox();
            this.txtMsgEntrada = new System.Windows.Forms.TextBox();
            this.rdClaroPay = new System.Windows.Forms.RadioButton();
            this.rdMinahClaroMovel = new System.Windows.Forms.RadioButton();
            this.rdClaroResidencial = new System.Windows.Forms.RadioButton();
            this.pbPushLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPushLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaracterMsg
            // 
            this.lblCaracterMsg.AutoSize = true;
            this.lblCaracterMsg.BackColor = System.Drawing.Color.LightGray;
            this.lblCaracterMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterMsg.Location = new System.Drawing.Point(163, 253);
            this.lblCaracterMsg.Name = "lblCaracterMsg";
            this.lblCaracterMsg.Size = new System.Drawing.Size(354, 25);
            this.lblCaracterMsg.TabIndex = 68;
            this.lblCaracterMsg.Text = "Caracters na mensagem: 0 / 200";
            // 
            // lblCaracterTitulo
            // 
            this.lblCaracterTitulo.AutoSize = true;
            this.lblCaracterTitulo.BackColor = System.Drawing.Color.LightGray;
            this.lblCaracterTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterTitulo.Location = new System.Drawing.Point(163, 64);
            this.lblCaracterTitulo.Name = "lblCaracterTitulo";
            this.lblCaracterTitulo.Size = new System.Drawing.Size(280, 25);
            this.lblCaracterTitulo.TabIndex = 66;
            this.lblCaracterTitulo.Text = "Caracters no titulo: 0 / 50";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(143, 304);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 65;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(247, 304);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 43);
            this.btnSair.TabIndex = 64;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTituloEntrada
            // 
            this.txtTituloEntrada.BackColor = System.Drawing.Color.LightGray;
            this.txtTituloEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloEntrada.Location = new System.Drawing.Point(168, 92);
            this.txtTituloEntrada.Name = "txtTituloEntrada";
            this.txtTituloEntrada.Size = new System.Drawing.Size(719, 31);
            this.txtTituloEntrada.TabIndex = 60;
            this.txtTituloEntrada.TextChanged += new System.EventHandler(this.txtTituloEntrada_TextChanged);
            // 
            // txtMsgEntrada
            // 
            this.txtMsgEntrada.BackColor = System.Drawing.Color.LightGray;
            this.txtMsgEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgEntrada.Location = new System.Drawing.Point(168, 129);
            this.txtMsgEntrada.Multiline = true;
            this.txtMsgEntrada.Name = "txtMsgEntrada";
            this.txtMsgEntrada.Size = new System.Drawing.Size(719, 121);
            this.txtMsgEntrada.TabIndex = 62;
            this.txtMsgEntrada.TextChanged += new System.EventHandler(this.txtMsgEntrada_TextChanged);
            this.txtMsgEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsgEntrada_KeyDown);
            // 
            // rdClaroPay
            // 
            this.rdClaroPay.AutoSize = true;
            this.rdClaroPay.Checked = true;
            this.rdClaroPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdClaroPay.Location = new System.Drawing.Point(12, 13);
            this.rdClaroPay.Name = "rdClaroPay";
            this.rdClaroPay.Size = new System.Drawing.Size(191, 29);
            this.rdClaroPay.TabIndex = 75;
            this.rdClaroPay.TabStop = true;
            this.rdClaroPay.Text = "Push Claro pay";
            this.rdClaroPay.UseVisualStyleBackColor = true;
            this.rdClaroPay.CheckedChanged += new System.EventHandler(this.rdClaroPay_CheckedChanged);
            // 
            // rdMinahClaroMovel
            // 
            this.rdMinahClaroMovel.AutoSize = true;
            this.rdMinahClaroMovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdMinahClaroMovel.Location = new System.Drawing.Point(237, 12);
            this.rdMinahClaroMovel.Name = "rdMinahClaroMovel";
            this.rdMinahClaroMovel.Size = new System.Drawing.Size(285, 29);
            this.rdMinahClaroMovel.TabIndex = 76;
            this.rdMinahClaroMovel.Text = "Push minha Claro movel";
            this.rdMinahClaroMovel.UseVisualStyleBackColor = true;
            this.rdMinahClaroMovel.CheckedChanged += new System.EventHandler(this.rdClaroPay_CheckedChanged);
            // 
            // rdClaroResidencial
            // 
            this.rdClaroResidencial.AutoSize = true;
            this.rdClaroResidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdClaroResidencial.Location = new System.Drawing.Point(549, 13);
            this.rdClaroResidencial.Name = "rdClaroResidencial";
            this.rdClaroResidencial.Size = new System.Drawing.Size(338, 29);
            this.rdClaroResidencial.TabIndex = 77;
            this.rdClaroResidencial.Text = "Push minha Claro residencial";
            this.rdClaroResidencial.UseVisualStyleBackColor = true;
            this.rdClaroResidencial.CheckedChanged += new System.EventHandler(this.rdClaroPay_CheckedChanged);
            // 
            // pbPushLogo
            // 
            this.pbPushLogo.Image = global::replace_campanhas.Properties.Resources.unnamed;
            this.pbPushLogo.Location = new System.Drawing.Point(24, 92);
            this.pbPushLogo.Name = "pbPushLogo";
            this.pbPushLogo.Size = new System.Drawing.Size(138, 137);
            this.pbPushLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPushLogo.TabIndex = 73;
            this.pbPushLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::replace_campanhas.Properties.Resources.ProjetoPush4;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(12, 304);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(125, 43);
            this.btnVisualizar.TabIndex = 78;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // frmValidaFrasePushV3Solicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 351);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.rdClaroResidencial);
            this.Controls.Add(this.rdMinahClaroMovel);
            this.Controls.Add(this.rdClaroPay);
            this.Controls.Add(this.pbPushLogo);
            this.Controls.Add(this.lblCaracterMsg);
            this.Controls.Add(this.lblCaracterTitulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTituloEntrada);
            this.Controls.Add(this.txtMsgEntrada);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmValidaFrasePushV3Solicitante";
            this.Text = "Push";
            this.Load += new System.EventHandler(this.frmValidaFrasePushV3Solicitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPushLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPushLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCaracterMsg;
        private System.Windows.Forms.Label lblCaracterTitulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtTituloEntrada;
        private System.Windows.Forms.TextBox txtMsgEntrada;
        private System.Windows.Forms.RadioButton rdClaroPay;
        private System.Windows.Forms.RadioButton rdMinahClaroMovel;
        private System.Windows.Forms.RadioButton rdClaroResidencial;
        private System.Windows.Forms.Button btnVisualizar;
    }
}