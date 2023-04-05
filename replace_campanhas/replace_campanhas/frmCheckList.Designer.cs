namespace replace_campanhas
{
    partial class frmCheckList
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
            this.lblBriefongOs = new System.Windows.Forms.Label();
            this.lblTipoOS = new System.Windows.Forms.Label();
            this.chkClaroPay = new System.Windows.Forms.CheckBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.chkMovel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblBriefongOs
            // 
            this.lblBriefongOs.AutoSize = true;
            this.lblBriefongOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefongOs.Location = new System.Drawing.Point(12, 9);
            this.lblBriefongOs.Name = "lblBriefongOs";
            this.lblBriefongOs.Size = new System.Drawing.Size(132, 25);
            this.lblBriefongOs.TabIndex = 31;
            this.lblBriefongOs.Text = "Briefing OS";
            // 
            // lblTipoOS
            // 
            this.lblTipoOS.AutoSize = true;
            this.lblTipoOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOS.Location = new System.Drawing.Point(34, 51);
            this.lblTipoOS.Name = "lblTipoOS";
            this.lblTipoOS.Size = new System.Drawing.Size(110, 25);
            this.lblTipoOS.TabIndex = 32;
            this.lblTipoOS.Text = "Tipo OS?";
            // 
            // chkClaroPay
            // 
            this.chkClaroPay.AutoSize = true;
            this.chkClaroPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClaroPay.Location = new System.Drawing.Point(150, 55);
            this.chkClaroPay.Name = "chkClaroPay";
            this.chkClaroPay.Size = new System.Drawing.Size(99, 22);
            this.chkClaroPay.TabIndex = 33;
            this.chkClaroPay.Text = "Claro pay";
            this.chkClaroPay.UseVisualStyleBackColor = true;
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(150, 12);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(106, 24);
            this.txtOS.TabIndex = 34;
            // 
            // chkMovel
            // 
            this.chkMovel.AutoSize = true;
            this.chkMovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMovel.Location = new System.Drawing.Point(255, 55);
            this.chkMovel.Name = "chkMovel";
            this.chkMovel.Size = new System.Drawing.Size(72, 22);
            this.chkMovel.TabIndex = 35;
            this.chkMovel.Text = "Movel";
            this.chkMovel.UseVisualStyleBackColor = true;
            // 
            // frmCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 524);
            this.Controls.Add(this.chkMovel);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.chkClaroPay);
            this.Controls.Add(this.lblTipoOS);
            this.Controls.Add(this.lblBriefongOs);
            this.Name = "frmCheckList";
            this.Text = "Checklist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBriefongOs;
        private System.Windows.Forms.Label lblTipoOS;
        private System.Windows.Forms.CheckBox chkClaroPay;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.CheckBox chkMovel;
    }
}