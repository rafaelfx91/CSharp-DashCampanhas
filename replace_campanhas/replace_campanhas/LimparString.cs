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

        public string fraseLimpa(string FraseEntrada)
        {
            var substituiEspaco = new string[] { "     ", "    ", "   ", "  ", " " };

            var frase = FraseEntrada;

            var saidaRetorno = String.Empty;

            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçº¹²³";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc    ";

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

            return Regex.Replace(texto, "[^a-zA-Z0-9 :+=/{}%.*,!?]+", "");
        }


    }//public class LimparStrin

}//namespace replace_campanhas
