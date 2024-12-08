using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmRCS4SolicitanteVisualizacao : Form
    {
        string titulo = "";
        string msg = "";
        string linkImg = "";
        string linkBtn = "";
        string nomeBtn = "";

        public frmRCS4SolicitanteVisualizacao()
        {
            InitializeComponent();
        }

        public frmRCS4SolicitanteVisualizacao(string titulo, string mensagem, string linkImg, string nomeBotao, string linkBotao)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.msg = mensagem;
            this.linkImg = linkImg;
            this.linkBtn = linkBotao;
            this.nomeBtn = nomeBotao;
        }

        private void frmRCS4SolicitanteVisualizacao_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            pbMensagem.Visible = false;
            wbImagem.Visible = false;
            txtMsg.Visible = false;
            txtMsg.ReadOnly = true;
            txtTitulo.Visible = false;
            txtTitulo.ReadOnly = true;
            btnLink.Visible = false;
            
            

            preencheDados();

            

        }

        public void preencheDados()
        {
            if (titulo != "")
            {
                txtTitulo.Visible = true;
                txtTitulo.Text = titulo;
                pbMensagem.Visible = true;
            }
            if (msg != "")
            {
                txtMsg.Visible = true;
                txtMsg.Text = msg;
                pbMensagem.Visible = true;
            }
            if (linkImg != "")
            {
                wbImagem.Visible = true;
                wbImagem.Navigate(linkImg);
            }
            if (linkBtn != "")
            {
                btnLink.Click += txtLink_Click;
            }
            if (nomeBtn != "")
            {
                btnLink.Visible = true;
                btnLink.Text = nomeBtn;
            }

        }

        private void txtLink_Click(object sender, EventArgs e)
        {
            // Verifica se o linkBtn contém um link válido
            if (!string.IsNullOrWhiteSpace(linkBtn) && Uri.IsWellFormedUriString(linkBtn, UriKind.Absolute))
            {
                try
                {
                    // Abre o link no navegador padrão
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = linkBtn,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O link fornecido não é válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

