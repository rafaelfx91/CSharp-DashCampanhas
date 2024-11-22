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
    public partial class frmUpLow : Form
    {
        public frmUpLow()
        {
            InitializeComponent();
            rdUP.Checked = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rdUP.Checked) 
                txtSaida.Text = txtSaida.Text.ToUpper();
            else
                txtSaida.Text = txtSaida.Text.ToLower();
        }
    }
}
