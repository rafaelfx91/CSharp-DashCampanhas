using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmNomeCampanhasV2 : Form
    {
        public frmNomeCampanhasV2()
        {
            InitializeComponent();
        }

        private void frmNomeCampanhasV2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox= false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFraseEntrada.Clear();
            txtFraseSaida.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtFraseSaida.Text);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            LimparString ls = new LimparString();
            //var lista = new List<string>();
            var aux = "";
            txtFraseSaida.Clear();

            for (int i = 0; i < txtFraseEntrada.Lines.Length; i++)
            {
                aux = ls.fraseLimpa(txtFraseEntrada.Lines[i]);

                if (aux.Length >= 61)
                    txtFraseSaida.Text += aux.Substring(0, 60);
                else
                    txtFraseSaida.Text += aux;

                txtFraseSaida.Text += Environment.NewLine;

            }


        }
        
    


    }//fim




}

