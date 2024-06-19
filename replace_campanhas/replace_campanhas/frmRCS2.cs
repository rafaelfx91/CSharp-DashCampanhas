using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmRCS2 : Form
    {
        public frmRCS2()
        {
            InitializeComponent();
        }
        private void frmRCS2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }


        public void qtdCaracteres(int limite, int label)
        {

            int totalValue = 0;

            if (label == 1) //titulo
            {
                foreach (char item in txtTitulo.Text)
                {
                    totalValue = totalValue + 1;
                }
                lblTituloL.Text = "Frase limite " + limite.ToString() + " Char: " + totalValue;

                if (totalValue >= limite)
                    lblTituloL.ForeColor = Color.Red;
                if (totalValue < limite)
                    lblTituloL.ForeColor = Color.Black;
            }
            if (label == 2) //frase
            {
                foreach (char item in txtFrase.Text)
                {
                    totalValue = totalValue + 1;
                }
                lblFraseL.Text = "Frase limite " + limite.ToString() + " Char: " + totalValue;

                if (totalValue >= limite)
                    lblFraseL.ForeColor = Color.Red;
                if (totalValue < limite)
                    lblFraseL.ForeColor = Color.Black;
            }




        }//public void qtdCaracteres()



        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres(200, 1);
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres(250, 2);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            LimparString ls = new LimparString();

            var titulo = ls.RemoverCaracteresEspeciais2(txtTitulo.Text);
            txtTitulo.Text = titulo;
            var frase = ls.RemoverCaracteresEspeciais2(txtFrase.Text);
            txtFrase.Text = frase;

            wbLinkImg.Navigate(txtLinkImg.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();
            txtTitulo.Clear();
            txtLinkImg.Clear();
            wbLinkImg.Navigate("");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
