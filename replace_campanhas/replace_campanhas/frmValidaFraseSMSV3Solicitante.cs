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
    public partial class frmValidaFraseSMSV3Solicitante : Form
    {
        LimparString ls = new LimparString();

        public frmValidaFraseSMSV3Solicitante()
        {
            InitializeComponent();
        }
        private void frmValidaFraseSMSV3Solicitante_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            lblCaracteresCampanha.ForeColor = Color.Green;
        }


        public void qtdCaracteres()
        {
            int totalValue = 0;
            foreach (char item in rtxtFraseEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracteresCampanha.Text = "Caracters: " + totalValue+" /160";

            if (totalValue >= 161)
                lblCaracteresCampanha.ForeColor = Color.Red;
            if (totalValue < 161)
                lblCaracteresCampanha.ForeColor = Color.Green;

        }//public void qtdCaracteres()


        private void HighlightCharactersv2(RichTextBox richTextBox, Color highlightColor)
        {
            var charactersToHighlight = ls.caracteresEspeciais;

            // Certifica-se de que há texto no RichTextBox
            if (string.IsNullOrEmpty(richTextBox.Text))
                return;

            // Salva a posição atual do cursor
            int currentPosition = richTextBox.SelectionStart;

            // Itera por cada caractere especial na lista de caracteres a destacar
            foreach (char specialChar in charactersToHighlight)
            {
                int startIndex = 0;

                // Procura por todas as ocorrências do caractere especial
                while ((startIndex = richTextBox.Text.IndexOf(specialChar, startIndex)) != -1)
                {
                    // Seleciona o caractere encontrado
                    richTextBox.Select(startIndex, 1);

                    // Aplica a cor ao caractere selecionado
                    richTextBox.SelectionColor = highlightColor;

                    // Move para o próximo caractere
                    startIndex++;
                }
            }
        }












        private void btnGerar_Click(object sender, EventArgs e)
        {
            var frase = ls.RemoverCaracteresEspeciais2(rtxtFraseEntrada.Text);

            if (frase.Length >= 161)
            {
                MessageBox.Show("Oi tudo bem? \n A sua mensageme excede os 160 caracteres!"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
            }
            else
            {
                rtxtFraseEntrada.Text = frase;
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtFraseEntrada.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtxtFraseEntrada.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rtxtFraseEntrada_TextChanged(object sender, EventArgs e)
        {
            qtdCaracteres();
            //HighlightCharactersv2(rtxtFraseEntrada, Color.Red);
        }
    }
}
