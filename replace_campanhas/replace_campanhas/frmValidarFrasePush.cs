using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace replace_campanhas
{
    public partial class frmValidarFrasePush : Form
    {
        public frmValidarFrasePush()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //
        //
        // METODOS
        //
        //
        public string tratarEmote(string entrada)
        {

            //if (entrada.Contains("U+"))
            //{
            //    //entrada = entrada.Replace(@"U+", "{");
            //    //entrada = entrada.Replace(@"u+", "{");
            //    //var indexInicial = entrada.LastIndexOf("{");
            //    //var insert = entrada.Insert(indexInicial + 6, "}");
            //    //return insert;
            //}
            LimparString ls = new LimparString();

            entrada = ls.SubstituirEmote(entrada);

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
            var quantidadeTitulo = tratarEmote(txtTituloEntrada.Text).Length;
            var quantidadeMsg = tratarEmote(txtMsgEntrada.Text).Length;
            
            
            if (quantidadeTitulo <= 50)
                txtTituloSaida.Text = tratarEmote(txtTituloEntrada.Text);
            else
                MessageBox.Show("Opa a seu titulo excede os 50 caracteres!"
                , "Aviso"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Warning);
            
            if (quantidadeMsg <= 200)
                txtMsgSaida.Text = tratarEmote(txtMsgEntrada.Text);
            else
                MessageBox.Show("Opa a sua mensagem excede os 200 caracteres!"
                , "Aviso"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Warning);

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

        private void btnCopiarTitulo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTituloSaida.Text);
        }

        private void btnCopiaMensagem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMsgSaida.Text);
        }
    }
}
