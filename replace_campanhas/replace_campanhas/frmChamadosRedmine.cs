using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmChamadosRedmine : Form
    {
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
            txtTabelaT2.ReadOnly = true;
            txtCampoT2.ReadOnly = true;

            cbT1.SelectedIndex = 0;
            cbT2.SelectedIndex = 0;
            
            
            

        }

        //FUNCOES

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

            }


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

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulaCampos(object sender, EventArgs e)
        {
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
    }
}
