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

        }

 
        public void gravarCamposTxt()
        {

        }

        public void carregarCamposTxt()
        {

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





        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }
    }
}
