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
    public partial class frmOSs : Form
    {
        public frmOSs()
        {
            InitializeComponent();
        }
        
        private void frmOSs_Load(object sender, EventArgs e)
        {
            this.MaximizeBox= false;

            lbAgendamento.Items.Clear();
            lbFazer.Items.Clear();
            lbHomologacao.Items.Clear();

            lbAgendamento.SelectionMode = SelectionMode.One;
            lbFazer.SelectionMode = SelectionMode.One;
            lbHomologacao.SelectionMode = SelectionMode.One;

            carregarListBox();

        }
        
        private void MoveItem(ListBox sourceListBox, ListBox destinationListBox)
        {
            // Obter o item selecionado na ListBox de origem
            object selectedItem = sourceListBox.SelectedItem;

            // Adicionar o item à ListBox de destino
            destinationListBox.Items.Add(selectedItem);

            // Remover o item da ListBox de origem
            sourceListBox.Items.Remove(selectedItem);
        }
        
        public void ordernarLista()
        {
            lbAgendamento.Sorted = true;
            lbFazer.Sorted = true;
            lbHomologacao.Sorted = true;

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
        
        public void salvarListBox()
        {
            gravarArquivo("listboxFazer.txt",lbFazer);
            gravarArquivo("listboxHomologacao.txt",lbHomologacao);
            gravarArquivo("listboxAgendamento.txt",lbAgendamento);
        }
        
        public void carregarListBox()
        {
            carregarArquivo("listboxFazer.txt", lbFazer);
            carregarArquivo("listboxHomologacao.txt", lbHomologacao);
            carregarArquivo("listboxAgendamento.txt", lbAgendamento);
        }



        /// <summary>
        /// 
        /// </summary>

        private void btnAdicionaALista_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNomeOs.Text))
            {
                lbFazer.Items.Add(txtNomeOs.Text);
               // lbHomologacao.Items.Add(txtNomeOs.Text);
                txtNomeOs.Clear();
            }
            ordernarLista();
        }
        
        private void lbFazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHomologacao.ClearSelected();
            lbAgendamento.ClearSelected();
        }
        
        private void lbHomologacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFazer.ClearSelected();
            lbAgendamento.ClearSelected();
        }
        
        private void lbAgendamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFazer.ClearSelected();
            lbHomologacao.ClearSelected();
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            salvarListBox();
            this.Close();
        }
        
        private void btnMoveDireita_Click(object sender, EventArgs e)
        {
            if (lbFazer.SelectedItem != null)
            {
                MoveItem(lbFazer, lbHomologacao); // Move da listBox1 para listBox2
            }
            else if (lbHomologacao.SelectedItem != null)
            {
                MoveItem(lbHomologacao, lbAgendamento); // Move da listBox2 para listBox3
            }
            ordernarLista();
            salvarListBox();
        }
        
        private void btnMoveEsquerda_Click(object sender, EventArgs e)
        {
            if (lbAgendamento.SelectedItem != null)
            {
                MoveItem(lbAgendamento, lbHomologacao); // Move da listBox3 para listBox2
            }
            else if (lbHomologacao.SelectedItem != null)
            {
                MoveItem(lbHomologacao, lbFazer); // Move da listBox2 para listBox1
            }
            ordernarLista();
            salvarListBox();
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbFazer.SelectedItem != null)
                lbFazer.Items.Remove(lbFazer.SelectedItem);

            if (lbHomologacao.SelectedItem != null)
                lbHomologacao.Items.Remove(lbHomologacao.SelectedItem);

            if (lbAgendamento.SelectedItem != null)
                lbAgendamento.Items.Remove(lbAgendamento.SelectedItem);

            ordernarLista();
            salvarListBox();
        }




    }//fim
}
