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
    public partial class frmRCS1 : Form
    {
        public frmRCS1()
        {
            InitializeComponent();
        }


        public void qtdCaracteres(int limite)
        {

            int totalValue = 0;
            foreach (char item in txtFraseEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblLimite.Text = "Frase limite 250 Char: " + totalValue;

            if (totalValue >= limite)
                lblLimite.ForeColor = Color.Red;
            if (totalValue < limite)
                lblLimite.ForeColor = Color.Black;
       
        }//public void qtdCaracteres()


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            LimparString ls = new LimparString();

            var frase = ls.RemoverCaracteresEspeciais2(txtFraseEntrada.Text);

            txtFraseEntrada.Text = frase;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseEntrada.Clear();
        }

        private void txtFraseEntrada_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres(250);
        }


    }//fim
}
