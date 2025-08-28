using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmHtmlCP : Form
    {
        private string nomeArquivoLink = "DashPlusoftLinksMartech.txt";
        private string CaminhoNomeArquivoLink;
        const string TAGBTNLINK = "btnlinks";

        public frmHtmlCP()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            lbBotoesLink.Items.Clear();
            CaminhoNomeArquivoLink = Path.Combine(Application.StartupPath, nomeArquivoLink);
            carregaListBox();

        }
        ///
        /// FUNCOES
        ///
        public void SalvarListBoxParaTxt(ListBox listBox, string caminhoArquivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    // Tag de abertura
                    writer.WriteLine("---BTNLINK---");

                    // Conteúdo da ListBox
                    foreach (var item in listBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }

                    // Tag de encerramento
                    writer.WriteLine("---/BTNLINK---");
                }

                MessageBox.Show("ListBox salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }  
        //modular posso salvar com o nome que quiser
        public void SalvarListBoxParaTxt(ListBox listBox, string caminhoArquivo, string tagNome = "BTNLINK", bool append = false)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, append))
                {
                    // Tag de abertura personalizada
                    writer.WriteLine($"---{tagNome}---");

                    // Conteúdo da ListBox
                    foreach (var item in listBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }

                    // Tag de encerramento personalizada
                    writer.WriteLine($"---/{tagNome}---");

                    // Linha em branco para separar seções
                    if (append)
                    {
                        writer.WriteLine();
                    }
                }

                MessageBox.Show($"ListBox '{tagNome}' salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar {tagNome}: {ex.Message}");
            }
        }
        //salvar varias lista em sequencia
        public void SalvarMultiplasListBox(string caminhoArquivo, params (ListBox listBox, string tagNome)[] listas)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, false))
                {
                    foreach (var (listBox, tagNome) in listas)
                    {
                        writer.WriteLine($"---{tagNome}---");

                        foreach (var item in listBox.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }

                        writer.WriteLine($"---/{tagNome}---");
                        writer.WriteLine(); // Linha separadora
                    }
                }

                MessageBox.Show("Todas as ListBox salvas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar múltiplas listas: {ex.Message}");
            }
        }
        //carrega a listbox versao simples
        public void CarregarListBoxDeTxt(ListBox listBox, string caminhoArquivo)
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    MessageBox.Show("Arquivo não encontrado!");
                    return;
                }

                listBox.Items.Clear();
                bool dentroDaSecao = false;

                foreach (string linha in File.ReadAllLines(caminhoArquivo))
                {
                    if (linha.Trim() == "---BTNLINK---")
                    {
                        dentroDaSecao = true;
                        continue;
                    }

                    if (linha.Trim() == "---/BTNLINK---")
                    {
                        dentroDaSecao = false;
                        break;
                    }

                    if (dentroDaSecao && !string.IsNullOrWhiteSpace(linha))
                    {
                        listBox.Items.Add(linha.Trim());
                    }
                }

                MessageBox.Show("ListBox carregada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar: {ex.Message}");
            }
        }
       //funcao carrega as multiplas list box 
        public void CarregarMultiplasListBox(string caminhoArquivo, params (ListBox listBox, string tagNome)[] listas)
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    MessageBox.Show("Arquivo não encontrado!");
                    return;
                }

                // Limpa todas as listas primeiro
                foreach (var (listBox, _) in listas)
                {
                    listBox.Items.Clear();
                }

                string[] linhas = File.ReadAllLines(caminhoArquivo);
                string tagAtual = null;
                ListBox listBoxAtual = null;

                foreach (string linha in linhas)
                {
                    string linhaTrim = linha.Trim();

                    // Verifica se é uma tag de abertura
                    if (linhaTrim.StartsWith("---") && linhaTrim.EndsWith("---") && !linhaTrim.StartsWith("---/"))
                    {
                        tagAtual = linhaTrim.Trim('-');
                        listBoxAtual = EncontrarListBoxPorTag(tagAtual, listas);
                        continue;
                    }

                    // Verifica se é uma tag de fechamento
                    if (linhaTrim.StartsWith("---/") && linhaTrim.EndsWith("---"))
                    {
                        tagAtual = null;
                        listBoxAtual = null;
                        continue;
                    }

                    // Se está dentro de uma seção e a linha não está vazia
                    if (listBoxAtual != null && !string.IsNullOrWhiteSpace(linha))
                    {
                        listBoxAtual.Items.Add(linhaTrim);
                    }
                }

                MessageBox.Show("Conteúdo carregado e distribuído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar: {ex.Message}");
            }
        }
        // Função auxiliar para encontrar a ListBox pela tag
        private ListBox EncontrarListBoxPorTag(string tag, (ListBox listBox, string tagNome)[] listas)
        {
            foreach (var (listBox, tagNome) in listas)
            {
                if (tagNome.Equals(tag, StringComparison.OrdinalIgnoreCase))
                {
                    return listBox;
                }
            }
            return null;
        }
        //organiza as list box
        private void sortListBox()
        {
            lbBotoesLink.Sorted = true;
        }
        private void carregaListBox()
        {
            CarregarMultiplasListBox(CaminhoNomeArquivoLink,
                                    (lbBotoesLink, TAGBTNLINK)
                                    );
        }








        /// 
        /// BOTOES
        /// 
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbBotoesLink.Items.Clear();
        }
        private void btnCarregar_Click(object sender, EventArgs e)
        {

        }
        private void btnAddBtn_Click(object sender, EventArgs e)
        {
            lbBotoesLink.Items.Add(txtAddLinkBtn.Text);
            txtAddLinkBtn.Clear();
            txtAddLinkBtn.Focus();
        }
        private void btnExcBtn_Click(object sender, EventArgs e)
        {
            // Remove o item atualmente selecionado
            if (lbBotoesLink.SelectedIndex != -1)
            {
                lbBotoesLink.Items.RemoveAt(lbBotoesLink.SelectedIndex);
            }
        }
        private void btnSalvarTabs_Click(object sender, EventArgs e)
        {
            //SalvarListBoxParaTxt(lbBotoesLink, CaminhoNomeArquivoLink);//botoes
            SalvarMultiplasListBox(CaminhoNomeArquivoLink,
                                    (lbBotoesLink, TAGBTNLINK)//botoes
                                    );

        }
        private void btnCarregaTabs_Click(object sender, EventArgs e)
        {
            carregaListBox();
            

        }

        private void btnBtnsTestLink_Click(object sender, EventArgs e)
        {
            if (lbBotoesLink.Items.Count > 0)
            {
                string url = lbBotoesLink.SelectedItem.ToString();
                wbView.Navigate(url);
            }
        }
    }
}
