using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
            FuncoesDiversas fd = new FuncoesDiversas();
            var link = txtLink.Text;
            //lblLink.Text = fd.ValidarLink2(link);
            if (fd.ValidarLink(link))
            {
                lblLink.ForeColor = Color.Green;
                lblLink.Text = "Link Ok";
            }
            else
            {
                lblLink.ForeColor = Color.Red;
                lblLink.Text = "Link com erro";
            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseEntrada.Clear();
            txtLink.Clear();
            lblLink.Text = "Link";
            lblLink.ForeColor = Color.Black;

        }

        private void txtFraseEntrada_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres(250);
        }


    }//fim
}
