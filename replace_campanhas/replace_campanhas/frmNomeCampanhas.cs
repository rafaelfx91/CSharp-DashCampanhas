using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace replace_campanhas
{
    public partial class frmNomeCampanhas : Form
    {
        public frmNomeCampanhas()
        {
            InitializeComponent();
        }

        private void frmNomeCampanhas_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        //
        //
        // METODOS
        //
        //
        public void qtdCaracteres()
        {

            int totalValue = 0;
            foreach (char item in txtFraseEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracteresCampanha.Text = "Caracters: " + totalValue;

            if (totalValue >= 61)
                lblCaracteresCampanha.ForeColor = Color.Red;
            if (totalValue <= 60)
                lblCaracteresCampanha.ForeColor = Color.Black;

        }//public void qtdCaracteres()


        //
        //
        // BOTOES
        //
        //
        //
        private void btnGerar_Click(object sender, EventArgs e)
        {

            txtFraseSaida.Text = "";
            //txtFraseSaida.ForeColor = Color.Black;
            //txtBoxColors("B", "");

            LimparString ls = new LimparString();

            var frase = ls.fraseLimpa(txtFraseEntrada.Text);

            if (frase.Length > 60)
            {
                txtFraseSaida.ForeColor = Color.Red;
                //txtFraseSaida.Text = "Frase maior que 60 Caracteres";
                txtFraseSaida.Text = frase;
            }
            else
            {
                txtFraseSaida.Text = frase;
            }


        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseEntrada.Clear();
            txtFraseSaida.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtFraseEntrada_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtFraseSaida.Text);
        }
    }
}
