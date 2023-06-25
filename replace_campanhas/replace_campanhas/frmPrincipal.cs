using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        private Mutex mutex;
        private FuncoesDeveloper fd;

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
            fd = new FuncoesDeveloper(args);
            //MessageBox.Show(args[0]);
        }

        //private void Form1_Load(object sender, EventArgs e)
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Verion: V2.21 Alfa";
            desabilitaForms();

            if (VerificaProgramaEmExecucao())
            {
                //MessageBox.Show("Programa já está em execução.");
                TragaProgramaExistenteParaFrente();
                Application.Exit();
            }
            else
                mutex = new Mutex(true, MutexName);
        }

        public void teste()
        {
            var nome = Environment.MachineName;
            var nomeCompleto = Dns.GetHostEntry(nome).HostName;
            MessageBox.Show(nome);
            MessageBox.Show(nomeCompleto);
        }

        public void desabilitaForms()
        {
            //if (fd.validaConfigsDev2())
            if (fd.validaConfigsDev3())
            {
                agendamentoEmailJIRAToolStripMenuItem.Visible = true;
                checklistToolStripMenuItem.Visible = true;
                aGENDAMENTOCAMPANHASToolStripMenuItem.Visible = true;
                testarLinksToolStripMenuItem.Visible = true;
                testeToolStripMenuItem.Visible = true;
                emotesToolStripMenuItem.Visible = true;
                emailDeDiagramaToolStripMenuItem.Visible = true;
            }
            else
            {
                agendamentoEmailJIRAToolStripMenuItem.Visible = false;
                checklistToolStripMenuItem.Visible = false;
                aGENDAMENTOCAMPANHASToolStripMenuItem.Visible = false;
                testarLinksToolStripMenuItem.Visible = false;
                testeToolStripMenuItem.Visible = false;
                emotesToolStripMenuItem.Visible = false;
                emailDeDiagramaToolStripMenuItem.Visible = false;
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

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (mutex != null)
        //        {
        //            mutex.ReleaseMutex();
        //            mutex.Dispose();
        //        }
        //    }
        //    base.Dispose(disposing);
        //}


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

    }
}

