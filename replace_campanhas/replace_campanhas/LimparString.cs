using System;
using System.Collections.Generic;
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

    }//public class LimparStrin

}//namespace replace_campanhas
