using IronXL;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmEditaExcell : Form
    {
        public frmEditaExcell()
        {
            InitializeComponent();
        }


        //Estrutura do excell
        //A - nome do job
        //B - amx
        //C - CAMPANHA*
        //D - NOME MALHA (VAZIO)*
        //E - tipo Agendar,Cancelar,Pausar
        //F - *variavel* do schedule exclusao, inclusao
        //G - Descrição CAMPANHA COMUN*
        //H - DEPENDENCIA (VAZIO)*
        //I - Canais SMS,RCS,WIB,PUSH,EMAIL
        //J - Periocidade "Segunda a Sexta" semanal, mensal
        //K - Dias da Semana Mesma coisa que a J
        //L - DIA DO MES (VAZIO)*
        //M - HORARIO DE EXECUÇÃO (*)
        //N - Horario de execução (09 as 21)
        //O - INTERERVALODE EXECUÇÂO (VAZIO)*
        //P - TEMPO MAXIMO (VAZIO)*
        //Q - Observação ( Triger)
        //
        public void adcicionaLinha()
        {

        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            var listaCampanhas = txtListaDeCampanhas.Text.Split(';');
            listaCampanhas = listaCampanhas.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //var listaAmx = txtListaDeCampanhas.Text.Split();
            //nome
            //amx
            //espaço vazio
            //nome

            WorkBook workBook = WorkBook.Load(txtCaminhoArquivo.Text);
            WorkSheet workSheet = workBook.WorkSheets[1];
            WorkSheet firstSheet = workBook.DefaultWorkSheet;

            string[] colunaA = { "A4", "A5", "A6", "A7", "A8", "A9", "A10", "A11", "A12", "A13", "A14", "A15", "A16", "A7", "A18", "A19", "A20", "A21", "A22", "A23", "A24", "A25", "A26", "A27", "A28", "A29", "A30", "A31", "A32", "A33", "A34", "A35", "A36", "A37", "A38", "A39", "A40", "A41", "A4", "A43", "A44", "A45", "A46", "A47", "A48", "A49", "A50", "A51", "A52", "A53", "A54", "A55", "A56", "A57", "A58", "A59", "A60", "A61", "A62", "A63", "A64", "A65", "A66", "A67", "A68", "A69", "A70", "A71", "A72", "A73" };
            string[] colunaB = { "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B7", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B4", "B43", "B44", "B45", "B46", "B47", "B48", "B49", "B50", "B51", "B52", "B53", "B54", "B55", "B56", "B57", "B58", "B59", "B60", "B61", "B62", "B63", "B64", "B65", "B66", "B67", "B68", "B69", "B70", "B71", "B72", "B73" };
            string[] colunaC = { "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15", "C16", "C7", "C18", "C19", "C20", "C21", "C22", "C23", "C24", "C25", "C26", "C27", "C28", "C29", "C30", "C31", "C32", "C33", "C34", "C35", "C36", "C37", "C38", "C39", "C40", "C41", "C4", "C43", "C44", "C45", "C46", "C47", "C48", "C49", "C50", "C51", "C52", "C53", "C54", "C55", "C56", "C57", "C58", "C59", "C60", "C61", "C62", "C63", "C64", "C65", "C66", "C67", "C68", "C69", "C70", "C71", "C72", "C73" };
            string[] colunaD = { "D4", "D5", "D6", "D7", "D8", "D9", "D10", "D11", "D12", "D13", "D14", "D15", "D16", "D7", "D18", "D19", "D20", "D21", "D22", "D23", "D24", "D25", "D26", "D27", "D28", "D29", "D30", "D31", "D32", "D33", "D34", "D35", "D36", "D37", "D38", "D39", "D40", "D41", "D4", "D43", "D44", "D45", "D46", "D47", "D48", "D49", "D50", "D51", "D52", "D53", "D54", "D55", "D56", "D57", "D58", "D59", "D60", "D61", "D62", "D63", "D64", "D65", "D66", "D67", "D68", "D69", "D70", "D71", "D72", "D73" };
            string[] colunaE = { "E4", "E5", "E6", "E7", "E8", "E9", "E10", "E11", "E12", "E13", "E14", "E15", "E16", "E7", "E18", "E19", "E20", "E21", "E22", "E23", "E24", "E25", "E26", "E27", "E28", "E29", "E30", "E31", "E32", "E33", "E34", "E35", "E36", "E37", "E38", "E39", "E40", "E41", "E4", "E43", "E44", "E45", "E46", "E47", "E48", "E49", "E50", "E51", "E52", "E53", "E54", "E55", "E56", "E57", "E58", "E59", "E60", "E61", "E62", "E63", "E64", "E65", "E66", "E67", "E68", "E69", "E70", "E71", "E72", "E73" };
            string[] colunaF = { "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "F13", "F14", "F15", "F16", "F7", "F18", "F19", "F20", "F21", "F22", "F23", "F24", "F25", "F26", "F27", "F28", "F29", "F30", "F31", "F32", "F33", "F34", "F35", "F36", "F37", "F38", "F39", "F40", "F41", "F4", "F43", "F44", "F45", "F46", "F47", "F48", "F49", "F50", "F51", "F52", "F53", "F54", "F55", "F56", "F57", "F58", "F59", "F60", "F61", "F62", "F63", "F64", "F65", "F66", "F67", "F68", "F69", "F70", "F71", "F72", "F73" };
            string[] colunaG = { "G4", "G5", "G6", "G7", "G8", "G9", "G10", "G11", "G12", "G13", "G14", "G15", "G16", "G7", "G18", "G19", "G20", "G21", "G22", "G23", "G24", "G25", "G26", "G27", "G28", "G29", "G30", "G31", "G32", "G33", "G34", "G35", "G36", "G37", "G38", "G39", "G40", "G41", "G4", "G43", "G44", "G45", "G46", "G47", "G48", "G49", "G50", "G51", "G52", "G53", "G54", "G55", "G56", "G57", "G58", "G59", "G60", "G61", "G62", "G63", "G64", "G65", "G66", "G67", "G68", "G69", "G70", "G71", "G72", "G73" };
            string[] colunaH = { "H4", "H5", "H6", "H7", "H8", "H9", "H10", "H11", "H12", "H13", "H14", "H15", "H16", "H7", "H18", "H19", "H20", "H21", "H22", "H23", "H24", "H25", "H26", "H27", "H28", "H29", "H30", "H31", "H32", "H33", "H34", "H35", "H36", "H37", "H38", "H39", "H40", "H41", "H4", "H43", "H44", "H45", "H46", "H47", "H48", "H49", "H50", "H51", "H52", "H53", "H54", "H55", "H56", "H57", "H58", "H59", "H60", "H61", "H62", "H63", "H64", "H65", "H66", "H67", "H68", "H69", "H70", "H71", "H72", "H73" };
            string[] colunaI = { "I4", "I5", "I6", "I7", "I8", "I9", "I10", "I11", "I12", "I13", "I14", "I15", "I16", "I7", "I18", "I19", "I20", "I21", "I22", "I23", "I24", "I25", "I26", "I27", "I28", "I29", "I30", "I31", "I32", "I33", "I34", "I35", "I36", "I37", "I38", "I39", "I40", "I41", "I4", "I43", "I44", "I45", "I46", "I47", "I48", "I49", "I50", "I51", "I52", "I53", "I54", "I55", "I56", "I57", "I58", "I59", "I60", "I61", "I62", "I63", "I64", "I65", "I66", "I67", "I68", "I69", "I70", "I71", "I72", "I73" };
            string[] colunaJ = { "J4", "J5", "J6", "J7", "J8", "J9", "J10", "J11", "J12", "J13", "J14", "J15", "J16", "J7", "J18", "J19", "J20", "J21", "J22", "J23", "J24", "J25", "J26", "J27", "J28", "J29", "J30", "J31", "J32", "J33", "J34", "J35", "J36", "J37", "J38", "J39", "J40", "J41", "J4", "J43", "J44", "J45", "J46", "J47", "J48", "J49", "J50", "J51", "J52", "J53", "J54", "J55", "J56", "J57", "J58", "J59", "J60", "J61", "J62", "J63", "J64", "J65", "J66", "J67", "J68", "J69", "J70", "J71", "J72", "J73" };
            string[] colunaK = { "K4", "K5", "K6", "K7", "K8", "K9", "K10", "K11", "K12", "K13", "K14", "K15", "K16", "K7", "K18", "K19", "K20", "K21", "K22", "K23", "K24", "K25", "K26", "K27", "K28", "K29", "K30", "K31", "K32", "K33", "K34", "K35", "K36", "K37", "K38", "K39", "K40", "K41", "K4", "K43", "K44", "K45", "K46", "K47", "K48", "K49", "K50", "K51", "K52", "K53", "K54", "K55", "K56", "K57", "K58", "K59", "K60", "K61", "K62", "K63", "K64", "K65", "K66", "K67", "K68", "K69", "K70", "K71", "K72", "K73" };
            string[] colunaL = { "L4", "L5", "L6", "L7", "L8", "L9", "L10", "L11", "L12", "L13", "L14", "L15", "L16", "L7", "L18", "L19", "L20", "L21", "L22", "L23", "L24", "L25", "L26", "L27", "L28", "L29", "L30", "L31", "L32", "L33", "L34", "L35", "L36", "L37", "L38", "L39", "L40", "L41", "L4", "L43", "L44", "L45", "L46", "L47", "L48", "L49", "L50", "L51", "L52", "L53", "L54", "L55", "L56", "L57", "L58", "L59", "L60", "L61", "L62", "L63", "L64", "L65", "L66", "L67", "L68", "L69", "L70", "L71", "L72", "L73" };
            string[] colunaM = { "M4", "M5", "M6", "M7", "M8", "M9", "M10", "M11", "M12", "M13", "M14", "M15", "M16", "M7", "M18", "M19", "M20", "M21", "M22", "M23", "M24", "M25", "M26", "M27", "M28", "M29", "M30", "M31", "M32", "M33", "M34", "M35", "M36", "M37", "M38", "M39", "M40", "M41", "M4", "M43", "M44", "M45", "M46", "M47", "M48", "M49", "M50", "M51", "M52", "M53", "M54", "M55", "M56", "M57", "M58", "M59", "M60", "M61", "M62", "M63", "M64", "M65", "M66", "M67", "M68", "M69", "M70", "M71", "M72", "M73" };
            string[] colunaN = { "N4", "N5", "N6", "N7", "N8", "N9", "N10", "N11", "N12", "N13", "N14", "N15", "N16", "N7", "N18", "N19", "N20", "N21", "N22", "N23", "N24", "N25", "N26", "N27", "N28", "N29", "N30", "N31", "N32", "N33", "N34", "N35", "N36", "N37", "N38", "N39", "N40", "N41", "N4", "N43", "N44", "N45", "N46", "N47", "N48", "N49", "N50", "N51", "N52", "N53", "N54", "N55", "N56", "N57", "N58", "N59", "N60", "N61", "N62", "N63", "N64", "N65", "N66", "N67", "N68", "N69", "N70", "N71", "N72", "N73" };
            string[] colunaO = { "O4", "O5", "O6", "O7", "O8", "O9", "O10", "O11", "O12", "O13", "O14", "O15", "O16", "O7", "O18", "O19", "O20", "O21", "O22", "O23", "O24", "O25", "O26", "O27", "O28", "O29", "O30", "O31", "O32", "O33", "O34", "O35", "O36", "O37", "O38", "O39", "O40", "O41", "O4", "O43", "O44", "O45", "O46", "O47", "O48", "O49", "O50", "O51", "O52", "O53", "O54", "O55", "O56", "O57", "O58", "O59", "O60", "O61", "O62", "O63", "O64", "O65", "O66", "O67", "O68", "O69", "O70", "O71", "O72", "O73" };
            string[] colunaP = { "P4", "P5", "P6", "P7", "P8", "P9", "P10", "P11", "P12", "P13", "P14", "P15", "P16", "P7", "P18", "P19", "P20", "P21", "P22", "P23", "P24", "P25", "P26", "P27", "P28", "P29", "P30", "P31", "P32", "P33", "P34", "P35", "P36", "P37", "P38", "P39", "P40", "P41", "P4", "P43", "P44", "P45", "P46", "P47", "P48", "P49", "P50", "P51", "P52", "P53", "P54", "P55", "P56", "P57", "P58", "P59", "P60", "P61", "P62", "P63", "P64", "P65", "P66", "P67", "P68", "P69", "P70", "P71", "P72", "P73" };
            string[] colunaQ = { "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "Q10", "Q11", "Q12", "Q13", "Q14", "Q15", "Q16", "Q7", "Q18", "Q19", "Q20", "Q21", "Q22", "Q23", "Q24", "Q25", "Q26", "Q27", "Q28", "Q29", "Q30", "Q31", "Q32", "Q33", "Q34", "Q35", "Q36", "Q37", "Q38", "Q39", "Q40", "Q41", "Q4", "Q43", "Q44", "Q45", "Q46", "Q47", "Q48", "Q49", "Q50", "Q51", "Q52", "Q53", "Q54", "Q55", "Q56", "Q57", "Q58", "Q59", "Q60", "Q61", "Q62", "Q63", "Q64", "Q65", "Q66", "Q67", "Q68", "Q69", "Q70", "Q71", "Q72", "Q73" };



            for (int i = 0; i < listaCampanhas.Count(); i++)
            {
                if (rdrAgendamento.Checked)
                {

                }
                if (rdrCancelamento.Checked)
                {
                    workSheet[colunaA[i]].Value = listaCampanhas[i];
                    workSheet[colunaB[i]].Value = listaCampanhas[i];
                    workSheet[colunaC[i]].Value = "CAMPANHA";
                    workSheet[colunaD[i]].Value = "";
                    workSheet[colunaE[i]].Value = "DELETAR";
                    workSheet[colunaF[i]].Value = "Exclusao do schedule";
                    workSheet[colunaG[i]].Value = "Campanha comum";
                    workSheet[colunaH[i]].Value = "";
                    workSheet[colunaI[i]].Value = "";//sms push 
                    workSheet[colunaJ[i]].Value = "";
                    workSheet[colunaK[i]].Value = "";
                    workSheet[colunaL[i]].Value = "";
                    workSheet[colunaM[i]].Value = "";
                    workSheet[colunaN[i]].Value = "";
                    workSheet[colunaO[i]].Value = "";
                    workSheet[colunaP[i]].Value = "";
                    workSheet[colunaQ[i]].Value = "";
                    


                }
                if (rdrPausa.Checked)
                {

                }
            }

            workBook.SaveAs("C:\\Users\\rafae\\OneDrive\\Área de Trabalho\\Claro\\Agendamento_claro\\sample.xlsx");



        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmEditaExcell_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtCaminhoArquivo.Text = "";
            //var caminho = "C:\\Users\\rafae\\OneDrive\\Área de Trabalho\\Claro\\Agendamento_claro\\teste.xlsx";
            //WorkBook workBook = WorkBook.Load(caminho);
            //WorkSheet workSheet = workBook.WorkSheets[1];
            //WorkSheet firstSheet = workBook.DefaultWorkSheet;
            //var cellValue = workSheet["A4"].StringValue;
            //MessageBox.Show(cellValue);
            //workSheet["A4"].Value = "TESTE";
            //workBook.SaveAs("sample.xlsx");

            try
            {
                OpenFileDialog abrirArquivo = new OpenFileDialog();
                abrirArquivo.InitialDirectory = "c:\\";
                abrirArquivo.Title = "Selecionar Arquivo";
                abrirArquivo.Filter = "Excel|.xlsx|" +
                "Todos os arquivos|*.*";
                if (abrirArquivo.ShowDialog() == DialogResult.OK)
                    txtCaminhoArquivo.Text = abrirArquivo.FileName;

                //WorkBook workBook = WorkBook.Load(txtCaminhoArquivo.Text);
                //WorkSheet workSheet = workBook.WorkSheets[1];
                //WorkSheet firstSheet = workBook.DefaultWorkSheet;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                , "Aviso"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Warning);
            }


        }
    }
}
