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
    public partial class frmValidaHtmlV2ListaCoringas : Form
    {
        public frmValidaHtmlV2ListaCoringas()
        {
            InitializeComponent();
        }

        public frmValidaHtmlV2ListaCoringas(string coringas)
        {
            InitializeComponent();
            txtCoringas.Text = coringas;
        }

        private void frmValidaHtmlV2ListaCoringas_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
