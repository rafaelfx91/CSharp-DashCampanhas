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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

            if (totalValue >= 161)
                lblCaracteresCampanha.ForeColor = Color.Red;
            if (totalValue < 161)
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
           LimparString ls = new LimparString();
            
           txtFraseSaida.ForeColor = Color.Black;
           
           var frase = ls.RemoverCaracteresEspeciais2(txtFraseEntrada.Text);
           
           if (frase.Length >= 161)
           {
               MessageBox.Show("Opa a sua mensageme excede os 160 caracteres!"
                               , "Aviso"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Warning);
               //txtFraseSaida.ForeColor = Color.Red;
               //txtFraseSaida.Text = frase;
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
