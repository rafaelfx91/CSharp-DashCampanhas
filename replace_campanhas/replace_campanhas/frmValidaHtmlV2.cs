using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmValidaHtmlV2 : Form
    {
        private string caminhoArquivo = "";
        private string camposCoringas = "";
        private int countCoringas = 0;

        public frmValidaHtmlV2()
        {
            InitializeComponent();
        }
        private void frmValidaHtmlV2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        public void LimparCampos()
        {
            wbPecaEmail.Navigate("");
            txtAssunto.Text = "Assunto:";
            countCoringas = 0;
            caminhoArquivo = "";
            camposCoringas = "";
            btnCampoCoringa.Text = $"Mostrar campo coringa (0) ";
        }
        public void carregaHtmlWebbroser(string caminhohtml)
        {
            wbPecaEmail.Navigate(caminhohtml.Trim());
        }
        public int validaNomeHtml()
        {
            //string caminhoArquivo = txtCaminhoArquivo.Text;
            string nomeHtml = System.IO.Path.GetFileName(caminhoArquivo);
            LimparString ls = new LimparString();

            if (ls.verificaChars(nomeHtml) == 1)
                return 1;

            return 0;

        }














        private void btnAbrir_Click(object sender, EventArgs e)
        {
            LimparCampos();

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Title = "Selecionar Arquivo";
                openFileDialog1.Filter = "Web|*.html|" +
                                         "Texto|*.txt;*.dat;*.csv|" +
                                         "Todos os arquivos|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    caminhoArquivo = openFileDialog1.FileName;


                if (validaNomeHtml() == 1)
                {
                    throw new Exception("Opa o nome do seu arquivo nao pode possuir espaços ou caracteres especiais!\n"
                                       + "exemplo: OS123.html");
                }
                else
                {
                    carregaHtmlWebbroser(caminhoArquivo);
                    countCoringas = 0;
                    var htmlFile = caminhoArquivo;
                    string htmlText = File.ReadAllText(htmlFile);
                    MatchCollection matches = Regex.Matches(htmlText, "<\\$.*?\\$>");
                    foreach (Match match in matches)
                    {
                        string conteudoChaves = match.Value.Substring(2, match.Value.Length - 4);
                        //MessageBox.Show(" " + conteudoChaves);
                        camposCoringas += "<$" + conteudoChaves + "$>" + " ; ";
                        countCoringas++;
                    }
                    btnCampoCoringa.Text = $"Mostrar campo coringa ({countCoringas}) ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCampoCoringa_Click(object sender, EventArgs e)
        {
            if (countCoringas != 0)
            {
                frmValidaHtmlV2ListaCoringas coringas = new frmValidaHtmlV2ListaCoringas(camposCoringas);
                coringas.ShowDialog();
            }

            
        }
    }
}
