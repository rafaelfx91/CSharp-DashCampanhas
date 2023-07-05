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
        private bool crypt = false;
        private string cryptSenha = "";

        //-devS
        //-cryptS123

        public FuncoesDeveloper()
        {

        }

        public FuncoesDeveloper(string[] args)
        {
            verificaArgumentos(args);
        }

        public void verificaArgumentos(string[] args)
        {

            for (int i = 0; i < args.Count(); i++)
            {
                args[i] = args[i].Trim();

                if (args[i] == "-devS")
                    developer = true; 
                if (args[i].Contains("-cryptS"))
                {
                   cryptSenha = args[i].Replace("-cryptS","");
                   crypt = true;
                }

                    
                
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

        public string validaSenhaCrypt()
        {
            if (crypt)
                return cryptSenha;
            else
                return "";
        }
        
        public bool validaSenhaCrypt2()
        {
            if (crypt)
                return crypt;
            else
                return crypt;
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
