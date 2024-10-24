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
    public partial class frmAgendamentoCampanhaJira : Form
    {
        //private FuncoesDeveloper fd = new FuncoesDeveloper();
        private FuncoesDeveloper fd;
        FuncoesDiversas fdiversas = new FuncoesDiversas();

        public frmAgendamentoCampanhaJira()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public frmAgendamentoCampanhaJira(FuncoesDeveloper fd)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.fd = fd;
        }

        private void frmAgendamentoCampanhaJira_Load(object sender, EventArgs e)
        {
            setBoasVindas();
            if (fd.validaConfigsDev3())
                chkDev.Visible = true;
            txtTituloEmail.Visible = false;
            lblAssuntoEmail.Visible = false;
            
        }

        public void setBoasVindas()
        {
            var bv = fdiversas.setBoasVindas(DateTime.Now.ToString("HH"));

            if (bv == 0)
                rdrBomdia.Checked = true;
            if (bv == 1)
                rdrBoatarde.Checked = true;
            if (bv == 2)
                rdrBoanoite.Checked = true;

        }








        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAmx.Clear();
            txtSaida.Clear();
            txtTituloEmail.Clear();
            txtCorpoEmail.Clear();
            setBoasVindas();
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            var boasVindas = String.Empty;

            if (rdrBomdia.Checked)
                boasVindas = "Bom dia!";
            if (rdrBoatarde.Checked)
                boasVindas = "Boa tarde!";
            if (rdrBoanoite.Checked)
                boasVindas = "Bboa noite!";

            var agendamento = String.Empty;

            if (rdrAgendamento.Checked)
                agendamento = "agendamento";
            if (rdrCancelamento.Checked)
                agendamento = "cancelamento";
            if (rdrPausa.Checked)
                agendamento = "pausa";
            if (rdrAlteracao.Checked)
                agendamento = "alteracao";

            var listAmx = txtAmx.Text;
                 
            txtSaida.Text = boasVindas + "\r\n" +
                            "Solicito o " + agendamento + " das campanhas:\r\n" +
                            listAmx + "\r\n" +
                            "Conforme o aruqivo em anexo, Obrigado";

            txtCorpoEmail.Text = "Prezados,\r\n" +
                                 "Segue solicitação de " + agendamento + " das campanhas";
            
            if (chkDev.Checked)
                txtTituloEmail.Text = txtTituloEmail.Text.Replace("/", ": ");
      
        }
        private void txtCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSaida.Text);
        }

        private void chkDev_CheckedChanged(object sender, EventArgs e)
        {
            txtTituloEmail.Visible = true;
            lblAssuntoEmail.Visible = true;
        }
    }
}
