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
    public partial class frmGeradordeSenhas : Form
    {
        private FuncoesDeveloper fd;

        public frmGeradordeSenhas()
        {
            InitializeComponent();
        }

        public frmGeradordeSenhas(FuncoesDeveloper fd)
        {
            InitializeComponent();
            this.fd = fd;
            
        }

        private void frmGeradordeSenhas_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            habilitaTextbox();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var variavelconstrucaodesenha = "";
            txtSenha.Text = "";
            Random rnd = new Random();

            //constroi a variavel com todos os caracters 
            if (chkNumeros.Checked)
                variavelconstrucaodesenha += txtNumeros.Text;
            if (chkLetrasminusculas.Checked)
                variavelconstrucaodesenha += txtLetrasminusculas.Text;
            if (chkLetrasmaiusculas.Checked)
                variavelconstrucaodesenha += txtLetrasmaiusculas.Text;
            if (chkCaracteresespeciais.Checked)
                variavelconstrucaodesenha += txtCaracteresespeciais.Text;

            try
            {
                for (int quantiadesenhas = 0; quantiadesenhas < Int32.Parse(txtQuantiadeSenhasgeradas.Text); quantiadesenhas++)
                {
                    for (int aux = 0; aux < Int32.Parse(txtTamanhosenha.Text); aux++)
                    {
                        txtSenha.Text += variavelconstrucaodesenha[rnd.Next(variavelconstrucaodesenha.Length)];
                    }
                    txtSenha.Text += System.Environment.NewLine;

                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTamanhosenha.Text) > 1)
                txtTamanhosenha.Text = Convert.ToString(Convert.ToInt32(txtTamanhosenha.Text) - 1);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtTamanhosenha.Text = Convert.ToString(Convert.ToInt32(txtTamanhosenha.Text) + 1);
        }

        private void btnMenosQuantiadesenhasgeradas_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtQuantiadeSenhasgeradas.Text) > 1)
                txtQuantiadeSenhasgeradas.Text = Convert.ToString(Convert.ToInt32(txtQuantiadeSenhasgeradas.Text) - 1);
        }

        private void btnmaisQuantiadesenhasgeradas_Click(object sender, EventArgs e)
        {
            txtQuantiadeSenhasgeradas.Text = Convert.ToString(Convert.ToInt32(txtQuantiadeSenhasgeradas.Text) + 1);
        }
    
        public void habilitaTextbox()
        {
            if (fd.validaConfigsDev3())
            {
                txtTamanhosenha.ReadOnly = false;
                txtQuantiadeSenhasgeradas.ReadOnly = false;   
            }


        }//habilitaTextbox


    }
}
