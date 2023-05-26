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
    public partial class frmValidaFrasePushV2 : Form
    {
        public frmValidaFrasePushV2()
        {
            InitializeComponent();
            //txtTituloSaida.ForeColor = Color.White;
            //txtMsgSaida.ForeColor = Color.DarkGray;
        }

        private void txtTituloEntrada_TextChanged(object sender, EventArgs e)
        {
            int totalValue = 0;
            int limite = 37;

            foreach (char item in txtTituloEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterTitulo.Text = "Caracters: " + totalValue;

            if (totalValue > limite)
                lblCaracterTitulo.ForeColor = Color.Red;

            if (totalValue <= limite)
                lblCaracterTitulo.ForeColor = Color.Black;

            if (totalValue > limite)
                txtTituloSaida.Text = txtTituloEntrada.Text.Substring(0, 37) + "...";
            else
                txtTituloSaida.Text = txtTituloEntrada.Text;



        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a "+ pictureBox1.Width.ToString());
            MessageBox.Show("a "+ pictureBox1.Height.ToString());
              
        }

        private void txtMsgEntrada_TextChanged(object sender, EventArgs e)
        {
            int totalValue = 0;
            int limite = 200;

            foreach (char item in txtMsgEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterMsg.Text = "Caracters: " + totalValue;

            if (totalValue > limite)
                lblCaracterMsg.ForeColor = Color.Red;
            if (totalValue <= limite)
                lblCaracterMsg.ForeColor = Color.Black;

            //if (totalValue > limite)
            //    txtTituloSaida.Text = txtTituloEntrada.Text.Substring(0, 199) + "...";
            //else
            txtMsgSaida.Text = txtMsgEntrada.Text;


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMsgEntrada.Clear();
            txtMsgSaida.Clear();
            txtTituloEntrada.Clear();
            txtTituloSaida.Clear();
        }

        private void btnCopiarTitulo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTituloSaida.Text);
        }

        private void btnCopiaMensagem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMsgSaida.Text);
        }
    
    
    
    
    }
}
