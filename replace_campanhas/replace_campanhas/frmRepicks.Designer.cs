namespace replace_campanhas
{
    partial class frmRepicks
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
            this.chkListaRepicks = new System.Windows.Forms.CheckedListBox();
            this.chkRepicksHoje = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkListaRepicks
            // 
            this.chkListaRepicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkListaRepicks.FormattingEnabled = true;
            this.chkListaRepicks.Location = new System.Drawing.Point(12, 32);
            this.chkListaRepicks.Name = "chkListaRepicks";
            this.chkListaRepicks.Size = new System.Drawing.Size(371, 361);
            this.chkListaRepicks.TabIndex = 0;
            // 
            // chkRepicksHoje
            // 
            this.chkRepicksHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkRepicksHoje.FormattingEnabled = true;
            this.chkRepicksHoje.Location = new System.Drawing.Point(389, 32);
            this.chkRepicksHoje.Name = "chkRepicksHoje";
            this.chkRepicksHoje.Size = new System.Drawing.Size(399, 361);
            this.chkRepicksHoje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de repicks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repicks de hj";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(389, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 69;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(285, 399);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(98, 43);
            this.btnAbrir.TabIndex = 70;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmRepicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRepicksHoje);
            this.Controls.Add(this.chkListaRepicks);
            this.Name = "frmRepicks";
            this.Text = "frmRepicks";
            this.Load += new System.EventHandler(this.frmRepicks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListaRepicks;
        private System.Windows.Forms.CheckedListBox chkRepicksHoje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAbrir;
    }
}