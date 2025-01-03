﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace_campanhas
{
    public partial class frmRCS4Solicitante : Form
    {
        LimparString ls = new LimparString();
        bool vizuImg, vizuBotao = true;

        public frmRCS4Solicitante()
        {
            InitializeComponent();
        }

        private void frmRCS4Solicitante_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        public void contarCaracter(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label, string mensagem, int limite)
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

        public static string GarantirHttps(string link)
        {
            // Remove espaços em branco ao redor
            link = link.Trim();

            // Verifica se o link começa com "http://" ou "https://"
            if (!link.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !link.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                // Adiciona "https://" ao link
                link = "https://" + link;
            }

            return link;
        }

        public void validaLinkEspaco(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label, int img_botao)
        {
            if (textBox.Text.Contains(" "))
            {
                if (img_botao == 1)
                    vizuImg = false;
                if (img_botao == 2)
                    vizuBotao = false;

                label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (img_botao == 1)
                    vizuImg = true;
                if (img_botao == 2)
                    vizuBotao = true;
                label.ForeColor = System.Drawing.Color.Green;

            }
            //return true;
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtLinkBotao.Text = "";
            txtTitulo.Text = "";
            txtLinkImg.Text = "";
            txtFrase.Text = "";
            txtNomeBotao.Text = "";
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string titulo = "";
            string msg = "";
            string linkImg = "";
            string linkBtn = "";
            string nomeBtn = "";

            txtFrase.Text = ls.fraseLimpa3_simples(txtFrase.Text);
            txtTitulo.Text = ls.fraseLimpa3_simples(txtTitulo.Text);

            if (!String.IsNullOrEmpty(txtTitulo.Text))
                titulo = txtTitulo.Text;
            if (!String.IsNullOrEmpty(txtFrase.Text))
                msg = txtFrase.Text;
            if (!String.IsNullOrEmpty(txtLinkImg.Text))
            {
                linkImg = txtLinkImg.Text;
                GarantirHttps(linkImg);
            }
            if (!String.IsNullOrEmpty(txtNomeBotao.Text))
                nomeBtn = txtNomeBotao.Text;
            if (!String.IsNullOrEmpty(txtLinkBotao.Text)) 
            { 
                linkBtn = txtLinkBotao.Text;
                GarantirHttps(linkBtn);
            }


            if (vizuImg)
            {
                if (vizuBotao)
                {
                    if (msg != "")
                    {
                        frmRCS4SolicitanteVisualizacao celular = new frmRCS4SolicitanteVisualizacao(titulo, msg, linkImg, nomeBtn, linkBtn);
                        celular.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sem Mensagem para visualizar o RCS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Reveja o link do botao", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }else
            {
                MessageBox.Show("Reveja o link da img", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                



            //    MessageBox.Show("Reveja os campos invalidos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


  


        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            contarCaracter(txtFrase,lblFrase, "Frase rcs", 200);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            contarCaracter(txtTitulo, lblTitulo, "Titulo rcs", 200);
        }

        private void txtNomeBotao_TextChanged(object sender, EventArgs e)
        {
            contarCaracter(txtNomeBotao, lblNomeBotao, "Frase do botao", 15);
        }

        private void txtLinkImg_TextChanged(object sender, EventArgs e)
        {
            validaLinkEspaco(txtLinkImg, lblLinkImg,1);
        }
        private void txtLinkBotao_TextChanged(object sender, EventArgs e)
        {
            validaLinkEspaco(txtLinkBotao,lblLinkBotao,2);
            

        }
    }
}
