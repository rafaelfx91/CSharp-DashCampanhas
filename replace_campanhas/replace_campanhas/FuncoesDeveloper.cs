using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public class FuncoesDeveloper
    {
        private bool developer = false;

        public FuncoesDeveloper()
        {

        }


        public FuncoesDeveloper(string[] args)
        {
            verificaArgumentos(args);
        }

        public void verificaArgumentos(string[] args)
        {
            //-devS

            for (int i = 0; i < args.Count(); i++)
            {
                args[i] = args[i].Trim();

                if (args[i] == "-devS")
                    developer = true;
                
            }




            
        }

        public bool validaConfigsDev(string nomePC)
        {
            if (nomePC == "DESKTOP-G34V8GD")
                return true;
            else
                return false;


        }

        public bool validaConfigsDev2()
        {
            if (pegaNomePc() == "DESKTOP-G34V8GD")
                return true;
            else
                return false;


        }      
        public bool validaConfigsDev3()
        {
            if (developer)
                return true;
            else
                return false;


        }

        public string pegaNomePc()
        {
            var nome = Environment.MachineName;
            return nome;
            //var nomeCompleto = Dns.GetHostEntry(nome).HostName;
            //MessageBox.Show(nome);
            //MessageBox.Show(nomeCompleto);
        }

    }


}
