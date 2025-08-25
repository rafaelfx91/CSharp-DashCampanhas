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
    public partial class frmAgendamentos : Form
    {
        string caminhoArquivoN2 = "";

        public frmAgendamentos()
        {
            InitializeComponent();
        }


        public frmAgendamentos( FuncoesDeveloper fd)
        {
            InitializeComponent();
            caminhoArquivoN2 = fd.getCaminhoN2();
            txtCaminhoArquivo.Text = caminhoArquivoN2;
        }

        private void frmAgendamentos_Load(object sender, EventArgs e)
        {

        }





    }
}
