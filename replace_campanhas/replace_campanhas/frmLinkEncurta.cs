using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace replace_campanhas
{
    public partial class frmLinkEncurta : Form
    {
        public frmLinkEncurta()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Name = "Short links";
        }
        StringBuilder sb = new StringBuilder();
        SaveFileDialog saveFileDialog = new SaveFileDialog();


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
                saveFileDialog.Title = "Salvar Conteúdo da TextBox";
                saveFileDialog.FileName = "link.txt"; // Nome de arquivo padrão

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    //File.SaveTextBoxContentToFile(txtSaida.Text, filePath);
                    File.WriteAllText(filePath, txtSaida.Text);
                }
            }catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }
           
        }




        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            sb.AppendLine(txtCentrodecusto.Text.ToUpper()+" - "+txtLink.Text.ToUpper());
            txtLink.Text = "";
            txtSaida.Text = sb.ToString();
            txtLink.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            txtLink.Clear();
            txtCentrodecusto.Clear();
            sb.Clear(); 
        }
    }
}
