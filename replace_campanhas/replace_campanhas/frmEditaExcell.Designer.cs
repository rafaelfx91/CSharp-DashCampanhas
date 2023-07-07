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
            this.chkSegundaSexta = new System.Windows.Forms.CheckBox();
            this.chkSegundaSabado = new System.Windows.Forms.CheckBox();
            this.gbDiasDaSemana = new System.Windows.Forms.GroupBox();
            this.gbAgendamento = new System.Windows.Forms.GroupBox();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.chkDiasDeSemanaNove = new System.Windows.Forms.CheckBox();
            this.chkSabadosQuinza = new System.Windows.Forms.CheckBox();
            this.gbObservacoesTriger = new System.Windows.Forms.GroupBox();
            this.txtAmx = new System.Windows.Forms.TextBox();
            this.rdrOSAMX = new System.Windows.Forms.RadioButton();
            this.rdrTBPlataformaSas = new System.Windows.Forms.RadioButton();
            this.rdrTBClaropayCorrentista = new System.Windows.Forms.RadioButton();
            this.gbDiasDaSemana.SuspendLayout();
            this.gbAgendamento.SuspendLayout();
            this.gbHorario.SuspendLayout();
            this.gbObservacoesTriger.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 361);
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
            this.btnSair.Location = new System.Drawing.Point(220, 361);
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
            this.btnGerar.Location = new System.Drawing.Point(12, 361);
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
            this.lblCaminhoArquivo.Location = new System.Drawing.Point(8, 12);
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
            this.rdrPausa.Location = new System.Drawing.Point(4, 70);
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
            this.rdrCancelamento.Location = new System.Drawing.Point(4, 40);
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
            this.rdrAgendamento.Location = new System.Drawing.Point(4, 14);
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
            this.txtListaDeCampanhas.Location = new System.Drawing.Point(12, 182);
            this.txtListaDeCampanhas.Multiline = true;
            this.txtListaDeCampanhas.Name = "txtListaDeCampanhas";
            this.txtListaDeCampanhas.Size = new System.Drawing.Size(776, 173);
            this.txtListaDeCampanhas.TabIndex = 56;
            // 
            // lblListaCampanhas
            // 
            this.lblListaCampanhas.AutoSize = true;
            this.lblListaCampanhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCampanhas.Location = new System.Drawing.Point(12, 159);
            this.lblListaCampanhas.Name = "lblListaCampanhas";
            this.lblListaCampanhas.Size = new System.Drawing.Size(170, 20);
            this.lblListaCampanhas.TabIndex = 57;
            this.lblListaCampanhas.Text = "Lista de campanhas";
            // 
            // chkSegundaSexta
            // 
            this.chkSegundaSexta.AutoSize = true;
            this.chkSegundaSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkSegundaSexta.Location = new System.Drawing.Point(6, 19);
            this.chkSegundaSexta.Name = "chkSegundaSexta";
            this.chkSegundaSexta.Size = new System.Drawing.Size(166, 24);
            this.chkSegundaSexta.TabIndex = 60;
            this.chkSegundaSexta.Text = "Segunda a Sexta";
            this.chkSegundaSexta.UseVisualStyleBackColor = true;
            // 
            // chkSegundaSabado
            // 
            this.chkSegundaSabado.AutoSize = true;
            this.chkSegundaSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkSegundaSabado.Location = new System.Drawing.Point(6, 49);
            this.chkSegundaSabado.Name = "chkSegundaSabado";
            this.chkSegundaSabado.Size = new System.Drawing.Size(182, 24);
            this.chkSegundaSabado.TabIndex = 61;
            this.chkSegundaSabado.Text = "Segunda a Sabado";
            this.chkSegundaSabado.UseVisualStyleBackColor = true;
            // 
            // gbDiasDaSemana
            // 
            this.gbDiasDaSemana.Controls.Add(this.chkSegundaSabado);
            this.gbDiasDaSemana.Controls.Add(this.chkSegundaSexta);
            this.gbDiasDaSemana.Location = new System.Drawing.Point(185, 42);
            this.gbDiasDaSemana.Name = "gbDiasDaSemana";
            this.gbDiasDaSemana.Size = new System.Drawing.Size(198, 109);
            this.gbDiasDaSemana.TabIndex = 62;
            this.gbDiasDaSemana.TabStop = false;
            this.gbDiasDaSemana.Text = "Dias da semana";
            // 
            // gbAgendamento
            // 
            this.gbAgendamento.Controls.Add(this.rdrPausa);
            this.gbAgendamento.Controls.Add(this.rdrAgendamento);
            this.gbAgendamento.Controls.Add(this.rdrCancelamento);
            this.gbAgendamento.Location = new System.Drawing.Point(12, 42);
            this.gbAgendamento.Name = "gbAgendamento";
            this.gbAgendamento.Size = new System.Drawing.Size(170, 109);
            this.gbAgendamento.TabIndex = 63;
            this.gbAgendamento.TabStop = false;
            this.gbAgendamento.Text = "Agendamento";
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.chkSabadosQuinza);
            this.gbHorario.Controls.Add(this.chkDiasDeSemanaNove);
            this.gbHorario.Location = new System.Drawing.Point(392, 42);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(163, 109);
            this.gbHorario.TabIndex = 63;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Horario de execução";
            // 
            // chkDiasDeSemanaNove
            // 
            this.chkDiasDeSemanaNove.AutoSize = true;
            this.chkDiasDeSemanaNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkDiasDeSemanaNove.Location = new System.Drawing.Point(6, 19);
            this.chkDiasDeSemanaNove.Name = "chkDiasDeSemanaNove";
            this.chkDiasDeSemanaNove.Size = new System.Drawing.Size(147, 24);
            this.chkDiasDeSemanaNove.TabIndex = 62;
            this.chkDiasDeSemanaNove.Text = "09:00 as 21:00";
            this.chkDiasDeSemanaNove.UseVisualStyleBackColor = true;
            // 
            // chkSabadosQuinza
            // 
            this.chkSabadosQuinza.AutoSize = true;
            this.chkSabadosQuinza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkSabadosQuinza.Location = new System.Drawing.Point(6, 49);
            this.chkSabadosQuinza.Name = "chkSabadosQuinza";
            this.chkSabadosQuinza.Size = new System.Drawing.Size(147, 24);
            this.chkSabadosQuinza.TabIndex = 63;
            this.chkSabadosQuinza.Text = "09:00 as 15:00";
            this.chkSabadosQuinza.UseVisualStyleBackColor = true;
            // 
            // gbObservacoesTriger
            // 
            this.gbObservacoesTriger.Controls.Add(this.txtAmx);
            this.gbObservacoesTriger.Controls.Add(this.rdrOSAMX);
            this.gbObservacoesTriger.Controls.Add(this.rdrTBPlataformaSas);
            this.gbObservacoesTriger.Controls.Add(this.rdrTBClaropayCorrentista);
            this.gbObservacoesTriger.Location = new System.Drawing.Point(561, 44);
            this.gbObservacoesTriger.Name = "gbObservacoesTriger";
            this.gbObservacoesTriger.Size = new System.Drawing.Size(227, 109);
            this.gbObservacoesTriger.TabIndex = 64;
            this.gbObservacoesTriger.TabStop = false;
            this.gbObservacoesTriger.Text = "Triger";
            // 
            // txtAmx
            // 
            this.txtAmx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmx.Location = new System.Drawing.Point(26, 70);
            this.txtAmx.Name = "txtAmx";
            this.txtAmx.ReadOnly = true;
            this.txtAmx.Size = new System.Drawing.Size(195, 22);
            this.txtAmx.TabIndex = 51;
            // 
            // rdrOSAMX
            // 
            this.rdrOSAMX.AutoSize = true;
            this.rdrOSAMX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrOSAMX.Location = new System.Drawing.Point(6, 74);
            this.rdrOSAMX.Name = "rdrOSAMX";
            this.rdrOSAMX.Size = new System.Drawing.Size(14, 13);
            this.rdrOSAMX.TabIndex = 50;
            this.rdrOSAMX.UseVisualStyleBackColor = true;
            this.rdrOSAMX.CheckedChanged += new System.EventHandler(this.rdrOSAMX_CheckedChanged);
            // 
            // rdrTBPlataformaSas
            // 
            this.rdrTBPlataformaSas.AutoSize = true;
            this.rdrTBPlataformaSas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrTBPlataformaSas.Location = new System.Drawing.Point(6, 45);
            this.rdrTBPlataformaSas.Name = "rdrTBPlataformaSas";
            this.rdrTBPlataformaSas.Size = new System.Drawing.Size(155, 24);
            this.rdrTBPlataformaSas.TabIndex = 49;
            this.rdrTBPlataformaSas.Text = "Plataforma SAS";
            this.rdrTBPlataformaSas.UseVisualStyleBackColor = true;
            // 
            // rdrTBClaropayCorrentista
            // 
            this.rdrTBClaropayCorrentista.AutoSize = true;
            this.rdrTBClaropayCorrentista.Checked = true;
            this.rdrTBClaropayCorrentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrTBClaropayCorrentista.Location = new System.Drawing.Point(6, 19);
            this.rdrTBClaropayCorrentista.Name = "rdrTBClaropayCorrentista";
            this.rdrTBClaropayCorrentista.Size = new System.Drawing.Size(144, 24);
            this.rdrTBClaropayCorrentista.TabIndex = 48;
            this.rdrTBClaropayCorrentista.TabStop = true;
            this.rdrTBClaropayCorrentista.Text = "CP Correntista";
            this.rdrTBClaropayCorrentista.UseVisualStyleBackColor = true;
            // 
            // frmEditaExcell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.gbObservacoesTriger);
            this.Controls.Add(this.gbHorario);
            this.Controls.Add(this.gbAgendamento);
            this.Controls.Add(this.gbDiasDaSemana);
            this.Controls.Add(this.lblListaCampanhas);
            this.Controls.Add(this.txtListaDeCampanhas);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.lblCaminhoArquivo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Name = "frmEditaExcell";
            this.Text = "Gerador de excell";
            this.Load += new System.EventHandler(this.frmEditaExcell_Load);
            this.gbDiasDaSemana.ResumeLayout(false);
            this.gbDiasDaSemana.PerformLayout();
            this.gbAgendamento.ResumeLayout(false);
            this.gbAgendamento.PerformLayout();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbObservacoesTriger.ResumeLayout(false);
            this.gbObservacoesTriger.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkSegundaSexta;
        private System.Windows.Forms.CheckBox chkSegundaSabado;
        private System.Windows.Forms.GroupBox gbDiasDaSemana;
        private System.Windows.Forms.GroupBox gbAgendamento;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.CheckBox chkDiasDeSemanaNove;
        private System.Windows.Forms.CheckBox chkSabadosQuinza;
        private System.Windows.Forms.GroupBox gbObservacoesTriger;
        private System.Windows.Forms.TextBox txtAmx;
        private System.Windows.Forms.RadioButton rdrOSAMX;
        private System.Windows.Forms.RadioButton rdrTBPlataformaSas;
        private System.Windows.Forms.RadioButton rdrTBClaropayCorrentista;
    }
}