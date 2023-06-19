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
            this.MinimumSize = new Size(870, 700);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Verion: V2.15 Alfa";
            //this.MaximizeBox = false;
        }


        //MENU NOME CAMPANHA
        private void gerarNomeNoSASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmNomeCampanhas")
                {
                    form.Activate();
                    return;
                }
            }
            frmNomeCampanhas novoFormFilho = new frmNomeCampanhas();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void tbValidarCampanhas_Click(object sender, EventArgs e)
        {

        }

        private void validarFraseSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaFraseSMS")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaFraseSMS novoFormFilho = new frmValidaFraseSMS();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aGENDAMENTOCAMPANHASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmAgendamentoCampanha")
                {
                    form.Activate();
                    return;
                }
            }
            frmAgendamentoCampanha novoFormFilho = new frmAgendamentoCampanha();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void geradorDeSenhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmGeradordeSenhas")
                {
                    form.Activate();
                    return;
                }
            }
            frmGeradordeSenhas novoFormFilho = new frmGeradordeSenhas();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void validarFrasePUSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidarFrasePush")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidarFrasePush novoFormFilho = new frmValidarFrasePush();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void validarHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaHtml")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaHtml novoFormFilho = new frmValidaHtml();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void checklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmCheckList")
                {
                    form.Activate();
                    return;
                }
            }
            frmCheckList novoFormFilho = new frmCheckList();
            novoFormFilho.MdiParent = this;
            //novoFormFilho.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testarLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //foreach (Form form in this.MdiChildren)
           //{
           //    if (form.Name == "frmValidaLink")
           //    {
           //        form.Activate();
           //        return;
           //    }
           //}
           //frmValidaLink novoFormFilho = new frmValidaLink();
           //novoFormFilho.MdiParent = this;
           //novoFormFilho.Show();
        }

        private void claroPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaFrasePushV2")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaFrasePushV2 novoFormFilho = new frmValidaFrasePushV2();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void emotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendamentoCampanhasJIRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmAgendamentoCampanhaJira")
                {
                    form.Activate();
                    return;
                }
            }
            frmAgendamentoCampanhaJira novoFormFilho = new frmAgendamentoCampanhaJira();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
    }
}

