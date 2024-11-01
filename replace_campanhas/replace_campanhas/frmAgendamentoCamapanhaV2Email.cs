using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BitMiracle.LibTiff.Classic;

namespace replace_campanhas
{
    public partial class frmAgendamentoCamapanhaV2Email : Form
    {
        private FuncoesDeveloper fd;
        FuncoesDiversas fdiversas = new FuncoesDiversas();

        public frmAgendamentoCamapanhaV2Email(FuncoesDeveloper fd)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.fd = fd;
        }

        private void frmAgendamentoCamapanhaV2Email_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            setBoasVindas();
            if (fd.validaConfigsDev3())
                chkDev.Visible = true;
            //txtTituloEmail.Visible = false;
            //lblAssuntoEmail.Visible = false;
            //tbEnvioEmail.
            tbControl.TabPages.RemoveAt(1);
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

        //INSERT INTO nome_da_tabela(coluna1, coluna2, coluna3)
        //VALUES(valor1, valor2, valor3);

        //INSERT INTO tab_fabrica(OS, amx, coluna3)
        //VALUES(valor1, valor2, valor3);

        public void gerarInsert()
        {
            var nomeTabela = "tab_fabrica";






        }




        private void chkDev_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click_1(object sender, EventArgs e)
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

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtAmx.Clear();
            txtSaida.Clear();
            txtTituloEmail.Clear();
            txtCorpoEmail.Clear();
            setBoasVindas();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            // Configurações do remetente e do servidor SMTP
            string fromAddress = "";
            string password = ""; // Insira a senha de aplicativo aqui
            string toAddress = "";
            string subject = "";
            string body = "";

            try
            {
                // Configuração do cliente SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587)
                {
                    Credentials = new NetworkCredential(fromAddress, password),
                    EnableSsl = true
                };

                // Configuração da mensagem de e-mail
                MailMessage mailMessage = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true // Defina para true se quiser enviar HTML
                };

                // Envio da mensagem
                smtpClient.Send(mailMessage);
                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }
















        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnGeraInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
