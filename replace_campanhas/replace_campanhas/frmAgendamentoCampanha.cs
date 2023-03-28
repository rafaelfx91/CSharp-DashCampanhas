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
    public partial class frmAgendamentoCampanha : Form
    {
        public frmAgendamentoCampanha()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAmx.Clear();
            txtChamado.Clear();
            txtNumeroChamado.Clear();
            txtAssuntoEmail.Clear();
            txtTituloEmail.Clear();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var amx = txtAmx.Text;
            var numeroChamado = txtNumeroChamado.Text;
            var osTipo = "";

            if (chkInclusao.Checked)
                osTipo += " Inclusao";
            if (chkHold.Checked)
                osTipo += " Holding";
            if (chkCancelamento.Checked)
                osTipo += " Cancelamento";

            var tituloEmail = "Abertura de chamado " + numeroChamado + " - " + osTipo;
            var assuntoEmail = "";
            var chamado = "";

            if (rdrBomdia.Checked)
            {
                assuntoEmail = @"Bom dia caros tudo bem? ";
                chamado = @"Bom dia caros tudo bem? ";
            }
            if (rdrBoatarde.Checked)
            {
                assuntoEmail = @"Boa tarde caros tudo bem? ";
                chamado = @"Boa tarde caros tudo bem? ";
            }
            if (rdrBoanoite.Checked)
            {
                assuntoEmail = @"Boa noite caros tudo bem? ";
                chamado = @"Boa noite caros tudo bem? ";
            }

            assuntoEmail += System.Environment.NewLine;
            assuntoEmail += "Foi feita a abertura de chamado para " + osTipo + " da OS " + txtAmx.Text;
            assuntoEmail += System.Environment.NewLine;
            assuntoEmail += "Gratidao";

            chamado += @",Gostaria de fazer uam solicitação, favor " + osTipo + " as OS "
                        + txtAmx.Text + " no Shedule conforme ao aquivo anexado, Obrigado";



            txtTituloEmail.Text = tituloEmail;
            txtAssuntoEmail.Text = assuntoEmail;
            txtChamado.Text = chamado;
        }

        private void frmAgendamentoCampanha_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
