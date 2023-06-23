using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public class FuncoesDeveloper
    {
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
