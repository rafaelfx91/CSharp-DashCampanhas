using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace replace_campanhas
{
    internal class FuncoesDiversas
    {
        public FuncoesDiversas()
        {

        }

        public int setBoasVindas(string hora)
        {
            try
            {
                var horas = int.Parse(hora);
                if ((horas >= 00) && (horas < 12))
                    return 0;
                if ((horas >= 12) && (horas < 19))
                    return 1;
                if ((horas >= 19) && (horas < 00))
                    return 2;
            }
            catch (Exception ex)
            {
                return 2;
            }
            return 2;
        }

        public bool ValidarLink(string link)
        {
            // Expressão regular para validar o formato do link
            //string pattern = @"^https:\/\/[\w\-]+(\.[\w\-]+)+[/#?]?.*$";
            string pattern = @"^https:\/\/[\w\-]+(\.[\w\-]+)+[/#?]?(\s|\s+)?";
            if (link.Contains(" "))
                return false;

            // Verifica se o link corresponde ao padrão
            if (Regex.IsMatch(link, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ValidarLink2(string link)
        {
            // Expressão regular para validar o formato do link
            string pattern = @"^https:\/\/[\w\-]+(\.[\w\-]+)+[/#?]?.*$";

            // Verifica se o link corresponde ao padrão
            if (Regex.IsMatch(link, pattern))
            {
                return "Link OK";
            }
            else
            {
                return "Link com erro";
            }
        }




    }//fim
}
