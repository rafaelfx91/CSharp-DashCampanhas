using HtmlAgilityPack;
using IronXL;
using SixLabors.ImageSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace replace_campanhas
{
    public partial class frmValidaHtml : Form
    {
        public frmValidaHtml()
        {
            InitializeComponent();
        }
        private void frmValidaHtml_Load(object sender, EventArgs e)
        {
            //this.MaximizeBox = false;
        }

        //
        //
        //
        //
        //
        public void carregaHtmlWebbroser(string caminhohtml)
        {
            wbPecaEmail.Navigate(caminhohtml.Trim());
        }

        public void camposCoringas(string caminhohtml)
        {
            var conteudoArquivo = caminhohtml;
             

        }
        public int validaNomeHtml(string caminhoarquivo)
        {
            string caminhoArquivo = txtCaminhoArquivo.Text;
            string nomeHtml = System.IO.Path.GetFileName(caminhoArquivo);
            LimparString ls = new LimparString();

            if (ls.verificaChars(nomeHtml) == 1)
                return 1;
            
            return 0;

        }
        


        //
        //
        //
        //
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            var caminhoArquivo = @"C:\Users\rafae\OneDrive\Área de Trabalho\Claro\OSBarbara.html";

            wbPecaEmail.Navigate(caminhoArquivo);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            wbPecaEmail.Navigate("");
            txtCaminhoArquivo.Clear();
            txtCoringas.Clear();
            lblCoringas.Text = "Coringas";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Title = "Selecionar Arquivo";
                openFileDialog1.Filter = "Web|*.html|" +
                                         "Texto|*.txt;*.dat;*.csv|" +
                                         "Todos os arquivos|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    txtCaminhoArquivo.Text = openFileDialog1.FileName;


                if (validaNomeHtml(txtCaminhoArquivo.Text) == 1)
                {
                    throw new Exception("Opa o nome do seu arquivo nao pode possuir espaços ou caracteres especiais!\n"
                                       + "exemplo: OS123.html");
                    //MessageBox.Show("Opa o nome do seu arquivo nao pode possuir espaços ou caracteres especiais!"
                    //                + "exemplo: OS123.html"
                    //                , "Aviso"
                    //                , MessageBoxButtons.OK
                    //                , MessageBoxIcon.Warning);

                }
                else
                { 
                    carregaHtmlWebbroser(txtCaminhoArquivo.Text);
                    var countCoringas = 0;
                    var htmlFile = txtCaminhoArquivo.Text;
                    string htmlText = File.ReadAllText(htmlFile);
                    MatchCollection matches = Regex.Matches(htmlText, "<\\$.*?\\$>");
                    foreach (Match match in matches)
                    {
                        string conteudoChaves = match.Value.Substring(2, match.Value.Length - 4);
                        //MessageBox.Show(" " + conteudoChaves);
                        txtCoringas.Text += "<$" + conteudoChaves + "$>" + " ; ";
                        countCoringas++;
                    }
                    lblCoringas.Text = "Campos coringas: " + countCoringas.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
            }


            //var abx = txtCaminhoArquivo.Text;
            //var fluxoDoArquivo = new FileStream(abx, FileMode.Open);
            //fluxoDoArquivo.Read();
            //var aux = fluxoDoArquivo.Split('$');
            //MessageBox.Show(aux[1] +"");
            //HtmlDocument doc = new HtmlDocument();
            //doc.Load(abx);
            //foreach (HtmlNode certidao in doc.DocumentNode.SelectNodes("//certidao"))
            //    foreach (HtmlNode subtag in certidao.SelectNodes("//subtag"))
            //        Console.WriteLine(subtag.InnerText);
            //System.Net.WebClient wc = new System.Net.WebClient();
            //
            //System.IO.Stream stream = wc.OpenRead(abx);
            //System.IO.StreamReader reader = new System.IO.StreamReader(stream);
            //var s = reader.ReadToEnd();
            //var a = s.Split('$');
            ////HtmlDocument doc = new HtmlDocument();
            ////doc.LoadHtml(s);
            //MessageBox.Show("" + a[1]);
            //string html = File.ReadAllText(abx.Trim());
            //using (FileStream fs = File.Open(html, FileMode.Open, FileAccess.ReadWrite))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        html = sr.ReadToEnd();
            //    }
            //}
            //using (StreamReader reader = new StreamReader(@"C:\Users\rafae\OneDrive\Área de Trabalho\Claro\D1_boasvindas.html"))
            //{
            //    string line = "";
            //    StringBuilder stringBuilder = new StringBuilder();
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        stringBuilder.Append(line);
            //    }
            //    Console.WriteLine(stringBuilder.ToString());
            //    Console.ReadLine();
            //}




        }


    }
}
