using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;   

            float total = float.Parse(numero1) + float.Parse(numero2);

            lbResultado.Text = total.ToString(); 
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) - float.Parse(numero2);

            lbResultado.Text = total.ToString();


        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) / float.Parse(numero2);

            lbResultado.Text = total.ToString();

        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {


            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) * float.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void btnmaiormenor_Click(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbNumero3.Text);

            if (numero3 < 0)
            {
                lbResultado2.Text = "O numero digitado é MENOR que 0";
            }
            else
            {
                lbResultado2.Text = "O numero digitado é MAIOR QUE 0";
            }
           


        }

        private void btnImparPar_Click(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbpar1.Text);


            if(numero3 % 2 == 0)
            {
                lbResultado3.Text = "Esse número é PAR!";
            }
            else
            {
                lbResultado3.Text = "Esse número é Ímpar!";
            }

        }

        private void Menor_Maior_Enter(object sender, EventArgs e)
        {

        }
    }
}
