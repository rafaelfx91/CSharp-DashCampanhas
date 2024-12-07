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
    public partial class frmRCS4SolicitanteVisualizacao : Form
    {
        public frmRCS4SolicitanteVisualizacao()
        {
            InitializeComponent();
        }

        public frmRCS4SolicitanteVisualizacao(string titulo,string mensagem, string linkImg, string nomeBotao, string linkBotao)
        {
            InitializeComponent();
        }

        private void frmRCS4SolicitanteVisualizacao_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            pbMensagem.Visible=false;
            wbImagem.Visible=false;
        }

























    }
}
