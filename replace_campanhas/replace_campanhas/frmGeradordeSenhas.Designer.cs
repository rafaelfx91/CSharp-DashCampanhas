namespace replace_campanhas
{
    partial class frmGeradordeSenhas
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenosQuantiadesenhasgeradas = new System.Windows.Forms.Button();
            this.btnmaisQuantiadesenhasgeradas = new System.Windows.Forms.Button();
            this.txtQuantiadeSenhasgeradas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.txtTamanhosenha = new System.Windows.Forms.TextBox();
            this.chkCaracteresespeciais = new System.Windows.Forms.CheckBox();
            this.txtCaracteresespeciais = new System.Windows.Forms.TextBox();
            this.chkLetrasmaiusculas = new System.Windows.Forms.CheckBox();
            this.txtLetrasmaiusculas = new System.Windows.Forms.TextBox();
            this.chkLetrasminusculas = new System.Windows.Forms.CheckBox();
            this.txtLetrasminusculas = new System.Windows.Forms.TextBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(14, 225);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(432, 111);
            this.txtSenha.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Quantidade de senhas";
            // 
            // btnMenosQuantiadesenhasgeradas
            // 
            this.btnMenosQuantiadesenhasgeradas.Location = new System.Drawing.Point(245, 189);
            this.btnMenosQuantiadesenhasgeradas.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenosQuantiadesenhasgeradas.Name = "btnMenosQuantiadesenhasgeradas";
            this.btnMenosQuantiadesenhasgeradas.Size = new System.Drawing.Size(37, 26);
            this.btnMenosQuantiadesenhasgeradas.TabIndex = 45;
            this.btnMenosQuantiadesenhasgeradas.Text = "-";
            this.btnMenosQuantiadesenhasgeradas.UseVisualStyleBackColor = true;
            this.btnMenosQuantiadesenhasgeradas.Click += new System.EventHandler(this.btnMenosQuantiadesenhasgeradas_Click);
            // 
            // btnmaisQuantiadesenhasgeradas
            // 
            this.btnmaisQuantiadesenhasgeradas.Location = new System.Drawing.Point(409, 189);
            this.btnmaisQuantiadesenhasgeradas.Margin = new System.Windows.Forms.Padding(5);
            this.btnmaisQuantiadesenhasgeradas.Name = "btnmaisQuantiadesenhasgeradas";
            this.btnmaisQuantiadesenhasgeradas.Size = new System.Drawing.Size(37, 26);
            this.btnmaisQuantiadesenhasgeradas.TabIndex = 44;
            this.btnmaisQuantiadesenhasgeradas.Text = "+";
            this.btnmaisQuantiadesenhasgeradas.UseVisualStyleBackColor = true;
            this.btnmaisQuantiadesenhasgeradas.Click += new System.EventHandler(this.btnmaisQuantiadesenhasgeradas_Click);
            // 
            // txtQuantiadeSenhasgeradas
            // 
            this.txtQuantiadeSenhasgeradas.Location = new System.Drawing.Point(292, 189);
            this.txtQuantiadeSenhasgeradas.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantiadeSenhasgeradas.Name = "txtQuantiadeSenhasgeradas";
            this.txtQuantiadeSenhasgeradas.ReadOnly = true;
            this.txtQuantiadeSenhasgeradas.Size = new System.Drawing.Size(107, 26);
            this.txtQuantiadeSenhasgeradas.TabIndex = 43;
            this.txtQuantiadeSenhasgeradas.Text = "1";
            this.txtQuantiadeSenhasgeradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tamanho da senha";
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(20, 189);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(37, 26);
            this.btnMenos.TabIndex = 41;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(188, 189);
            this.btnMais.Margin = new System.Windows.Forms.Padding(5);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(37, 26);
            this.btnMais.TabIndex = 40;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // txtTamanhosenha
            // 
            this.txtTamanhosenha.Location = new System.Drawing.Point(71, 189);
            this.txtTamanhosenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtTamanhosenha.Name = "txtTamanhosenha";
            this.txtTamanhosenha.ReadOnly = true;
            this.txtTamanhosenha.Size = new System.Drawing.Size(107, 26);
            this.txtTamanhosenha.TabIndex = 39;
            this.txtTamanhosenha.Text = "25";
            this.txtTamanhosenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkCaracteresespeciais
            // 
            this.chkCaracteresespeciais.AutoSize = true;
            this.chkCaracteresespeciais.Location = new System.Drawing.Point(253, 86);
            this.chkCaracteresespeciais.Margin = new System.Windows.Forms.Padding(5);
            this.chkCaracteresespeciais.Name = "chkCaracteresespeciais";
            this.chkCaracteresespeciais.Size = new System.Drawing.Size(196, 24);
            this.chkCaracteresespeciais.TabIndex = 38;
            this.chkCaracteresespeciais.Text = "Caracteres especiais";
            this.chkCaracteresespeciais.UseVisualStyleBackColor = true;
            // 
            // txtCaracteresespeciais
            // 
            this.txtCaracteresespeciais.Location = new System.Drawing.Point(245, 122);
            this.txtCaracteresespeciais.Margin = new System.Windows.Forms.Padding(5);
            this.txtCaracteresespeciais.Name = "txtCaracteresespeciais";
            this.txtCaracteresespeciais.Size = new System.Drawing.Size(201, 26);
            this.txtCaracteresespeciais.TabIndex = 37;
            this.txtCaracteresespeciais.Text = "!@#$%&";
            // 
            // chkLetrasmaiusculas
            // 
            this.chkLetrasmaiusculas.AutoSize = true;
            this.chkLetrasmaiusculas.Checked = true;
            this.chkLetrasmaiusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetrasmaiusculas.Location = new System.Drawing.Point(253, 12);
            this.chkLetrasmaiusculas.Margin = new System.Windows.Forms.Padding(5);
            this.chkLetrasmaiusculas.Name = "chkLetrasmaiusculas";
            this.chkLetrasmaiusculas.Size = new System.Drawing.Size(173, 24);
            this.chkLetrasmaiusculas.TabIndex = 36;
            this.chkLetrasmaiusculas.Text = "Letras maiusculas";
            this.chkLetrasmaiusculas.UseVisualStyleBackColor = true;
            // 
            // txtLetrasmaiusculas
            // 
            this.txtLetrasmaiusculas.Location = new System.Drawing.Point(245, 46);
            this.txtLetrasmaiusculas.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetrasmaiusculas.Name = "txtLetrasmaiusculas";
            this.txtLetrasmaiusculas.ReadOnly = true;
            this.txtLetrasmaiusculas.Size = new System.Drawing.Size(201, 26);
            this.txtLetrasmaiusculas.TabIndex = 35;
            this.txtLetrasmaiusculas.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // chkLetrasminusculas
            // 
            this.chkLetrasminusculas.AutoSize = true;
            this.chkLetrasminusculas.Checked = true;
            this.chkLetrasminusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetrasminusculas.Location = new System.Drawing.Point(20, 86);
            this.chkLetrasminusculas.Margin = new System.Windows.Forms.Padding(5);
            this.chkLetrasminusculas.Name = "chkLetrasminusculas";
            this.chkLetrasminusculas.Size = new System.Drawing.Size(173, 24);
            this.chkLetrasminusculas.TabIndex = 34;
            this.chkLetrasminusculas.Text = "Letras minusculas";
            this.chkLetrasminusculas.UseVisualStyleBackColor = true;
            // 
            // txtLetrasminusculas
            // 
            this.txtLetrasminusculas.Location = new System.Drawing.Point(20, 122);
            this.txtLetrasminusculas.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetrasminusculas.Name = "txtLetrasminusculas";
            this.txtLetrasminusculas.ReadOnly = true;
            this.txtLetrasminusculas.Size = new System.Drawing.Size(205, 26);
            this.txtLetrasminusculas.TabIndex = 33;
            this.txtLetrasminusculas.Text = "abcdefghijklmnopqrstuvwxyz";
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Checked = true;
            this.chkNumeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumeros.Location = new System.Drawing.Point(20, 12);
            this.chkNumeros.Margin = new System.Windows.Forms.Padding(5);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(99, 24);
            this.chkNumeros.TabIndex = 32;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(20, 46);
            this.txtNumeros.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ReadOnly = true;
            this.txtNumeros.Size = new System.Drawing.Size(205, 26);
            this.txtNumeros.TabIndex = 31;
            this.txtNumeros.Text = "1234567890";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(118, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(222, 344);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 49;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(14, 344);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 43);
            this.btnGerar.TabIndex = 48;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // frmGeradordeSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenosQuantiadesenhasgeradas);
            this.Controls.Add(this.btnmaisQuantiadesenhasgeradas);
            this.Controls.Add(this.txtQuantiadeSenhasgeradas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.txtTamanhosenha);
            this.Controls.Add(this.chkCaracteresespeciais);
            this.Controls.Add(this.txtCaracteresespeciais);
            this.Controls.Add(this.chkLetrasmaiusculas);
            this.Controls.Add(this.txtLetrasmaiusculas);
            this.Controls.Add(this.chkLetrasminusculas);
            this.Controls.Add(this.txtLetrasminusculas);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGeradordeSenhas";
            this.Text = "Gerador de senhas";
            this.Load += new System.EventHandler(this.frmGeradordeSenhas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMenosQuantiadesenhasgeradas;
        private System.Windows.Forms.Button btnmaisQuantiadesenhasgeradas;
        private System.Windows.Forms.TextBox txtQuantiadeSenhasgeradas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox txtTamanhosenha;
        private System.Windows.Forms.CheckBox chkCaracteresespeciais;
        private System.Windows.Forms.TextBox txtCaracteresespeciais;
        private System.Windows.Forms.CheckBox chkLetrasmaiusculas;
        private System.Windows.Forms.TextBox txtLetrasmaiusculas;
        private System.Windows.Forms.CheckBox chkLetrasminusculas;
        private System.Windows.Forms.TextBox txtLetrasminusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
    }
}