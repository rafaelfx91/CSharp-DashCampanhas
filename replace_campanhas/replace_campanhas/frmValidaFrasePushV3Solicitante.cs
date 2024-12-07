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
    public partial class frmValidaFrasePushV3Solicitante : Form
    {
        public frmValidaFrasePushV3Solicitante()
        {
            InitializeComponent();
        }

        private void frmValidaFrasePushV3Solicitante_Load(object sender, EventArgs e)
        {

        }


        //METODOS
        public void mudarImagemPush()
        {
            if(rdClaroPay.Checked)
                pbPushLogo.Image = Properties.Resources.ClaroCP;
            if (rdMinahClaroMovel.Checked)
                pbPushLogo.Image = Properties.Resources.minhaClaroMovel;
            if (rdClaroResidencial.Checked)
                pbPushLogo.Image = Properties.Resources.minhaClaroResidencial;

            pbPushLogo.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        public void tamanhoTitulo()
        {
            int totalValue = 0;
            foreach (char item in txtTituloEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterTitulo.Text = "Caracters no titulo: " + totalValue + " / 50";

            if (totalValue >= 51)
                lblCaracterTitulo.ForeColor = Color.Red;
            if (totalValue < 51)
                lblCaracterTitulo.ForeColor = Color.Green;
        }
        public void tamanhoMensagem()
        {
            int totalValue = 0;
            foreach (char item in txtMsgEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterMsg.Text = "Caracters na mensagem: " + totalValue + " / 200";

            if (totalValue >= 201)
                lblCaracterTitulo.ForeColor = Color.Red;
            if (totalValue < 201)
                lblCaracterTitulo.ForeColor = Color.Green;

        }














        private void rdClaroPay_CheckedChanged(object sender, EventArgs e)
        {
            mudarImagemPush();
        }

        private void txtTituloEntrada_TextChanged(object sender, EventArgs e)
        {
            tamanhoTitulo();
        }

        private void txtMsgEntrada_TextChanged(object sender, EventArgs e)
        {
            tamanhoMensagem();
        }

        private void btnMostrarEmote_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMsgEntrada.Clear();
            txtTituloEntrada.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
