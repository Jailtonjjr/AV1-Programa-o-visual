using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora1
{
    public partial class Form1: Form
    {
        private double num1 = 0; 
        private double num2 = 0; 
        private string operation = ""; 

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            text1.Text = "0";
        }
        private void Funcao_botao(string numero)
        {
            if (text1.Text == "0")
                text1.Text = " ";
            text1.Text = text1.Text += numero;

        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "1";
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "2";
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "3";
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "4";
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "5";
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "6";
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "7";

        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "8";
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "9";
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + "0";
        }
        private void Btnmais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text1.Text))
            {

            }
            else
            {
                num1 = Convert.ToDouble(text1.Text);
                operation = "+";
                text1.Text = " ";
            }
        }
        private void Btnmenos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text1.Text))
            {

            }
            else
            {
                num1 = Convert.ToDouble(text1.Text);
                operation = "-";
                text1.Text = " ";
            }
        }
        private void Btnvezes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text1.Text))
            {

            }
            else
            {
                num1 = Convert.ToDouble(text1.Text);
                operation = "*";
                text1.Text = " ";
            }
        }
        private void Btndivisao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text1.Text))
            {

            }
            else
            {


                num1 = Convert.ToDouble(text1.Text);
                operation = "/";
                text1.Text = " ";
            }
        }
        private void Btnequal_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(text1.Text))
            {
                
            }
            
            else
            {
                num2 = Convert.ToDouble(text1.Text);
                switch (operation)
                {
                    case "+":
                        text1.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        text1.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        text1.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if (num2 != 0)
                            text1.Text = (num1 / num2).ToString();
                        else
                            text1.Text = "Erro";
                        break;
                    default:
                        break;
                }
            }
            num1 = 0; 
            num2 = 0; 
            operation = ""; 

        }
        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            text1.Text = " "; 
            num1 = 0;
            num2 = 0;
            operation = "";
        }


        private void Btnvirgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text1.Text))
            {

            }
            else
            {
                text1.Text = text1.Text + ",";
            }
        }
    }
}
