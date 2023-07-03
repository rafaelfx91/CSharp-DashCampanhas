using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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





    }
}
