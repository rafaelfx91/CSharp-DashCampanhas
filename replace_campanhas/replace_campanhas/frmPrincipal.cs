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
        private const bool debugVisual = true;
        //private const bool debugVisual = false;

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
                string [] args2 = { "-devS", "-cryptS123", "-emUuserEM" ,"-emSsenhaEM","-Fab","-n2" };//dev
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
                lblVersion.Text = "Versão: V3.5FN";

            desabilitaForms();

            if (VerificaProgramaEmExecucao())
            {
                //MessageBox.Show("Programa já está em execução.");
                TragaProgramaExistenteParaFrente();
                Application.Exit();
            }
           
        }

        public void desabilitaForms()
        {

            //SAS Menu
            gerarNomeNoSASV2ToolStripMenuItem.Visible = false;
            sASToolStripMenuItem.Visible = false;
            chamadoRedmineToolStripMenuItem.Visible = false;
            //SMS Menu            
            validaFraseV2ToolStripMenuItem.Visible = false;
            //Push menu 
            validarFrasePUSHToolStripMenuItem.Visible = false;
            claroPayToolStripMenuItem.Visible = false;
            //Html Menu
            validarHtmlToolStripMenuItem.Visible = false;
            //RCS Menu
            RCS2validacaoToolStripMenuItem.Visible = false;
            RCS1validacaoToolStripMenuItem.Visible = false;
            RCS3validacaoToolStripMenuItem.Visible = false;
            //Outros menu
            hIKEToolStripMenuItem.Visible = false;
            testeToolStripMenuItem.Visible = false;
            encriptadorToolStripMenuItem.Visible = false;
            porcentagemToolStripMenuItem.Visible = false;
            oSsToolStripMenuItem.Visible = false;
            //stringUpLowerToolStripMenuItem.Visible = false;
            //fERRAMENTASToolStripMenuItem.Visible = false;
            repicksToolStripMenuItem.Visible = false;



            // parametro -devS habilitado
            if (fd.validaConfigsDev3())
            {
                //SAS menu
                sASToolStripMenuItem.Visible = true;
                gerarNomeNoSASV2ToolStripMenuItem.Visible = true;

                //SMS Menu
                validaFraseV2ToolStripMenuItem.Visible = true;
                
                //Push Menu
                validarFrasePUSHToolStripMenuItem.Visible = true;
                claroPayToolStripMenuItem.Visible = true;
                
                //html menu
                validarHtmlToolStripMenuItem.Visible = true;
                
                //RCS MENU
                RCS2validacaoToolStripMenuItem.Visible = true;
                RCS1validacaoToolStripMenuItem.Visible = true;
                RCS3validacaoToolStripMenuItem.Visible = true;

                //OpcoesMENU
                fERRAMENTASToolStripMenuItem.Visible = true;
                //stringUpLowerToolStripMenuItem.Visible = true;
                encriptadorToolStripMenuItem.Visible = true;
                porcentagemToolStripMenuItem.Visible = true;
                oSsToolStripMenuItem.Visible = true;
                repicksToolStripMenuItem.Visible = true;

                lblVersion.Text += " -DEV";

                

                
            }

            if (fd.returnFabrifa())
            {
                //Sas Menu
                sASToolStripMenuItem.Visible = true;
                gerarNomeNoSASV2ToolStripMenuItem.Visible = true;
                chamadoRedmineToolStripMenuItem.Visible = true;

                //SMS Menu
                validaFraseV2ToolStripMenuItem.Visible = true;

                //OpcoesMENU
                fERRAMENTASToolStripMenuItem.Visible = true;

                lblVersion.Text += " -FAB";

            }


                //parametro -cryptS habilitado
            if (fd.validaSenhaCrypt2())
            {
                encriptadorToolStripMenuItem.Visible = true;
            }
            else
            {
                encriptadorToolStripMenuItem.Visible = false;
            }

            //sem parametro apenas se rodar no visual studio
            if (debugVisual)
            {
                testeToolStripMenuItem.Visible = true;
                hIKEToolStripMenuItem.Visible = true;
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





        //
        //
        //BOTOES
        //
        //

        //SAS MENU
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
        private void agendamentoCampanhasV2EmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmAgendamentoCamapanhaV2Email")
                {
                    form.Activate();
                    return;
                }
            }
            frmAgendamentoCamapanhaV2Email novoFormFilho = new frmAgendamentoCamapanhaV2Email(fd);
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void chamadosN2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form form in this.MdiChildren)
            //{
            //    if (form.Name == "frmAgendamentos")
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            //frmAgendamentos novoFormFilho = new frmAgendamentos(fd);
            //novoFormFilho.MdiParent = this;
            //novoFormFilho.Show();
        }

        //SMS MENU
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
        private void validaFraseV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaFraseSMSV2")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaFraseSMSV2 novoFormFilho = new frmValidaFraseSMSV2();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void validaSMSSolicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaFraseSMSV3Solicitante")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaFraseSMSV3Solicitante novoFormFilho = new frmValidaFraseSMSV3Solicitante();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void chamadoRedmineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmChamadosRedmine")
                {
                    form.Activate();
                    return;
                }
            }
            frmChamadosRedmine novoFormFilho = new frmChamadosRedmine();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        //PUSH MENU
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
        private void validarPUSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaFrasePushV3Solicitante")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaFrasePushV3Solicitante novoFormFilho = new frmValidaFrasePushV3Solicitante();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        //HTML MENU
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
        private void validaHtmlEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmValidaHtmlV2")
                {
                    form.Activate();
                    return;
                }
            }
            frmValidaHtmlV2 novoFormFilho = new frmValidaHtmlV2();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        private void trocaFraseologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmFraseologiaHtml")
                {
                    form.Activate();
                    return;
                }
            }
            frmFraseologiaHtml novoFormFilho = new frmFraseologiaHtml();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        //RCS MENU
        private void RCS1validacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmRCS1")
                {
                    form.Activate();
                    return;
                }
            }
            frmRCS1 novoFormFilho = new frmRCS1();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void RCS2validacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmRCS2")
                {
                    form.Activate();
                    return;
                }
            }
            frmRCS2 novoFormFilho = new frmRCS2();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void RCS3validacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmRCS3")
                {
                    form.Activate();
                    return;
                }
            }
            frmRCS3 novoFormFilho = new frmRCS3();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void validarRCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmRCS4Solicitante")
                {
                    form.Activate();
                    return;
                }
            }
            frmRCS4Solicitante novoFormFilho = new frmRCS4Solicitante();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        //OUTROS MENU
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
                MessageBox.Show("ERRO" + ex.Message);
            }

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
        private void hIKEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmHike")
                {
                    form.Activate();
                    return;
                }
            }
            frmHike novoFormFilho = new frmHike();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void oSsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmOSs")
                {
                    form.Activate();
                    return;
                }
            }
            frmOSs novoFormFilho = new frmOSs();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void repicksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmRepicks")
                {
                    form.Activate();
                    return;
                }
            }
            frmRepicks novoFormFilho = new frmRepicks();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }
        private void stringUpLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmUpLow")
                {
                    form.Activate();
                    return;
                }
            }
            frmUpLow novoFormFilho = new frmUpLow();
            novoFormFilho.MdiParent = this;
            novoFormFilho.Show();
        }

        //SAIR MENU
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //VERSAO MENU
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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }//fim
}

