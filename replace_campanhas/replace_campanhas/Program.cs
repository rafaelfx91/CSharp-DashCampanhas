using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal(args));
            //if(args.Count() != 0)
            //    Application.Run(new frmPrincipal());
            //if (args.Count() >= 0)
            //    Application.Run(new frmPrincipal(args));
        }
    }
}
