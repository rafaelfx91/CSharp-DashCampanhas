using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
//using Outlook = Microsoft.Office.Interop.Outlook;

namespace replace_campanhas
{
    public partial class frmEnvioDeEmail : Form
    {
        public frmEnvioDeEmail()
        {
            //InitializeComponent();
        }



        private async void btnGerar_Click(object sender, EventArgs e)
        {           

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
