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
    public partial class frmEncriptador : Form
    {
       
        crypto cp = new crypto();   
        
        public frmEncriptador()
        {
            InitializeComponent();
        }

        public frmEncriptador(string senha)
        {
            InitializeComponent();
            txtSenha.Text = senha;
        }










        private void btnGerar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseEntrada.Clear();
            txtFraseSaida.Clear();
            txtSenha.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
