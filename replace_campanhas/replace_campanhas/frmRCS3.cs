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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            FuncoesDiversas df = new FuncoesDiversas(); 
            LimparString ls = new LimparString();

            txtTitulo.Text = ls.fraseLimpa3_simples(txtTitulo.Text);

            txtFrase.Text = ls.fraseLimpa3_simples(txtFrase.Text);

            wbLinkImg.Navigate(txtLinkImg.Text);
            var link = txtLinkBotao.Text;
            if (df.ValidarLink(link))
            {
                lblLinkBotao.ForeColor = Color.Green;
                lblLinkBotao.Text = "Link Ok";
            }
            else
            {
                lblLinkBotao.ForeColor = Color.Red;
                if (String.IsNullOrEmpty(link))
                lblLinkBotao.Text = "Link não preenchido";
                else
                lblLinkBotao.Text = "Link com erro";
            }
           


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();
            txtLinkImg.Clear();
            txtTitulo.Clear();
            txtLinkBotao.Clear();
            wbLinkImg.Navigate("");
            lblLinkBotao.Text = "Link Botao";
            lblLinkBotao.ForeColor = Color.Black;
        }


    }//fim
}
