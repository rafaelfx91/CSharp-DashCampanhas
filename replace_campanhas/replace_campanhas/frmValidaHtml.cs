using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmValidaHtml : Form
    {
        public frmValidaHtml()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            var caminhoArquivo = @"C:\Users\rafae\OneDrive\Área de Trabalho\Claro\OSBarbara.html";

            wbPecaEmail.Navigate(caminhoArquivo);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            wbPecaEmail.Navigate("");
        }
    }
}
