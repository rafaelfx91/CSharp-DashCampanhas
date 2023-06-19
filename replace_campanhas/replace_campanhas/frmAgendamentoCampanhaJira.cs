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
        public frmAgendamentoCampanhaJira()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void frmAgendamentoCampanhaJira_Load(object sender, EventArgs e)
        {
            setBoasVindas(DateTime.Now.ToString("HH"));
        }

        public void setBoasVindas(string hora)
        {
            try
            {
                var horas = int.Parse(hora);
                if ( (horas >= 00) && (horas < 12) )
                    rdrBomdia.Checked = true;
                if ((horas >= 12) && (horas < 19))
                    rdrBoatarde.Checked = true;
                if ((horas >= 19) && (horas < 00))
                    rdrBoanoite.Checked = true;
            }
            catch(Exception ex) { 
                rdrBoanoite.Checked= true;
            }
        }







        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAmx.Clear();
            txtSaida.Clear();   
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

            var listAmx = txtAmx.Text;

            var mensagemSaida = boasVindas+
                                "\r\n\r\n" +
                                "Solicito o "+ agendamento + " de agendamento da seguinte campanha"+
                                "\r\n" +
                                "Campanhas: \r\n\n" +
                                listAmx+
                                "\r\n\r\n" +
                                "Obrigado."
                                ;

            txtSaida.Text = mensagemSaida;

            /*
            Boa tarde - Varaiavel
            Solicito o cancelamento de agendamento da seguinte campanha

            Campanha:
            52263 - Incremento TLV --Lista
            AMX132002 -- lista

            Obrigado   
             */
        }

        private void txtCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSaida.Text);
        }
    }
}
