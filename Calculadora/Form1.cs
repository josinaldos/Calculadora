using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            TxtResultado.Text = " ";
        }

        private void button10_Click(object sender, EventArgs e) {
            TxtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            LabelOperacao.Text = "";
        }

        private void button13_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button20_Click(object sender, EventArgs e) {
            //concatenando o número 0
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button21_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e) {
            //aqui vamos pegar o valor1 e
            //armazenar o texto TxtResultado
            //dentro dela

            if (TxtResultado.Text != "") {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                //Limpando o TxtResultado
                TxtResultado.Text = "";
                //informar para o programa que é uma soma
                operacao = "SOMA";
                //informar para o usuário a operação que estamos usando
                LabelOperacao.Text = "+";
            }
        }

        private void button15_Click(object sender, EventArgs e) {

            //pegando o valor2
            valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            //verificando qual é a operação matemática
            if (operacao == "SOMA") {

                /*colocando a soma de valor1 e valor2 no campo de texto
                 * da calculadora, lembrando que a calculadora está uma string, 
                 por isso estamos convertendo para string o que tinhamos convertido
                em decimal */
                TxtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "MULT") {
                TxtResultado.Text = Convert.ToString(valor1 * valor2);
            } else if (operacao == "SUB") {
                TxtResultado.Text = Convert.ToString(valor1 - valor2);
            } else {
                TxtResultado.Text = Convert.ToString(valor1 / valor2);
            } 
        }

        private void button9_Click(object sender, EventArgs e) {

            if (TxtResultado.Text != "") {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = " ";

                operacao = "SUB";

                LabelOperacao.Text = "-";
            }
        }

        private void button14_Click(object sender, EventArgs e) {

            if(TxtResultado.Text != "") {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = " ";

                operacao = "MULT";

                LabelOperacao.Text = "*";

            }
     
        }

        private void button22_Click(object sender, EventArgs e) {

            if (TxtResultado.Text != "") {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = " ";

                operacao = "DIV";

                LabelOperacao.Text = "/";

            }
        }
    }
}
