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
    public partial class frmRCS3 : Form
    {
        public frmRCS3()
        {
            InitializeComponent();
        }

        private void frmRCS3_Load(object sender, EventArgs e)
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
                txtTitulo.Text = "Frase limite " + limite.ToString() + " Char: " + totalValue;

                if (totalValue >= limite)
                    txtTitulo.ForeColor = Color.Red;
                if (totalValue < limite)
                    txtTitulo.ForeColor = Color.Black;
            }
            if (label == 2) //frase
            {
                foreach (char item in txtFrase.Text)
                {
                    totalValue = totalValue + 1;
                }
                txtFrase.Text = "Frase limite " + limite.ToString() + " Char: " + totalValue;

                if (totalValue >= limite)
                    txtFrase.ForeColor = Color.Red;
                if (totalValue < limite)
                    txtFrase.ForeColor = Color.Black;
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            LimparString ls = new LimparString();

            var titulo = ls.RemoverCaracteresEspeciais2(txtTitulo.Text);
            txtTitulo.Text = titulo;
            var frase = ls.RemoverCaracteresEspeciais2(txtFrase.Text);
            txtFrase.Text = frase;

            wbLinkImg.Navigate(txtLinkImg.Text);
            wbLinkBotao.Navigate(txtLinkBotao.Text);

        }



    }//fim
}
