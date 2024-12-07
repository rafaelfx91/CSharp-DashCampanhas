using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace replace_campanhas
{
    public class LimparString
    {
        public readonly string caracteresEspeciais = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçº¹²³¨&_";
        public readonly string caracteresNormais = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc!@#$%*+=-/";

        public string fraseLimpa(string FraseEntrada)
        {
            var substituiEspaco = new string[] { "     ", "    ", "   ", "  ", " " };

            var frase = FraseEntrada;

            var saidaRetorno = String.Empty;

            string stringSemPipe = FraseEntrada.Replace("|", "");

            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçº¹²³.";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc     ";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                frase = frase.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            var saida = Regex.Replace(frase, @"[^0-9a-zA-Z\._]", " ");

            saida = saida.Replace("Claro pay", "ClaroPay");

            for (int i = 0; i < substituiEspaco.Length; i++)
            {
                saida = saida.Replace(substituiEspaco[i], " ");
            }

            saida = saida.Replace(" ", "_");

            saidaRetorno = saida;

            while (true)
            {
                if (saida.IndexOf("ClaroPay") != saida.LastIndexOf("ClaroPay"))
                {
                    var count = saida.LastIndexOf("ClaroPay");
                    var aux = saida;
                    saida = saida.Substring(0, count - 1);
                    saida += aux.Substring(count + 8);

                }
                else
                {
                    break;
                }

            }

            return saidaRetorno;

        }// public string fraseLimpa(string FraseEntrada)
        public string caracteresLimpos(string FraseEntrada)
        {
            var substituiEspaco = new string[] { "     ", "    ", "   ", "  ", " " };

            var frase = FraseEntrada;

            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            frase = frase.Replace("°", "");
            frase = frase.Replace("ª", "");
            frase = frase.Replace("³", "");
            frase = frase.Replace("²", "");
            frase = frase.Replace("¹", "");
            frase = frase.Replace("~", "");
            frase = frase.Replace("^", "");
            //frase = frase.Replace("*", "");

            for (int i = 0; i < comAcentos.Length; i++)
            {
                frase = frase.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }

            return frase;

        }//public string caracteresLimpos(string FraseEntrada)
        public int verificaChars(string nome)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçº¹²³";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc    ";
            var aviso = "";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                if (nome.Contains(comAcentos[i]))
                {
                    //aviso += comAcentos[i] + ", ";
                    return 1;
                }
            }
            if (nome.Contains(" "))
            {
                return 1;
            }

            return 0;

        }//public void verificaChars(string nome)
        public string SubstituirEmote(string input)
        {
            Regex regex = new Regex(@"U\+(\w+)");
            string resultado = regex.Replace(input, "{$1}");

            resultado = resultado.Replace("{{", "{").Replace("}}", "}");

            return resultado;

        }//static string SubstituirEmote(string input)
        public string SubstituirEmoteParaCodigo(string input)
        {
            // Regex para capturar os códigos entre chaves
            Regex regex = new Regex(@"\{([A-F0-9]+)\}");

            // Substitui {AD0D} por U+AD0D
            string resultado = regex.Replace(input, "U+$1");

            return resultado;
        }
        public string EmoteParaCodigo(string input)
        {
            StringBuilder resultado = new StringBuilder();

            foreach (char c in input)
            {
                // Obtém o valor Unicode em hexadecimal
                int unicodeValue = char.ConvertToUtf32(input, input.IndexOf(c));
                string hexCode = unicodeValue.ToString("X"); // Converte para hexadecimal

                // Adiciona o código formatado entre chaves
                resultado.Append($"{{{hexCode}}}");
            }

            return resultado.ToString();
        }

        public string EmoteParaCodigo2(string input)
        {

            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                // Verifica se o caractere atual é parte de um par substituto (emoji)
                if (char.IsHighSurrogate(input[i]) && i + 1 < input.Length && char.IsLowSurrogate(input[i + 1]))
                {
                    // Converte o par substituto para o valor Unicode (UTF-32)
                    int unicodeValue = char.ConvertToUtf32(input, i);

                    // Adiciona o código formatado em hexadecimal entre chaves
                    resultado.Append($"{{{unicodeValue:X}}}");

                    // Pula o próximo caractere (low surrogate) já que é parte do par substituto
                    i++;
                }
                else if (Char.IsSurrogate(input[i]) == false)
                {
                    // Ignora caracteres de controle e caracteres simples (como letras e espaços)
                    continue;
                }
            }

            return resultado.ToString();
        }


        public string CodigoParaEmote(string input)
        {
            // Regex para encontrar padrões no formato {XXXX}
            Regex regex = new Regex(@"\{([A-F0-9]+)\}");

            // Substitui cada código pelo emote correspondente
            string resultado = regex.Replace(input, match =>
            {
                string hexCode = match.Groups[1].Value; // Captura o código hexadecimal
                int unicodeValue = int.Parse(hexCode, System.Globalization.NumberStyles.HexNumber); // Converte para int
                string emote = char.ConvertFromUtf32(unicodeValue); // Converte para emote
                return emote; // Retorna o emote
            });

            return resultado; // Retorna o texto final com os emotes
        }
        public string SubstituirEmoteMostrar(string input)
        {
            Regex regex = new Regex(@"U\+(\w+)");
            string resultado = regex.Replace(input, match =>
            {
                string hexCode = match.Groups[1].Value;
                int unicodeValue = int.Parse(hexCode, System.Globalization.NumberStyles.HexNumber);
                string emote = char.ConvertFromUtf32(unicodeValue);
                return emote;
            });

            resultado = resultado.Replace("{", "").Replace("}", "");

            return resultado;
        }
        public string RemoverCaracteresEspeciais(string texto)
        {
            // Utiliza expressão regular para substituir caracteres especiais por uma string vazia
            return Regex.Replace(texto, "[^a-zA-Z0-9 :+=/{}%.*,]+", "");
        }
        public string RemoverCaracteresEspeciais2(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }

            return Regex.Replace(texto, "[^a-zA-Z0-9 :+=/{}%.*,!?$@#-]+", "");
        }
        public string fraseLimpa2_simples(string texto)
        {
            texto = texto.Replace("|", "");
            var saida = Regex.Replace(texto, @"[^0-9a-zA-ZáéíóúÁÉÍÓÚâêîôÂÊÎÔãõÃÕàèìòùÀÈÌÒÙäëïöüÄËÏÖÜçÇ\._]", " ");

            return saida;
        }
        public string fraseLimpa3_simples(string texto)
        {
            texto = texto.Replace("|", "");
            var saida = Regex.Replace(texto, @"[^0-9a-zA-ZêôÊÔãõÃÕçÇ\._]", " ");

            return saida;
        }



    }//public class LimparStrin

}//namespace replace_campanhas
