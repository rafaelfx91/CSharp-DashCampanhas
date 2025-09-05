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
    public partial class frmInternalizacaoChamado : Form
    {
        public frmInternalizacaoChamado()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = "Internalizacao de bases";
        }



        /*
        FORMULARIO DE INTERNALIZACAO

        internalização da base TB_MCLAROMOV

        Caros,

        Para atendimento da demanda 97117,97055
        Solicito a internalização da tabela TB_MCLAROMOV@LINK_AMXCARGA_NETMODELO

        A tabela possui campos NUM_NTC, DT_ULT_ACESS_SITE_MCLAROMOV, QTD_DIAS_ACESS_SITE_MCLAROMOV

        trazer apenas os ultimos 90 dias
        */


        /// 
        /// BOTOES
        /// 
        /// 
        /// 
        private void frmInternalizacaoChamado_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //tab tabela
            txtCamposTabela.Clear();
            //txtDias.Clear();
            txtDias.Text = "90";
            //txtMotivo.Clear();
            txtMotivo.Text = "Sera usado nas OSs: ";
            txtTabela.Clear();

            //tab saida
            txtChamado.Clear();
            txtTitulo.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            tbInternalisacao.SelectedTab = tbSaida; // Muda para a aba de saída

            var tabela = txtTabela.Text;

            //textoFinal.AppendLine("Solicito mapeamento de uma nova tabela.");
            //StringBuilder textoFinal = new StringBuilder();
            //titulo
            txtTitulo.Text = "internalização da base "+ tabela;

            //Chamado
            StringBuilder textoFinal = new StringBuilder();
            textoFinal.AppendLine("Caros,");
            textoFinal.AppendLine("");
            textoFinal.AppendLine("Solicito a internalização da tabela: "+tabela);
            textoFinal.AppendLine("");
            textoFinal.AppendLine("A tabela possui campos:");
            textoFinal.AppendLine(txtCamposTabela.Text);
            textoFinal.AppendLine("");
            textoFinal.AppendLine("Motivo da nescesidade:");
            textoFinal.AppendLine(txtMotivo.Text);
            textoFinal.AppendLine("");
            textoFinal.AppendLine("Trazer os ultimos: "+txtDias.Text+" dias");

            txtChamado.Text = textoFinal.ToString();
        }
    }
}
