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
        //FUNCAO MELHOR PARA TRABALHAR
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
        public static string FormatUpperCaseWordsV3(string text, string tagPattern)
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

                // Verifica se a palavra já está dentro de tags HTML
                if (IsWordAlreadyTagged(word, text, match.Index))
                {
                    return word; // Mantém como está se já tiver tag
                }

                int upperCount = 0;
                foreach (char c in word)
                {
                    if (char.IsUpper(c)) upperCount++;
                    if (upperCount >= 2) break;
                }

                return upperCount >= 2 ? $"{openTag}{word}{closeTag}" : word;
            });
        }
        // Função auxiliar para verificar se a palavra já está dentro de tags
        private static bool IsWordAlreadyTagged(string word, string fullText, int wordIndex)
        {
            // Verifica se há caracteres '<' antes da palavra e '>' depois da palavra
            int startCheck = Math.Max(0, wordIndex - 20); // Verifica 20 caracteres antes
            int endCheck = Math.Min(fullText.Length, wordIndex + word.Length + 20); // Verifica 20 caracteres depois

            string contextBefore = fullText.Substring(startCheck, wordIndex - startCheck);
            string contextAfter = fullText.Substring(wordIndex + word.Length, endCheck - (wordIndex + word.Length));

            // Verifica se há tag de abertura antes e tag de fechamento depois
            bool hasOpenTagBefore = contextBefore.Contains('<') && !contextBefore.Contains('>');
            bool hasCloseTagAfter = contextAfter.Contains('>') && !contextAfter.Contains('<');

            return hasOpenTagBefore && hasCloseTagAfter;
        }
        public static string FormatUpperCaseWordsV4(string text, string tagPattern)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Define tags
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

            // Pattern que ignora conteúdo dentro de tags HTML
            string pattern = @"(?<!<[^>]*)\b([A-ZÀ-Ü]{2,}[A-ZÀ-Ü\s\-\+\!\.\,\d]*)\b(?!>[^<]*</)";

            return Regex.Replace(text, pattern, match =>
            {
                string word = match.Groups[1].Value;
                return $"{openTag}{word}{closeTag}";
            }, RegexOptions.IgnoreCase);
        }
        public static string FormatUpperCaseWordsV5(string text, string tagPattern)
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

            // Pattern para encontrar palavras maiúsculas que NÃO estão dentro de tags HTML
            string pattern = @"(?<!<[^>]*)\b([A-ZÀ-Ü][A-ZÀ-Ü\s\-\+\!\.\,\d]*[A-ZÀ-Ü\d])\b(?![^<]*>)|\b([A-ZÀ-Ü]{2,})\b(?![^<]*>)";

            return Regex.Replace(text, pattern, match =>
            {
                string word = match.Groups[1].Success ? match.Groups[1].Value : match.Groups[2].Value;

                int upperCount = 0;
                foreach (char c in word)
                {
                    if (char.IsUpper(c)) upperCount++;
                    if (upperCount >= 2) break;
                }

                return upperCount >= 2 ? $"{openTag}{word}{closeTag}" : match.Value;
            }, RegexOptions.IgnoreCase);
        }
        public static string FormatUpperCaseWordsV6(string text, string tagPattern)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Define tags
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

            // Pattern para encontrar palavras individuais totalmente maiúsculas
            // que não estão dentro de tags HTML existentes
            string pattern = @"(?<!<[^>]*)\b([A-ZÀ-Ü]{2,})(?![^<]*>)|(?<!<[^>]*)\b([A-ZÀ-Ü]+[A-ZÀ-Ü\s\-\+\d]*[A-ZÀ-Ü\d]+)(?![^<]*>)";

            return Regex.Replace(text, pattern, match =>
            {
                string word = match.Groups[1].Success ? match.Groups[1].Value : match.Groups[2].Value;

                // Verifica se a palavra já está dentro de tags analisando o contexto
                if (IsAlreadyInsideTags(text, match.Index, match.Length))
                {
                    return match.Value;
                }

                return $"{openTag}{word}{closeTag}";
            });
        }
        // Função auxiliar para verificar se o texto já está dentro de tags
        private static bool IsAlreadyInsideTags(string fullText, int startIndex, int length)
        {
            // Verifica se há tag de abertura antes
            int tagStart = fullText.LastIndexOf('<', startIndex);
            if (tagStart >= 0 && tagStart < startIndex)
            {
                // Verifica se é uma tag de abertura válida
                int tagEnd = fullText.IndexOf('>', tagStart);
                if (tagEnd >= 0 && tagEnd < startIndex)
                {
                    // Verifica se há tag de fechamento correspondente depois
                    int closeTagStart = fullText.IndexOf("</", startIndex + length);
                    if (closeTagStart > startIndex + length)
                    {
                        int closeTagEnd = fullText.IndexOf('>', closeTagStart);
                        if (closeTagEnd > closeTagStart)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
       //Essa daqui corrigido
        public static string FormatUpperCaseWordsV7(string text, string tagPattern)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Define tags
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

            // Abordagem: processar o texto fora das tags existentes
            StringBuilder result = new StringBuilder();
            int lastIndex = 0;

            // Encontra todas as tags <b> existentes
            var existingTags = Regex.Matches(text, @"<b\s*>[^<]*</b\s*>|<b\s*>[^<]*</b\s*>", RegexOptions.IgnoreCase);

            foreach (Match tagMatch in existingTags.Cast<Match>())
            {
                // Processa o texto antes da tag
                string textBeforeTag = text.Substring(lastIndex, tagMatch.Index - lastIndex);
                result.Append(FormatTextOutsideTags(textBeforeTag, openTag, closeTag));

                // Adiciona a tag existente sem modificar
                result.Append(tagMatch.Value);

                lastIndex = tagMatch.Index + tagMatch.Length;
            }

            // Processa o texto restante após a última tag
            string remainingText = text.Substring(lastIndex);
            result.Append(FormatTextOutsideTags(remainingText, openTag, closeTag));

            return result.ToString();
        }
        private static string FormatTextOutsideTags(string text, string openTag, string closeTag)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Pattern para encontrar sequências de palavras totalmente maiúsculas
            string pattern = @"\b([A-ZÀ-Ü]{2,}(?:\s+[A-ZÀ-Ü]{2,})*)\b";

            return Regex.Replace(text, pattern, match =>
            {
                string words = match.Value;
                // Verifica se todas as palavras na sequência têm pelo menos 2 letras maiúsculas
                string[] wordArray = words.Split(' ');
                bool allValid = true;

                foreach (string word in wordArray)
                {
                    int upperCount = 0;
                    foreach (char c in word)
                    {
                        if (char.IsUpper(c)) upperCount++;
                        if (upperCount >= 2) break;
                    }
                    if (upperCount < 2)
                    {
                        allValid = false;
                        break;
                    }
                }

                return allValid ? $"{openTag}{words}{closeTag}" : words;
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
                string formattedText = FormatUpperCaseWordsV7(inputText, tagPattern);
                txtFraseologia.Text = formattedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao formatar texto: {ex.Message}");
            }
        }






    }
}
