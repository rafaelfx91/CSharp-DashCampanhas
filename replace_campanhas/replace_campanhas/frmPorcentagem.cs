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
    public partial class frmPorcentagem : Form
    {
        public frmPorcentagem()
        {
            InitializeComponent();
        }

        private void frmPorcentagem_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                int val1, val2;
                txtres01.Text = calculoPorcentagem(int.Parse(p1val01.Text)
                                                  , int.Parse(p1val02.Text)
                                                  , 1).ToString();
            }
            catch(Exception ex)
            { 
            
            }
        }


        public int calculoPorcentagem( int val1, int val2, int tipo )
        {
            if (tipo == 1)//detalhe	"( 10 x 1000 ) / 100"
                return ((val1 * val2) / 100);

            return 0;
        }




    }
}
