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
    public partial class frmSelects : Form
    {
        private FuncoesDeveloper fd;

        public frmSelects()
        {
            InitializeComponent();
        }

        public frmSelects(FuncoesDeveloper fd)
        {
            InitializeComponent();
            this.fd = fd;
            this.MinimumSize = new Size(720, 700);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            txtQuerry.Clear();
            txtVar0.Clear();
            txtVar1.Clear();
            txtVar2.Clear();
            txtVar3.Clear();
            txtVar4.Clear();
            txtVar5.Clear();

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            var variavel4Lista = txtVar4.Text.Split();
            var variavel5Lista = txtVar5.Text.Split();
            var qtdLista = variavel4Lista.Count();

            for (int i = 0; i < qtdLista; i++)
            {

                txtSaida.Text += txtQuerry.Text.Replace("{0}", txtVar0.Text)
                                              .Replace("{1}", txtVar1.Text)
                                              .Replace("{2}", txtVar2.Text)
                                              .Replace("{3}", txtVar3.Text)
                                              .Replace("{4}", variavel4Lista[i])
                                              .Replace("{5}", variavel5Lista[i]);

                txtSaida.Text += Environment.NewLine;

            }




        }

        private void frmSelects_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }


    }
}
