using IronXL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//ing System.Windows.Forms.show;


namespace replace_campanhas
{
    public partial class frmPrincipal : Form
    {
        private const string MutexName = "PlusoftDash";
        //private Mutex mutex;
        private FuncoesDeveloper fd;
        //private const bool debugVisual = true;
        private const bool debugVisual = false;

        /*
         replace_campanhas.exe -devS -crypt123 -emUUSUSARIO -emSSENHA
         */

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public frmPrincipal()
        {
            InitializeComponent();
            this.MinimumSize = new Size(870, 700);
        }

        public frmPrincipal(string[] args)
        {
            InitializeComponent();
            this.MinimumSize = new Size(870, 700);
            if (debugVisual)
            {
                string [] args2 = { "-devS", "-cryptS123", "-emUuserEM" ,"-emSsenhaEM" };//dev
                fd = new FuncoesDeveloper(args2);//dev
            }
            else
            {
                fd = new FuncoesDeveloper(args);
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //lblVersion.Text = "Versão: V2.23E Alfa";
            if (debugVisual)
                lblVersion.Text = "Versão: DEBUG";
            else
                lblVersion.Text = "Versão: V2.29A";


            desabilitaForms();
            if (VerificaProgramaEmExecucao())
            {
                //MessageBox.Show("Programa já está em execução.");
                TragaProgramaExistenteParaFrente();
                Application.Exit();
            }
            //else  //DE MERDA REVER
              //  mutex = new Mutex(true, MutexName);
        }

        public void desabilitaForms()
        {
            // parametro -devS habilitado
            if (fd.validaConfigsDev3())
            {
                agendamentoEmailJIRAToolStripMenuItem.Visible = true;
                emailDeDiagramaToolStripMenuItem.Visible = true;
                encriptadorToolStripMenuItem.Visible = true;
                //envioDeEmailToolStripMenuItem.Visible = true;
                gerarNomeNoSASV2ToolStripMenuItem.Visible = true;
                textoEmUmaLinhaToolStripMenuItem.Visible = true;
                selectsToolStripMenuItem.Visible= true;
                porcentagemToolStripMenuItem.Visible = true;
            }
            else
            {
                agendamentoEmailJIRAToolStripMenuItem.Visible = false;
                emailDeDiagramaToolStripMenuItem.Visible = false;
                encriptadorToolStripMenuItem.Visible = false;
                gerarNomeNoSASV2ToolStripMenuItem.Visible = false;
                textoEmUmaLinhaToolStripMenuItem.Visible = false;
                selectsToolStripMenuItem.Visible = false;
                porcentagemToolStripMenuItem.Visible = false;
            }

            //parametro -cryptS habilitado
            if (fd.validaSenhaCrypt2())
                encriptadorToolStripMenuItem.Visible = true;
            else
                encriptadorToolStripMenuItem.Visible = false;

            //sem parametro apenas se rodar no visual studio
            if (debugVisual)
            {
                geradorDeExcellStripMenuItem.Visible = true;
                //testarLinksToolStripMenuItem.Visible = true;
                testeToolStripMenuItem.Visible = true;
                //envioDeEmailToolStripMenuItem.Visible = true;
                //aGENDAMENTOCAMPANHASToolStripMenuItem.Visible = true;
                //checklistToolStripMenuItem.Visible = true;
            }
            else
            {
                geradorDeExcellStripMenuItem.Visible = false;
                //testarLinksToolStripMenuItem.Visible = false;
                //envioDeEmailToolStripMenuItem.Visible = false; 
                //aGENDAMENTOCAMPANHASToolStripMenuItem.Visible = false;
                //checklistToolStripMenuItem.Visible = false;
                testeToolStripMenuItem.Visible = false;

            }


        }

        public static bool VerificaProgramaEmExecucao()
        {
            return Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1;
            //Process currentProcess = Process.GetCurrentProcess();
            //Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            //return processes.Length > 1;
        }

        private void TragaProgramaExistenteParaFrente()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);

            foreach (Process process in processes)
            {
                if (process.Id != currentProcess.Id)
                {
                    SetForegroundWindow(process.MainWindowHandle);
                    break;
                }
            }
        }






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
            frmGeradordeSenhas novoFormFilho = new frmGeradordeSenhas(fd);
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
            frmAgendamentoCampanhaJira novoFormFilho = new frmAgendamentoCampanhaJira(fd);
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void agendamentoEmailJIRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmGerarEmailJira")
                {
                    form.Activate();
                    return;
                }
            }
            frmGerarEmailJira novoFormFilho = new frmGerarEmailJira(fd);
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void emailDeDiagramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmGerarEmailDiagrama")
                {
                    form.Activate();
                    return;
                }
            }
            frmGerarEmailDiagrama novoFormFilho = new frmGerarEmailDiagrama();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void encriptadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmEncriptador")
                {
                    form.Activate();
                    return;
                }
            }
            frmEncriptador novoFormFilho = new frmEncriptador(fd);
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)//TESTE rapido e facil
        {
            try
            {

                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "frmTeste")
                    {
                        form.Activate();
                        return;
                    }
                }
                frmTeste novoFormFilho = new frmTeste();
                novoFormFilho.MdiParent = this;
                novoFormFilho.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO"+ex.Message);
            }

        }

        private void geradorDeExcellStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmEditaExcell")
                {
                    form.Activate();
                    return;
                }
            }
            frmEditaExcell novoFormFilho = new frmEditaExcell();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();

        }

        private void gerarNomeNoSASV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmNomeCampanhasV2")
                {
                    form.Activate();
                    return;
                }
            }
            frmNomeCampanhasV2 novoFormFilho = new frmNomeCampanhasV2();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void textoEmUmaLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmRemoveEspacamento")
                {
                    form.Activate();
                    return;
                }
            }
            frmRemoveEspacamento novoFormFilho = new frmRemoveEspacamento();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void effectiveMailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmEffectiveMail")
                {
                    form.Activate();
                    return;
                }
            }
            frmEffectiveMail novoFormFilho = new frmEffectiveMail(fd);
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();


        }

        private void selectsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmSelects")
                {
                    form.Activate();
                    return;
                }
            }
            frmSelects novoFormFilho = new frmSelects(fd);
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();

        }

        private void porcentagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmPorcentagem")
                {
                    form.Activate();
                    return;
                }
            }
            frmPorcentagem novoFormFilho = new frmPorcentagem();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            if (fd.validaConfigsDev3())
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }
        }



    }//fim
}

