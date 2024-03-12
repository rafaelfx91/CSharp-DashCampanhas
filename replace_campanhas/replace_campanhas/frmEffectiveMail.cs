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
    public partial class frmEffectiveMail : Form
    {
        private FuncoesDeveloper fd;

        public frmEffectiveMail()
        {
            InitializeComponent();
        }

        public frmEffectiveMail(FuncoesDeveloper fd)
        {
            InitializeComponent();
            this.fd = fd;
            this.MinimumSize = new Size(720, 700);
        }

        private void frmEffectiveMail_Load(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            btnLimpar.Visible= false;   

            cbTemas.Text = "1";
            //cbTemas.Enabled= false;

            if (fd.validaConfigsDev3())
            {
                txtCaminhoArquivo.ReadOnly = false;
                txtCaminhoArquivo.Visible = true;
            }
            
            wbPecaEmail.Navigate(txtCaminhoArquivo.Text);
            wbPecaEmail.DocumentCompleted += WebBrowser1_DocumentCompleted;

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            wbPecaEmail.Navigate(txtCaminhoArquivo.Text);
            wbPecaEmail.DocumentCompleted += WebBrowser1_DocumentCompleted;

        }//btnAbrir_Click

        public void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Criar uma tag link para a folha de estilo
            HtmlElement head = wbPecaEmail.Document.GetElementsByTagName("head")[0];
            HtmlElement link = wbPecaEmail.Document.CreateElement("link");

            link.SetAttribute("rel", "stylesheet");
            link.SetAttribute("type", "text/css");
            link.SetAttribute("href", "data:text/css;base64," + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(GetCss())));

            head.AppendChild(link);

            FillTextBox(0,1);

        }//WebBrowser1_DocumentCompleted

        public string GetCss()
        {
            var temas = cbTemas.SelectedIndex;

            switch (temas)
            {
                case 0:
                    return @"#principal {width: 150% !important;}
                            html {background-color: silver !important;}
                            #ctl00_Conteudo_btnCarregar {background-color: black !important;}
                            .cmxform {background-color: silver !important;}";
                    case 1:
                default:
                    return "";
            }

            // Retorna o CSS como uma string
           //return @"
           //    #principal {
           //        width: 150% !important;
           //    }
           //    html {
           //        background-color: silver !important;
           //    }
           //    #ctl00_Conteudo_btnCarregar {
           //        background-color: black !important;
           //    }
           //    .cmxform {
           //        background-color: silver !important;
           //    }
           //";
        }//GetCss()

        private void FillTextBox(int user, int senha)
        {
            wbPecaEmail.Document.GetElementById("txtUsuario").SetAttribute("value", fd.getEffectveEmailUsers(user) );
            wbPecaEmail.Document.GetElementById("txtSenha").SetAttribute("value", fd.getEffectveEmailUsers(senha));

            //wbPecaEmail.Document.GetElementById("txtUsuario").SetAttribute("value", "teste");
            //wbPecaEmail.Document.GetElementById("txtSenha").SetAttribute("value", "123");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }//btnClose

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //int largura = this.Width;
            //int altura = this.Height;
            //MessageBox.Show($"A largura da forma é {largura} e a altura é {altura}", "Tamanho da Forma", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }//ntmlimpar
    }
}
