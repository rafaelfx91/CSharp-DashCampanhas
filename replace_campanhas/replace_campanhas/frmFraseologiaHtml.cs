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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace replace_campanhas
{
    public partial class frmFraseologiaHtml : Form
    {
        public frmFraseologiaHtml()
        {
            InitializeComponent();
            rdrMaiusculo.Checked = true;   
        }



        //FUNCOES
        public static string FormatUpperCaseWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string pattern = @"\b[A-ZÀ-Ü][A-ZÀ-Ü\s\-\+\!\.\,\d]*[A-ZÀ-Ü\d]\b|\b[A-ZÀ-Ü]{2,}\b";

            return Regex.Replace(text, pattern, match =>
            {
                string word = match.Value;
                int upperCount = 0;
                foreach (char c in word)
                {
                    if (char.IsUpper(c)) upperCount++;
                    if (upperCount >= 2) break;
                }

                return upperCount >= 2 ? $"<b>{word}</b>" : word;
            });
        }
        public static string FormatUpperCaseWordsV2(string text, string tagPattern)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Define tags padrão caso a tagPattern esteja vazia ou inválida
            string openTag = "<b>";
            string closeTag = "</b>";

            if (!string.IsNullOrEmpty(tagPattern))
            {
                string[] tags = tagPattern.Split(';');
                if (tags.Length >= 2)
                {
                    openTag = tags[0];
                    closeTag = tags[1];
                }
                else if (tags.Length == 1)
                {
                    openTag = tags[0];
                }
            }

            string pattern = @"\b[A-ZÀ-Ü][A-ZÀ-Ü\s\-\+\!\.\,\d]*[A-ZÀ-Ü\d]\b|\b[A-ZÀ-Ü]{2,}\b";

            return Regex.Replace(text, pattern, match =>
            {
                string word = match.Value;
                int upperCount = 0;
                foreach (char c in word)
                {
                    if (char.IsUpper(c)) upperCount++;
                    if (upperCount >= 2) break;
                }

                return upperCount >= 2 ? $"{openTag}{word}{closeTag}" : word;
            });
        }



        //BOTOES
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseologia.Clear();
            txtTag.Text = "<b>;</b>";
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = txtFraseologia.Text;
                string tagPattern = txtTag.Text; // Ex: "<b>;</b>"
                string formattedText = FormatUpperCaseWordsV2(inputText, tagPattern);
                txtFraseologia.Text = formattedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao formatar texto: {ex.Message}");
            }
        }






    }
}
