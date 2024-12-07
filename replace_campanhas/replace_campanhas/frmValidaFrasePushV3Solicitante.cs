using SixLabors.Fonts.Unicode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace replace_campanhas
{
    public partial class frmValidaFrasePushV3Solicitante : Form
    {
        public bool mostrarEmote = false;
        public frmValidaFrasePushV3Solicitante()
        {
            InitializeComponent();
        }

        private void frmValidaFrasePushV3Solicitante_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        //
        //METODOS
        //
        public void mudarImagemPush()
        {
            if(rdClaroPay.Checked)
                pbPushLogo.Image = Properties.Resources.ClaroCP;
            if (rdMinahClaroMovel.Checked)
                pbPushLogo.Image = Properties.Resources.minhaClaroMovel;
            if (rdClaroResidencial.Checked)
                pbPushLogo.Image = Properties.Resources.minhaClaroResidencial;

            pbPushLogo.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void tamanhoTitulo()
        {
            int totalValue = 0;
            foreach (char item in txtTituloEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterTitulo.Text = "Caracters no titulo: " + totalValue + " / 50";

            if (totalValue >= 51)
                lblCaracterTitulo.ForeColor = Color.Red;
            if (totalValue < 51)
                lblCaracterTitulo.ForeColor = Color.Green;
        }
        public void tamanhoMensagem()
        {
            int totalValue = 0;
            foreach (char item in txtMsgEntrada.Text)
            {
                totalValue = totalValue + 1;
            }
            lblCaracterMsg.Text = "Caracters na mensagem: " + totalValue + " / 200";

            if (totalValue >= 201)
                lblCaracterMsg.ForeColor = Color.Red;
            if (totalValue < 201)
                lblCaracterMsg.ForeColor = Color.Green;

        }
        public void contarCaracter(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label, string mensagem, int limite )
        {
            // Define o limite de caracteres
            int LimiteCaracteres = limite;

            //Define a mensagel da label
            string labelMensagem = mensagem;

            // Contador de caracteres
            int contador = 0;
            int i = 0;
            string texto = textBox.Text;

            while (i < texto.Length)
            {
                // Verifica se há uma sequência {XXXXX}
                if (texto[i] == '{')
                {
                    int fimChave = texto.IndexOf('}', i);
                    if (fimChave != -1)
                    {
                        // Ignora toda a sequência {XXXXX} e conta como 1 caractere
                        contador++;
                        i = fimChave + 1; // Avança para depois da chave de fechamento
                    }
                    else
                    {
                        // Se não houver '}', conta o caractere '{' normalmente
                        contador++;
                        i++;
                    }
                }
                else
                {
                    // Conta caracteres normais
                    contador++;
                    i++;
                }
            }

            // Atualiza o texto do Label com a contagem
            label.Text = $"{labelMensagem}: {contador}/{LimiteCaracteres}";

            // Atualiza a cor do Label com base no limite
            if (contador > LimiteCaracteres)
                label.ForeColor = Color.Red; // Excedeu o limite
            else if (contador == 0)
                label.ForeColor = Color.Black;
            else
                label.ForeColor = Color.Green; // Dentro do limite

        }
        public void ConverterParaFormato(System.Windows.Forms.TextBox textBox)
        {
            // Pega o texto atual do TextBox
            string input = textBox.Text;

            // Expressão regular para identificar padrões como U+00A ou {U+00a}, mas não {000}
            string pattern = @"(?:U\+|{)([0-9A-Fa-f]{3,})(?:}|$)";  // Identifica U+000 ou {000}

            // Substitui o padrão encontrado pelo formato desejado, mas verifica se já está no formato correto
            string result = Regex.Replace(input, pattern, m =>
            {
                // Verifica se o código já está no formato {000}
                if (m.Value.StartsWith("{") && m.Value.EndsWith("}"))
                {
                    // Se já estiver no formato {000}, não faz nada
                    return m.Value;
                }
                // Pega o valor hexadecimal e transforma para maiúsculo
                string hexValue = m.Groups[1].Value.ToUpper();
                return $"{{{hexValue}}}";  // Substitui por {HEX}
            });

            // Atualiza o conteúdo do TextBox com o texto modificado
            textBox.Text = result;
        }









        //
        //BOTOES
        //
        private void rdClaroPay_CheckedChanged(object sender, EventArgs e)
        {
            mudarImagemPush();
        }
        private void txtTituloEntrada_TextChanged(object sender, EventArgs e)
        {
            contarCaracter(txtTituloEntrada, lblCaracterTitulo, "Caracter no titulo", 50);
            
        }
        private void txtMsgEntrada_TextChanged(object sender, EventArgs e)
        {
            //tamanhoMensagem();
            contarCaracter(txtMsgEntrada,lblCaracterMsg,"Caracter na mensagem",200);
            

        }
        private void btnMostrarEmote_Click(object sender, EventArgs e)
        {
            LimparString ls = new LimparString();
            string btnMostrar = "Mostrar emote";
            string btnEsconder = "Esconder emote";
            //string btnGerar = btnMostrarEmote.Text;


            switch (btnMostrar)
            {
                case "Mostrar emote":
                    txtTituloEntrada.Text = ls.CodigoParaEmote(txtTituloEntrada.Text);
                    txtMsgEntrada.Text = ls.CodigoParaEmote(txtMsgEntrada.Text);
                   // btnMostrarEmote.Text = btnEsconder;
                    break;
                case "Esconder emote":
                    txtTituloEntrada.Text = ls.EmoteParaCodigo2(txtTituloEntrada.Text);
                    txtMsgEntrada.Text = ls.EmoteParaCodigo2(txtMsgEntrada.Text);
                    //btnMostrarEmote.Text = btnMostrar;
                    break;
                default:
                    break;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMsgEntrada.Clear();
            txtTituloEntrada.Clear();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtMsgEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                // Cancela o comportamento padrão do Enter (como mudança de foco)
                e.SuppressKeyPress = true;

                // Obtém o TextBox que gerou o evento
                System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

                if (textBox != null)
                {
                    // Adiciona {000A} seguido de uma nova linha
                    int cursorPosition = textBox.SelectionStart;
                    string novaLinha = "{000A}" + Environment.NewLine;
                    textBox.Text = textBox.Text.Insert(cursorPosition, novaLinha);

                    // Move o cursor para o início da nova linha
                    textBox.SelectionStart = cursorPosition + novaLinha.Length;
                }
            }
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            if (txtTituloEntrada.BorderStyle == BorderStyle.None)
            {
                txtTituloEntrada.BorderStyle = BorderStyle.Fixed3D;
                txtMsgEntrada.BorderStyle = BorderStyle.Fixed3D;
                lblCaracterMsg.Visible = true;
                lblCaracterTitulo.Visible = true;
                btnVisualizar.Text = "Visualizar";
                ConverterParaFormato(txtMsgEntrada);
                ConverterParaFormato(txtTituloEntrada);
            }
            else
            {
                txtTituloEntrada.BorderStyle = BorderStyle.None;
                txtMsgEntrada.BorderStyle = BorderStyle.None;
                lblCaracterMsg.Visible = false;
                lblCaracterTitulo.Visible = false;
                btnVisualizar.Text = "Voltar";
                ConverterParaFormato(txtMsgEntrada);
                ConverterParaFormato(txtTituloEntrada);
            }


        }
    }
}
