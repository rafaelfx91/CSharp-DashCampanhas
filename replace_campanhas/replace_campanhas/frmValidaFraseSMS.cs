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
        LimparString ls = new LimparString();

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
        public void qtdCaracteres(int labels)
        {
            //textbox = 1 Txtto de entrada
            //textbox = 2 Txtto de saida

            if (labels == 1)
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
            }
            if(labels == 2)
            {
                int totalValue = 0;
                foreach (char item in txtFraseEntrada.Text)
                {
                    totalValue = totalValue + 1;
                }
                lblCaracteresCampanha2.Text = "Caracters: " + totalValue;

                if (totalValue >= 161)
                    lblCaracteresCampanha2.ForeColor = Color.Red;
                if (totalValue < 161)
                    lblCaracteresCampanha2.ForeColor = Color.Black;
            }




        }//public void qtdCaracteres()


        private void HighlightCharacter(Color highlightColor)
        {
            //var chars = ls.caracteresEspeciais;
            //
            //// Salva a posição atual do cursor
            //int currentPosition = txtFraseEntrada.SelectionStart;
            //
            //// Procura pelo caractere na string
            //int startIndex = 0;
            //while ((startIndex = txtFraseEntrada.Text.IndexOf(chars, startIndex)) != -1)
            //{
            //    // Seleciona o caractere encontrado
            //    txtFraseEntrada.Select(startIndex, chars.Length);
            //
            //    // Aplica a cor ao texto selecionado
            //    //txtFraseEntrada.SelectionColor = highlightColor;
            //
            //    // Move para o próximo caractere
            //    startIndex += chars.Length;
            //}
            //
            //// Restaura a posição original do cursor
            //txtFraseEntrada.SelectionStart = currentPosition;
            //txtFraseEntrada.SelectionLength = 0;
            ////txtFraseEntrada.SelectionColor = txtFraseEntrada.ForeColor;
        }





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
            //LimparString ls = new LimparString();
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
            qtdCaracteres(1);
            //HighlightCharacter(Color.Red);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtFraseSaida.Text);
        }

        private void txtFraseSaida_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres(2);
        }
    }
}
