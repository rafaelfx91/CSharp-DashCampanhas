using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            carregaArquivoNaChkList();
            carregaArquivoDiaDeHoje();
        }


        public string nomeArquivo = "chlistaRepick.txt";

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

        public void carregaArquivoNaChkList()
        {
            string caminhoCompleto = Path.Combine(Directory.GetCurrentDirectory(), nomeArquivo);

            if (File.Exists(caminhoCompleto))
            {
                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoCompleto);

                // Lista para armazenar objetos LinhaData
                List<LinhaData> linhasOrdenadas = new List<LinhaData>();

                // Loop através de cada linha para adicionar à lista
                foreach (string linha in linhas)
                {
                    // Divide a linha pelos caracteres ',' e ' ' para obter a data e o nome
                    string[] dados = linha.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Verifica se a linha tem a formatação correta (data e nome)
                    if (dados.Length >= 2)
                    {
                        // Converte a primeira parte da linha para DateTime
                        if (DateTime.TryParseExact(dados[0], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                        {
                            // Adiciona a linha e a data à lista de objetos LinhaData
                            linhasOrdenadas.Add(new LinhaData { Linha = linha, Data = data });
                        }
                        else
                        {
                            // Se a linha não estiver no formato correto, você pode lidar com isso de acordo com suas necessidades
                            Console.WriteLine("Linha inválida: " + linha);
                        }
                    }
                    else
                    {
                        // Se a linha não estiver no formato correto, você pode lidar com isso de acordo com suas necessidades
                        Console.WriteLine("Linha inválida: " + linha);
                    }
                }

                // Ordena a lista de objetos LinhaData por data
                linhasOrdenadas.Sort((x, y) => x.Data.CompareTo(y.Data));

                // Adiciona os itens ordenados à CheckedListBox
                foreach (var item in linhasOrdenadas)
                {
                    chkListaRepicks.Items.Add($"{item.Data.ToString("dd/MM/yyyy")} - {item.Linha}");
                }
            }
            else
            {
                Console.WriteLine("O arquivo não existe!");
            }
        }

        public void carregaArquivoDiaDeHoje()
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirOuCriarArquivoLista();
        }
    }
}
