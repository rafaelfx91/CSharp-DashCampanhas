using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmGerarEmailJira : Form
    {
        //private bool pcDeveloper = false;
        //private FuncoesDeveloper fd = new FuncoesDeveloper();
        private FuncoesDeveloper fd;

        public frmGerarEmailJira()
        {
            InitializeComponent();
        }

        public frmGerarEmailJira(FuncoesDeveloper fd)
        {
            InitializeComponent();
            this.fd= fd;
        }

        private void frmGerarEmailJira_Load(object sender, EventArgs e)
        {
            setBoasVindas(DateTime.Now.ToString("HH"));
            if (fd.validaConfigsDev3())
                chkDev.Visible= true;

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
        public void txtAmxRead(){

            if (rdrOSAMX.Checked) 
                txtAmx.ReadOnly= false;
            else
                txtAmx.ReadOnly = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdrTBClaropayCorrentista_Click(object sender, EventArgs e)
        {
            txtAmxRead();
        }

        private void rdrTBPlataformaSas_Click(object sender, EventArgs e)
        {
            txtAmxRead();
        }

        private void rdrOSAMX_Click(object sender, EventArgs e)
        {
            txtAmxRead();
        }

        private void txtCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSaida.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            chkSegunda.Checked= false;
            chkTerca.Checked= false;
            chkQuarta.Checked= false;
            chkQuinta.Checked= false;
            chkSexta.Checked= false;
            chkSabado.Checked= false;
           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var boasVindas = String.Empty;

            if (rdrBomdia.Checked)
                boasVindas = "Bom dia!";
            if (rdrBoatarde.Checked)
                boasVindas = "Boa tarde!";
            if (rdrBoanoite.Checked)
                boasVindas = "Boa noite!";

            var agendamento = String.Empty;

            if (rdrAgendamento.Checked)
                agendamento = "agendamento";
            if (rdrCancelamento.Checked)
                agendamento = "cancelamento";
            if (rdrPausa.Checked)
                agendamento = "pausa";

            var dias = "Dia:\r\n";
            var horas = "Hora:\r\n";


            if (chkSegunda.Checked)
                dias += "segunda ";            
            if (chkTerca.Checked)
                dias += "terça ";            
            if (chkQuarta.Checked)
                dias += "quarta ";            
            if (chkQuinta.Checked)
                dias += "quinta ";            
            if (chkSexta.Checked)
                dias += "sexta ";            
            if (chkSabado.Checked)
                dias += "sabado ";

            if (chkSegunda.Checked || chkTerca.Checked || chkQuarta.Checked ||
                chkQuinta.Checked || chkSexta.Checked)
                horas = "Hora:\r\n" +
                        "09:00 as 21:00";

            if (chkSabado.Checked)
                horas = "Hora:\r\n" +
                        "09:00 as 15:00";


            if (chkSegunda.Checked && chkTerca.Checked && chkQuarta.Checked &&
                chkQuinta.Checked && chkSexta.Checked && chkSabado.Checked)
            {
                dias = "Dia:\r\n" +
                       "De segunda a sabado ";

                horas = "Hora:\r\n" +
                        "09:00 as 21:00";
            }

            var listAmx = txtListaAmx.Text;

            var mensagemSaida = boasVindas +
                                "\r\n" +
                                "Solicito o " + agendamento + " de agendamento da seguinte campanha\r\n\r\n" +
                                dias+
                                "\r\n\r\n" +
                                horas +
                                "\r\n\r\n" +
                                "Campanhas:\r\n\r\n" +
                                listAmx +
                                "\r\n\r\n" +
                                "Obrigado."
                                ;

            if (chkDev.Checked)
                mensagemSaida = "----------------------------\r\n"+
                                "EMAIL\r\n" +
                                "----------------------------\r\n"+
                                mensagemSaida;

            txtSaida.Text = mensagemSaida;

            //Boa tarde!
            //
            //Solicito agendamento das seguintes campanhas.
            //
            //Dias:
            //SEGUNDA A SABADO
            //
            //Hora:
            //09:00 as 21:00
            //
            //Gatilho:
            //Não rodar campanha aos feriados nacional
            //
            //73566_Regua_de_Boas_Vindas_D25_E_mail AMX156302
            //
            //73567_Regua_de_Boas_Vindas_D25_Push AMX156303
            //
            //74852_Regua_de_Boas_Vindas_D27_CASHBACK_E_DESCONTOS AMX157872
            //
            //75045_Hub_de_Credito_Regua_de_Awareness_E_MAIL_PUSH AMX157933
            //Abraços.



        }
    
    }
}
