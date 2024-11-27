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
    public partial class frmValidaFraseSMSV2 : Form
    {
        LimparString ls = new LimparString();

        public frmValidaFraseSMSV2()
        {
            InitializeComponent();
        }
        private void frmValidaFraseSMSV2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            lblCaracteresCampanha.ForeColor = Color.Green;
        }

        //
        //
        // METODOS
        //
        //
        public void qtdCaracteres()
        {
            //textbox = 1 Txtto de entrada
            //textbox = 2 Txtto de saida

            int totalValue = 0;
            foreach (char item in rtxtFraseEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracteresCampanha.Text = "Caracters: " + totalValue;

            if (totalValue >= 161)
                lblCaracteresCampanha.ForeColor = Color.Red;
            if (totalValue < 161)
                lblCaracteresCampanha.ForeColor = Color.Green;
 




        }//public void qtdCaracteres()


        private void HighlightCharacter(Color highlightColor)
        {
            var chars = ls.caracteresEspeciais;
            
            // Salva a posição atual do cursor
            int currentPosition = rtxtFraseEntrada.SelectionStart;
            
            // Procura pelo caractere na string
            int startIndex = 0;
            while ((startIndex = rtxtFraseEntrada.Text.IndexOf(chars, startIndex)) != -1)
            {
                // Seleciona o caractere encontrado
                rtxtFraseEntrada.Select(startIndex, chars.Length);

                // Aplica a cor ao texto selecionado
                rtxtFraseEntrada.SelectionColor = highlightColor;
            
                // Move para o próximo caractere
                startIndex += chars.Length;
            }

            // Restaura a posição original do cursor
            rtxtFraseEntrada.SelectionStart = currentPosition;
            rtxtFraseEntrada.SelectionLength = 0;
            rtxtFraseEntrada.SelectionColor = rtxtFraseEntrada.ForeColor;
        }

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

            // Restaura a posição original do cursor e a cor padrão
            richTextBox.SelectionStart = currentPosition;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionColor = richTextBox.ForeColor;
        }

        private void HighlightCharactersv3(RichTextBox richTextBox,  Color invalidColor)
        {
            string validCharacters = ls.caracteresNormais;

            // Certifica-se de que há texto no RichTextBox
            if (string.IsNullOrEmpty(richTextBox.Text))
                return;

            // Salva a posição atual do cursor
            int currentPosition = richTextBox.SelectionStart;

            // Itera por cada caractere no texto do RichTextBox
            for (int i = 0; i < richTextBox.Text.Length; i++)
            {
                char currentChar = richTextBox.Text[i];

                // Verifica se o caractere atual está na lista de caracteres permitidos
                if (!validCharacters.Contains(currentChar))
                {
                    // Seleciona o caractere inválido
                    richTextBox.Select(i, 1);

                    // Aplica a cor ao caractere inválido
                    richTextBox.SelectionColor = invalidColor;
                }
                else
                {
                    // Se for válido, mantém a cor padrão
                    richTextBox.Select(i, 1);
                    richTextBox.SelectionColor = richTextBox.ForeColor;
                }
            }

            // Restaura a posição original do cursor e a cor padrão
            richTextBox.SelectionStart = currentPosition;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionColor = richTextBox.ForeColor;
        }










        private void btnGerar_Click(object sender, EventArgs e)
        {
            var frase = ls.RemoverCaracteresEspeciais2(rtxtFraseEntrada.Text);

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
            //HighlightCharacter(Color.Red);
            HighlightCharactersv2(rtxtFraseEntrada, Color.Red);
        }
    }
}
