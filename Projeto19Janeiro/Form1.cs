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

namespace Projeto18Janeiro
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "1";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "0";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "8";

        }

        private void B9_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "9";
        }

        private void Soma_Click(object sender, EventArgs e)
        {  if (Resultado.Text != "")
            {

                 valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                 Resultado.Text = "";
                 operacao = "Soma";
                 Opera.Text = "+";
            }
   
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "6";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "3";
        }

        private void Mult_Click(object sender, EventArgs e)
        {  if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "Mult";
                Opera.Text = "x";
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "Sub";
                Opera.Text = "-";
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "Div";
                Opera.Text = "/";
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            operacao = "";
            Resultado.Text = "";
            Opera.Text = "OPERAÇÃO";Opera.ForeColor = Color.White;
            valor1 = 0; valor2 = 0;
           
        }

        private void Igual_Click(object sender, EventArgs e)
        {
     
            valor2 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            if (operacao=="Soma")
            {
                Resultado.Text = Convert.ToString(valor1 + valor2);
               
            }
            if (operacao == "Sub")
            {
                Resultado.Text = Convert.ToString(valor1 - valor2);

            }
            if (operacao == "Mult")
            {
                
                Resultado.Text = Convert.ToString(valor1 * valor2);

            }
            if (operacao == "Div")
            {
                if (valor1 < valor2)
                {
                    Resultado.Text = "Divisão inválida";
                    Resultado.ForeColor = Color.Red;
                }
                else
                {
                    Resultado.Text = Convert.ToString(valor1 / valor2);
                }
                

            }
            
            
        }
    }
}
