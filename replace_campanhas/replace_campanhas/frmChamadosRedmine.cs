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

namespace replace_campanhas
{
    public partial class frmChamadosRedmine : Form
    {
        private bool interruptor = false;

        public frmChamadosRedmine()
        {
            InitializeComponent();
        }

        private void frmChamadosRedmine_Load(object sender, EventArgs e)
        {
            this.Text = "Chamados redmine";
            rdTelefone.Checked = true;
            //rdNovaTabela.Checked = true;
            this.MaximizeBox = false;

            populaVisaoparaTipo();
            validaTabTipo();

            txtTabelaT1.ReadOnly = true;
            txtCampoT1.ReadOnly = true;
            txtTabelaT2.ReadOnly = false;
            txtCampoT2.ReadOnly = false;

            cbT1.SelectedIndex = 0;
            cbT2.SelectedIndex = 0;
            
            rdContrato.Visible = false;
            rdDomicilio.Visible = false;
            rdEmail.Visible = false;
            rdPessoa.Visible = false;
            rdPMEDomicilio.Visible = false;
            rdPMEPessoaTelefone.Visible = false;
            rdPMEPessoa.Visible = false;

            btnDesabilitaCampos();


        }

        //FUNCOES
        public void btnDesabilitaCampos()
        {
            btnLigaDesliga.Text = "Desabilitado";
            btnLigaDesliga.BackColor = System.Drawing.Color.Red;
            interruptor = false;
        }
        public void populaVisaoparaTipo()
        {
            if (rdTelefone.Checked)
            {
                txtTabelaT1.Text = "AMX.AMX_TELEFONE";
                txtCampoT1.Text = "TELEFONE";
            }    

        }
        public void validaTabTipo()
        {
            if (rdNovaTabela.Checked)
            {
                txtTabelaT1.ReadOnly = true;
                txtCampoT1.ReadOnly = true;
                txtTabelaT2.ReadOnly = false;
                txtCampoT2.ReadOnly = false;

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



            }
            if (rdNovaColuna.Checked)
            {
                txtTabelaT1.Text = "";
                txtCampoT1.Text = "";
                txtTabelaT2.Text = "";
                txtCampoT2.Text = "";

                txtTabelaT1.ReadOnly = false;
                txtCampoT1.ReadOnly = false;
                txtTabelaT2.ReadOnly = true;
                txtCampoT2.ReadOnly = true;

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
                
            }


        }

        public void ProcessarTextoComIntervalo(TextBox textBox)
        {
            if (textBox == null || string.IsNullOrEmpty(textBox.Text))
                return;

            // Converte todo o texto para uppercase
            string textoUpper = textBox.Text.ToUpper();

            // Usa Regex para encontrar "DATE" como palavra inteira (case insensitive já que convertemos para upper)
            string textoProcessado = Regex.Replace(textoUpper, @"\bDATE\b", "DATE INTERVALO");

            // Atualiza o TextBox
            txtColunas.Text = textoProcessado;
        }





    /* MODELO DE CHAMADOS
    Solicito mapeamento de uma nova tabela.
    *Tabela Pai:*
    <pre>
    AMX.TB_PME_SAS T1
    </pre>
    *Tabela Filho:*
    <pre>
    AMX.DB_CLUSTERIZACAO_MOVEL_PME T2
    </pre>
    *PK:*
    <pre>
    T1.NUM_CNPJ = T2.NU_CNPJ
    </pre>
    *Obs:*
    _T1 sem duplicidade
    T2 sem duplicidade
    1 PRA 1
    (X) Nova
    _
    *Colunas:*
    <pre>
    FLAG_ATINGIU_POTENCIAL_MOVEL NUMBER
    FLAG_INSATISFEITO            NUMBER
    </pre>
    *Assunto/Visao:*
    <pre>
    () Contrato
    () Domicilio
    () E-mail
    () Pessoa
    () PME_Pessoa
    () PME_Pessoa_Telefone
    () PME_Domicilio
    (x) Telefone
    </pre>
    *Motivo da necessidade:*
    */

    //BOTOES
    private void btnCarregar_Click(object sender, EventArgs e)
        {
            txtSaidaChamado.Text = string.Empty;

            if (rdNovaTabela.Checked)
            {
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

                var para = "";

                para = cbT1.SelectedItem.ToString() + " PARA " + cbT2.SelectedItem.ToString();

                var visao = "";
                if (rdTelefone.Checked)
                    visao = "(X) Telefone";

                StringBuilder textoFinal = new StringBuilder();

                textoFinal.AppendLine("Solicito mapeamento de uma nova tabela.");
                textoFinal.AppendLine("*Tabela Pai:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtTabelaT1.Text + " T1");
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Tabela Filho:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtTabelaT2.Text + " T2");
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*PK:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine("T1." + txtCampoT1.Text + " = T2." + txtCampoT2.Text);
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Obs:*");
                textoFinal.AppendLine(t1);
                textoFinal.AppendLine(t2);
                textoFinal.AppendLine(para);
                textoFinal.AppendLine("(X) Nova _");
                textoFinal.AppendLine("*Colunas:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtColunas.Text);
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Assunto/Visao:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(visao);
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Motivo da necessidade:*");
                textoFinal.AppendLine(txtMotivo.Text);

                txtSaidaChamado.Text = textoFinal.ToString();
            }

            if (rdNovaColuna.Checked)
            {

                var visao = "";
                if (rdTelefone.Checked)
                    visao = "(X) Telefone";

                StringBuilder textoFinal = new StringBuilder();

                textoFinal.AppendLine("Solicito mapeamento de uma nova coluna.");
                textoFinal.AppendLine("*Tabela Pai:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtTabelaT1.Text + " T1");
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Colunas:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(txtColunas.Text);
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Assunto/Visao:*");
                textoFinal.AppendLine("<pre>");
                textoFinal.AppendLine(visao);
                textoFinal.AppendLine("</pre>");
                textoFinal.AppendLine("*Motivo da necessidade:*");
                textoFinal.AppendLine(txtMotivo.Text);

                txtSaidaChamado.Text = textoFinal.ToString();
            }





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

        private void PopulaCampos(object sender, EventArgs e)
        {
            btnDesabilitaCampos();
            populaVisaoparaTipo();
            validaTabTipo();

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
            btnLigaDesliga.Text = interruptor ? "Habilitado" : "Desabilitado";
            btnLigaDesliga.BackColor = interruptor ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            if (interruptor)
            {
                txtCampoT1.ReadOnly = false;
                txtTabelaT1.ReadOnly = false;
            }
            else
            {
                txtCampoT1.ReadOnly = true;
                txtTabelaT1.ReadOnly = true;
            }

        }


    }
}
