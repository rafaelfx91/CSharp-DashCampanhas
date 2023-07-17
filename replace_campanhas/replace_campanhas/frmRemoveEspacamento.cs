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
    public partial class frmRemoveEspacamento : Form
    {
        public frmRemoveEspacamento()
        {
            InitializeComponent();
            this.MaximizeBox= false;
            //txtTextoEntrada.MaxLength=500000;
            //txtTextoSaida.MaxLength=500000;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTextoEntrada.Clear();    
            txtTextoSaida.Clear();    
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < txtTextoEntrada.Lines.Count(); i++)
            {
                txtTextoSaida.Text += txtTextoEntrada.Lines[i].ToString().Trim()+";";
            }


        }



    }
}
