using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        int faustao, silvio, gloria, madruga, branco, guigui = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionaNumero(string numero)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = numero;
            }
            else
            {
                textBox2.Text = numero;
                ValidarVoto();
            }
        }

        private void ValidarVoto()
        {
            switch (textBox1.Text + textBox2.Text)
            {
                case "11":
                    panel7.BackgroundImage = Image.FromFile("silvio.jpg");
                    lblNomeCandidato.Text = "Silvio Santos";
                    lblNomeCandidato.Visible = true;
                    break;
                case "21":
                    panel7.BackgroundImage = Image.FromFile("fausto.jpg");
                    lblNomeCandidato.Text = "Faustão";
                    lblNomeCandidato.Visible = true;
                    break;
                case "31":
                    panel7.BackgroundImage = Image.FromFile("gloria.jpg");
                    lblNomeCandidato.Text = "Gloria Maria";
                    lblNomeCandidato.Visible = true;
                    break;
                case "41":
                    panel7.BackgroundImage = Image.FromFile("Madruga.jpg");
                    lblNomeCandidato.Text = "Sr. Madruga";
                    lblNomeCandidato.Visible = true;
                    break;
                case "69":
                    panel7.BackgroundImage = Image.FromFile("guigui.jpg");
                    lblNomeCandidato.Text = "Guilherme Anastacio";
                    lblNomeCandidato.Visible = true;
                    break;
                case "24":
                    panel7.BackgroundImage = Image.FromFile("guigui.jpg");
                    lblNomeCandidato.Text = "Guilherme Anastacio";
                    lblNomeCandidato.Visible = true;
                    break;
                default:
                    MessageBox.Show("Você precisa informar um voto válido!");
                    Limpar();
                    break;
            }
        }

        private void Limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            panel7.BackgroundImage = null;
            lblNomeCandidato.Visible = false;
            lblNomeCandidato.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionaNumero("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdicionaNumero("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdicionaNumero("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdicionaNumero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdicionaNumero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdicionaNumero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdicionaNumero("7");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AdicionaNumero("8");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AdicionaNumero("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdicionaNumero("0");
        }


        private void button12_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            if (lblNomeCandidato.Text == "Voto em Branco")
            {
                branco++;
                lblNomeCandidato.Text = "";
                Limpar();
            }
            else
            {
                switch (textBox1.Text + textBox2.Text)
                {
                    case "11":
                        silvio++;
                        Limpar();
                        break;
                    case "21":
                        faustao++;
                        Limpar();
                        break;
                    case "31":
                        gloria++;
                        Limpar();
                        break;
                    case "41":
                        madruga++;
                        Limpar();
                        break;
                    case "69":
                        guigui++;
                        Limpar();
                        break;
                    case "24":
                        guigui++;
                        Limpar();
                        break;
                    default:
                        MessageBox.Show("Você precisa informar um voto válido!");
                        break;
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblNomeCandidato.Text = "Voto em Branco";
            lblNomeCandidato.Visible = true;
            
        }

        private void btnEncerrarVotacao_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado(silvio, faustao, gloria, madruga, branco, guigui);
            resultado.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Cadidatos cadidatos = new Cadidatos();
            cadidatos.ShowDialog();
        }
    }
}