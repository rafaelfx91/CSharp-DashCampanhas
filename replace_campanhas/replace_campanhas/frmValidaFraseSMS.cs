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
    public partial class frmValidaFraseSMS : Form
    {
        public frmValidaFraseSMS()
        {
            InitializeComponent();
        }
        private void frmValidaFraseSMS_Load(object sender, EventArgs e)
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

            if (totalValue >= 160)
                lblCaracteresCampanha.ForeColor = Color.Red;
            if (totalValue < 160)
                lblCaracteresCampanha.ForeColor = Color.Black;

        }//public void qtdCaracteres()

        //
        //
        // BOTOES
        //
        //
        //
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseEntrada.Clear();
            txtFraseSaida.Clear();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtFraseSaida.ForeColor = Color.Black;

            LimparString ls = new LimparString();

            var frase = ls.caracteresLimpos(txtFraseEntrada.Text);

            if (frase.Length > 160)
            {
                txtFraseSaida.ForeColor = Color.Red;
                txtFraseSaida.Text = frase;
            }
            else
            {
                txtFraseSaida.Text = frase;
            }
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
