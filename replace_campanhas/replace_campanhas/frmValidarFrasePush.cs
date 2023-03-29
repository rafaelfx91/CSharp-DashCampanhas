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
    public partial class frmValidarFrasePush : Form
    {
        public frmValidarFrasePush()
        {
            InitializeComponent();
        }

        //
        //
        // METODOS
        //
        //
        public string tratarEmote(string entrada)
        {

            if (entrada.Contains("U+"))
            {
                entrada = entrada.Replace(@"U+", "{");
                entrada = entrada.Replace(@"u+", "{");
                var indexInicial = entrada.LastIndexOf("{");
                var insert = entrada.Insert(indexInicial + 6, "}");
                return insert;
            }

            return entrada;

        }



        //
        //
        // 
        //
        //
        //
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            txtTituloSaida.Text = tratarEmote(txtTituloEntrada.Text);
            txtMsgSaida.Text = tratarEmote(txtMsgEntrada.Text);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMsgEntrada.Clear();
            txtMsgSaida.Clear();
            txtTituloEntrada.Clear();
            txtTituloSaida.Clear();
        }

        private void txtTituloEntrada_TextChanged(object sender, EventArgs e)
        { 
            int totalValue = 0;
            int limite = 50;
            //emote U+1F6D2
            if (txtTituloEntrada.Text.Contains(@"U+"))
                limite += 7;
    

            foreach (char item in txtTituloEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterTitulo.Text = "Caracters: " + totalValue;

            if (totalValue > limite)
                lblCaracterTitulo.ForeColor = Color.Red;
            if (totalValue <= limite)
                lblCaracterTitulo.ForeColor = Color.Black;
        }

        private void txtFraseSaida_TextChanged(object sender, EventArgs e)
        {
            int totalValue = 0;
            int limite = 200;

            if (txtTituloEntrada.Text.Contains(@"U+"))
                limite += 7;

            foreach (char item in txtMsgEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterMsg.Text = "Caracters: " + totalValue;

            if (totalValue > limite)
                lblCaracterMsg.ForeColor = Color.Red;
            if (totalValue <= limite)
                lblCaracterMsg.ForeColor = Color.Black;
        }
    
    
    }
}
