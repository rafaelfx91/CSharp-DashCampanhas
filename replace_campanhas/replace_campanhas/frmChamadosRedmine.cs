using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using SixLabors.ImageSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace replace_campanhas
{
    public partial class frmChamadosRedmine : Form
    {
        private bool interruptor = false;

        public frmChamadosRedmine()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void frmChamadosRedmine_Load(object sender, EventArgs e)
        {
            this.Text = "Chamados redmine";
            rdTelefone.Checked = true;
            //rdNovaTabela.Checked = true;
            
            populaVisaoparaTipo();
            validaTabTipo();

            txtTabelaT1.ReadOnly = true;
            txtCampoT1.ReadOnly = true;
            txtCampo2T1.ReadOnly = true;

            txtTabelaT2.ReadOnly = false;
            txtCampoT2.ReadOnly = false;

            cbT1.SelectedIndex = 0;
            cbT2.SelectedIndex = 0;
            
            //rdContrato.Visible = false;
            rdDomicilio.Visible = false;
            rdEmail.Visible = false;
            rdPessoa.Visible = false;
            rdPMEDomicilio.Visible = false;
            rdPMEPessoaTelefone.Visible = false;
            rdPMEPessoa.Visible = false;

            btnDesabilitaCampos();


        }

        //FUNCOES
        ///
        /// Botao de habilitar o campo ja vindo desabilitado por padrao
        ///
        public void btnDesabilitaCampos()
        {
            btnLigaDesliga.Text = "Off";
            btnLigaDesliga.BackColor = System.Drawing.Color.Red;
            interruptor = false;
        }

        /// 
        /// Verifica a visao que esta  selecionada para fazer o preenchimento dos campos
        ///
        public void populaVisaoparaTipo() //na troca de aba popula os campos de acordo com a visao
        {
            if (rdTelefone.Checked)
            {
                txtTabelaT1.Text = "AMX.AMX_TELEFONE";
                txtCampoT1.Text = "TELEFONE";
                txtCampo2T1.Visible = false;
                txtCampo2T2.Visible = false;
                lblCampo2T1.Visible = false;
                lblT1Dot2.Visible = false;
                lblCampo2T2.Visible=false;
                lblT2Dot2.Visible = false;
            }
            if (rdContrato.Checked)
            {
                txtTabelaT1.Text = "AMX.AMX_CONTRATO";
                txtCampoT1.Text = "CD_OPERADORA";
                txtCampo2T1.Text = "CD_CONTRATO";
                txtCampo2T1.Visible = true;
                txtCampo2T2.Visible = true;
                lblCampo2T1.Visible = true;
                lblT1Dot2.Visible = true;
                lblCampo2T2.Visible = true;
                lblT2Dot2.Visible = true;
            }


        }

        /// 
        /// Radio button de nova tabela e nova coluna
        /// Caso for nova tabela ele libera os campos para a nova tabela  
        /// se nao se for a nova coluna habilita um campo apnas
        ///
        public void validaTabTipo()
        {
            if (rdNovaTabela.Checked)
            {
                txtTabelaT1.ReadOnly = true;
                txtCampoT1.ReadOnly = true;
                txtCampo2T1.ReadOnly = true;
                txtTabelaT2.ReadOnly = false;
                txtCampoT2.ReadOnly = false;
                lblEditCampos.Visible = true;
                txtTabelaT2.Visible = true;
                txtCampoT2.Visible = true;
                txtTabelaT2.Visible = true;
                txtCampoT2.Visible = true;
                lblTabelaT2.Visible = true;
                lblCampoT2.Visible = true;
                lblTabelaT2.Visible = true;
                lblCampoT2.Visible = true;
                lblT2Dot.Visible = true;
                lblT2.Visible = true;
                chkT1.Visible = true;
                chkT2.Visible = true;
                cbT1.Visible = true;
                cbT2.Visible = true;
                lblPara.Visible = true;
                lblObs.Visible = true;
                lblCampoT1.Visible = true;
                lblT1Dot.Visible = true;
                txtCampoT1.Visible = true;
                btnLigaDesliga.Visible = true;
                if (rdContrato.Checked)
                {
                    txtCampo2T1.Visible = true;
                    txtCampo2T2.Visible = true;
                    lblCampo2T1.Visible = true;
                    lblT1Dot2.Visible = true;
                    lblCampo2T2.Visible = true;
                    lblT2Dot2.Visible = true;
                }
            }
            if (rdNovaColuna.Checked)
            {
                txtTabelaT1.ReadOnly = false;
                txtCampoT1.ReadOnly = false;
                txtTabelaT2.ReadOnly = true;
                txtCampoT2.ReadOnly = true;
                lblEditCampos.Visible = false;
                txtTabelaT2.Visible = false;
                txtCampoT2.Visible = false;
                lblTabelaT2.Visible = false;
                lblCampoT2.Visible = false;
                lblTabelaT2.Visible = false;
                lblCampoT2.Visible = false;
                lblT2Dot.Visible = false;
                lblT2.Visible = false;
                chkT1.Visible = false;
                chkT2.Visible = false;
                cbT1.Visible = false;
                cbT2.Visible = false;
                lblPara.Visible = false;
                lblObs.Visible = false; 
                lblCampoT1.Visible = false;
                lblT1Dot.Visible = false;
                txtCampoT1.Visible = false;
                btnLigaDesliga.Visible = false;
                txtCampo2T1.Visible = false;
                txtCampo2T2.Visible = false;
                lblCampo2T1.Visible = false;
                lblT1Dot2.Visible = false;
                lblCampo2T2.Visible = false;
                lblT2Dot2.Visible = false;
            }


        }

        /// 
        /// Funcao para tratar o texto dos campos deixando tudo como upper 
        /// passa o textbox dos campos como parametro e dentro dele faz a validacao 
        /// 
        /// 
        public void ProcessarTextoComIntervalo(System.Windows.Forms.TextBox textBox)
        {
            if (textBox == null || string.IsNullOrEmpty(textBox.Text))
                return;

            string texto = textBox.Text.ToUpper();

            // Usa Regex com negative lookahead para evitar duplicação
            string pattern = @"\bDATE\b(?!\s*INTERVALO)";
            string textoProcessado = Regex.Replace(texto, pattern, "DATE INTERVALO");

            txtColunas.Text = textoProcessado;
        }
        public string retornoVisao()
        {
            if (rdTelefone.Checked)
                return "(X) Telefone";
            if (rdContrato.Checked)
                return "(X) Contrato";
            
            return "";
        }




        //BOTOES
        /// 
        /// FUNCAO que pospula os campos usada nos botoes
        /// 
        /// 
        /// 
        private void PopulaCampos(object sender, EventArgs e)
        {
            btnDesabilitaCampos();
            populaVisaoparaTipo();
            validaTabTipo();

        }

        /// 
        /// Botao de gerar o chaamdo
        /// 
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //limpa a saida do chamados
            txtSaidaChamado.Text = string.Empty;

            if (rdNovaTabela.Checked)
            {

                //Campo observacoes T1 T2 suplicidade
                var t1 = "";
                var t2 = "";

                if (chkT1.Checked)
                    t1 = chkT1.Text;
                else
                    t1 = chkT1.Text;

                if (chkT2.Checked)
                    t2 = chkT2.Text;
                else
                    t2 = chkT2.Text;

                //Campo observacoes 1 para n
                var para = "";
                para = cbT1.SelectedItem.ToString() + " PARA " + cbT2.SelectedItem.ToString();

                //Valida a visao que esta selecionada
                var visao = retornoVisao();

                StringBuilder textoFinal = new StringBuilder();
                //Chamado completo
                textoFinal.AppendLine("Solicito mapeamento de uma nova tabela.");
                textoFinal.AppendLine("*Tabela Pai:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtTabelaT1.Text.ToUpper() + " T1");//campo da tabela t1
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Tabela Filho:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtTabelaT2.Text.ToUpper() + " T2");//campo tabela t2
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*PK:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine("T1." + txtCampoT1.Text.ToUpper() + " = T2." + txtCampoT2.Text.ToUpper()); //campo 1
                if (rdContrato.Checked)                
                    textoFinal.AppendLine("T1." + txtCampo2T1.Text.ToUpper() + " = T2." + txtCampo2T2.Text.ToUpper()); //campo 2                
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Obs:*");
                textoFinal.AppendLine("_"+t1.ToUpper());
                textoFinal.AppendLine(t2.ToUpper());
                textoFinal.AppendLine(para.ToUpper());
                textoFinal.AppendLine("(X) Nova _");
                textoFinal.AppendLine("*Colunas:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtColunas.Text);
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Assunto/Visao:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(visao.ToUpper());
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Motivo da necessidade:*");
                textoFinal.AppendLine(txtMotivo.Text);

                txtSaidaChamado.Text = textoFinal.ToString();
            }// (rdNovaTabela.Checked)

            if (rdNovaColuna.Checked)
            {
                var visao = retornoVisao();

                StringBuilder textoFinal = new StringBuilder();

                textoFinal.AppendLine("Solicito mapeamento de uma nova coluna.");
                textoFinal.AppendLine("*Tabela Pai:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtTabelaT1.Text.ToUpper() + " T1");
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Colunas:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtColunas.Text.ToUpper());
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Assunto/Visao:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(visao.ToUpper());
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Motivo da necessidade:*");
                textoFinal.AppendLine(txtMotivo.Text.ToUpper());

                txtSaidaChamado.Text = textoFinal.ToString();

            }// (rdNovaColuna.Checked)
       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSaidaChamado.Clear();
            txtCampoT2.Clear();
            txtTabelaT2.Clear();
            txtMotivo.Clear();
            txtColunas.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trocaStatusT1(object sender, EventArgs e)
        {
            if (chkT1.Checked)
                chkT1.Text = "T1 com duplicidade";
            else 
                chkT1.Text = "T1 sem duplicidade";
        }

        private void trocaStatusT2(object sender, EventArgs e)
        {
            if (chkT2.Checked)
                chkT2.Text = "T2 com duplicidade";
            else
                chkT2.Text = "T2 sem duplicidade";
        }

        private void validaColuns(object sender, KeyEventArgs e)
        {

        }

        private void btnValidaColunas_Click(object sender, EventArgs e)
        {
            ProcessarTextoComIntervalo(txtColunas);
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            interruptor = !interruptor;
            btnLigaDesliga.Text = interruptor ? "On" : "Off";
            btnLigaDesliga.BackColor = interruptor ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            if (interruptor)
            {
                txtTabelaT1.ReadOnly = false;
                txtCampoT1.ReadOnly = false;
                txtCampo2T1.ReadOnly = false;
            }
            else
            {
                txtTabelaT1.ReadOnly = true;
                txtCampoT1.ReadOnly = true;
                txtCampo2T1.ReadOnly = true;
            }

        }
        /// 
        /// FUNCAO que pospula os campos usada nos botoes
        /// 
        /// 
        /// 
        private void PopulaCampos(object sender, MouseEventArgs e)
        {
            btnDesabilitaCampos();
            populaVisaoparaTipo();
            validaTabTipo();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSaidaChamado.Text);
        }
    }
}
