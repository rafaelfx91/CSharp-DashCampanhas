using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//ing System.Windows.Forms.show;


namespace replace_campanhas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Verion: V2 Alfa";
            this.MaximizeBox = false;
        }


        //MENU NOME CAMPANHA
        private void gerarNomeNoSASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomeCampanhas frmnomeOsSAS = new frmNomeCampanhas
            {
                MdiParent = this
            };
            frmnomeOsSAS.Show();
        }

        private void tbValidarCampanhas_Click(object sender, EventArgs e)
        {

        }

        private void validarFraseSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidaFraseSMS frmValidaFraseSMS = new frmValidaFraseSMS
            {
                MdiParent = this
            };
            frmValidaFraseSMS.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aGENDAMENTOCAMPANHASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamentoCampanha frmAgendarCampanhas = new frmAgendamentoCampanha
            {
                MdiParent = this
            };
            frmAgendarCampanhas.Show();
        }

        private void geradorDeSenhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeradordeSenhas frmSenhas = new frmGeradordeSenhas
            {
                MdiParent = this
            };
            frmSenhas.Show();

        }

        private void validarFrasePUSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidarFrasePush frmPush = new frmValidarFrasePush
            {
                MdiParent = this
            };
            frmPush.Show();

        }

        private void validarHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidaHtml html = new frmValidaHtml
            {
                MdiParent = this
            };
            html.Show();
        }
    }
}

