using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmRepicks : Form
    {
        public frmRepicks()
        {
            InitializeComponent();
        }
        private void frmRepicks_Load(object sender, EventArgs e)
        {
            CarregarDadosParaCheckedListBox();
            CarregarDadosParaCheckedListBoxDoDiaAtual();
        }

        public string nomeArquivo = "chlistaRepick.txt";

        public void salvarListBox()
        {
           //gravarArquivo("listboxFazer.txt", lbFazer);
           //gravarArquivo("listboxHomologacao.txt", lbHomologacao);
           //gravarArquivo("listboxAgendamento.txt", lbAgendamento);
        }

        public void carregarListBox()
        {
           //carregarArquivo("listboxFazer.txt", lbFazer);
           //carregarArquivo("listboxHomologacao.txt", lbHomologacao);
           //carregarArquivo("listboxAgendamento.txt", lbAgendamento);
        }
       
        private void gravarArquivo(string nomeArquivo, ListBox listBox)
        {
            string diretorioExecutavel = Directory.GetCurrentDirectory();
            string caminhoCompleto = Path.Combine(diretorioExecutavel, nomeArquivo);

            using (StreamWriter sw = new StreamWriter(caminhoCompleto))
            {
                foreach (object item in listBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }

        private void carregarArquivo(string nomeArquivo, ListBox listBox)
        {
            // Verifica se o arquivo existe antes de tentar carregar
            if (File.Exists(nomeArquivo))
            {
                using (StreamReader sr = new StreamReader(nomeArquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        listBox.Items.Add(linha);
                    }
                }
            }
            else
            {
                // Trate o caso em que o arquivo não existe
                // Por exemplo, você pode exibir uma mensagem de erro ou lidar com isso de outra maneira
            }
        }


        private void CarregarDadosParaCheckedListBox()
        {
            
            string caminhoCompleto = Path.Combine(Directory.GetCurrentDirectory(), nomeArquivo);

            if (File.Exists(caminhoCompleto))
            {
                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoCompleto);

                // Loop através de cada linha para adicionar os dados na CheckedListBox
                foreach (string linha in linhas)
                {
                    // Divide a linha pelos caracteres ',' e ' ' para obter a data e o nome
                    string[] dados = linha.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Verifica se a linha tem a formatação correta (data e nome)
                    if (dados.Length >= 2)
                    {
                        // Adiciona o item à CheckedListBox com a data e o nome
                        chkListaRepicks.Items.Add($"{dados[0]} - {dados[1]}");
                    }
                    else
                    {
                        // Se a linha não estiver no formato correto, você pode lidar com isso de acordo com suas necessidades
                        Console.WriteLine("Linha inválida: " + linha);
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo não existe!");
            }
        }

        private void CarregarDadosParaCheckedListBoxDoDiaAtual()
        {
           
            string caminhoCompleto = Path.Combine(Directory.GetCurrentDirectory(), nomeArquivo);
            string dataAtual = DateTime.Today.ToString("dd/MM/yyyy");

            // Verifica se o arquivo existe
            if (File.Exists(caminhoCompleto))
            {
                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoCompleto);

                // Loop através de cada linha para adicionar os dados na CheckedListBox
                foreach (string linha in linhas)
                {
                    // Divide a linha pelos caracteres ',' e ' ' para obter a data e o nome
                    string[] dados = linha.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Verifica se a linha tem a formatação correta (data e nome)
                    if (dados.Length >= 2 && dados[0] == dataAtual)
                    {
                        // Adiciona o item à segunda CheckedListBox com a data e o nome
                        chkRepicksHoje.Items.Add($"{dados[0]} - {dados[1]}");
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo não existe!");
            }
        }

        private void AbrirOuCriarArquivoLista()
        {
            string caminhoCompleto = Path.Combine(Directory.GetCurrentDirectory(), nomeArquivo);

            // Verifica se o arquivo existe
            if (File.Exists(caminhoCompleto))
            {
                // Abre o arquivo com o aplicativo padrão associado a ele
                Process.Start(caminhoCompleto);
            }
            else
            {
                // Se o arquivo não existe, cria o arquivo
                using (FileStream fs = File.Create(caminhoCompleto))
                {
                    MessageBox.Show("Arquivo criado: " + caminhoCompleto);
                }
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirOuCriarArquivoLista();
        }
    }
}
