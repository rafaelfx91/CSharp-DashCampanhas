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
    public partial class frmGerarEmailDiagrama : Form
    {
        FuncoesDiversas fdiversas = new FuncoesDiversas();

        public frmGerarEmailDiagrama()
        {
            InitializeComponent();
        }

        private void frmGerarEmailDiagrama_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            setBoasVindas();
           
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

            //try
            //{
            //    var horas = int.Parse(hora);
            //    if ((horas >= 00) && (horas < 12))
            //        rdrBomdia.Checked = true;
            //    if ((horas >= 12) && (horas < 19))
            //        rdrBoatarde.Checked = true;
            //    if ((horas >= 19) && (horas < 00))
            //        rdrBoanoite.Checked = true;
            //}
            //catch (Exception ex)
            //{
            //    rdrBoanoite.Checked = true;
            //}
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

            var Solicitante = String.Empty;

            if (chkJessica.Checked)
                Solicitante = "Jessica";            
            if (chkCarol.Checked)
                Solicitante = "Carol";            
            if (chkBarbara.Checked)
                Solicitante = "Barbara";            
            if (chkCamila.Checked)
                Solicitante = "Camila";

            var SolicitanteEmail = String.Empty;

            if (chkEmailJessica.Checked)
                SolicitanteEmail += "jessica.vissirini.terceiros@claro.com.br;";
            if (chkEmailCarol.Checked)
                SolicitanteEmail += "caroline.csantos@claro.com.br;";
            if (chkEmailBarbara.Checked)
                SolicitanteEmail += "barbara.noguchi@claro.com.br;";
            if (chkEmailCamila.Checked)
                SolicitanteEmail += "camila.corrales@claro.com.br;";

            var disparo = String.Empty;

            if (chkPush.Checked)
                disparo = " disparo de push,";
            if (chkEmail.Checked)
                disparo = " disparo de email, ";
            if (chkSms.Checked)
                disparo = " disparo de sms, ";

            txtEmalSaida.Text = SolicitanteEmail;

            var mensagemSaida = boasVindas + " "+ Solicitante+" tudo bem ?"+
                                "\r\n"+
                                "Segue diagrama, " +disparo+" em anexo para aprovação";

            txtSaida.Text = mensagemSaida;


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmalSaida.Clear();
            txtSaida.Clear();
            chkJessica.Checked = false;
            chkCarol.Checked = false;
            chkBarbara.Checked = false;
            chkCamila.Checked = false;
            chkEmailJessica.Checked = false;
            chkEmailCarol.Checked = false;
            chkEmailBarbara.Checked = false;
            chkEmailCamila.Checked = false;
            chkPush.Checked = false;
            chkEmail.Checked = false;
            chkSms.Checked = false;
        }
    }
}
