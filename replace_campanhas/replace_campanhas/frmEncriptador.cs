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
       
        private crypto cp = new crypto();
        private FuncoesDeveloper fd;
        private bool senhaVisivel = false;

        public frmEncriptador()
        {
            InitializeComponent();
        }

        public frmEncriptador(FuncoesDeveloper fd)
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            txtSenha.Text = fd.validaSenhaCrypt();
            //txtSenha.Text = senha;
        }

        public void limpaTxt()
        {
            txtFraseEntrada.Clear();
            txtFraseSaida.Clear();
            //txtSenha.Clear();
        }









        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtFraseSaida.Clear();
            try
            {
                if (!String.IsNullOrEmpty(txtSenha.Text))
                {
                    if (rdrEncripta.Checked)
                        txtFraseSaida.Text = cp.Encrypt(txtFraseEntrada.Text, txtSenha.Text);
                    if (rdrDecripta.Checked)
                        txtFraseSaida.Text = cp.Decrypt(txtFraseEntrada.Text, txtSenha.Text);
                }
                else
                {
                    txtSenha.Text = "123";
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Verifique se a senha esta correta","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTxt();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel; // Alterna o estado da exibição da senha
            if (senhaVisivel)
                txtSenha.PasswordChar = '\0'; // Exibe a senha (caracteres visíveis)
            else
                txtSenha.PasswordChar = '*'; // Oculta a senha (caracteres substituídos por '*')

        }
    }
}
