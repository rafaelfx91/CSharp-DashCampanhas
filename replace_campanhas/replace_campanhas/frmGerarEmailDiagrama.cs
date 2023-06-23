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
        public frmGerarEmailDiagrama()
        {
            InitializeComponent();
        }

        private void frmGerarEmailDiagrama_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            setBoasVindas(DateTime.Now.ToString("HH"));
        }

        public void setBoasVindas(string hora)
        {
            try
            {
                var horas = int.Parse(hora);
                if ((horas >= 00) && (horas < 12))
                    rdrBomdia.Checked = true;
                if ((horas >= 12) && (horas < 19))
                    rdrBoatarde.Checked = true;
                if ((horas >= 19) && (horas < 00))
                    rdrBoanoite.Checked = true;
            }
            catch (Exception ex)
            {
                rdrBoanoite.Checked = true;
            }
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
            var SolicitanteEmail = String.Empty;

            if (chkJessica.Checked)
            {
                
            }



            var mensagemSaida = ""+
                                "";



        }
    }
}
