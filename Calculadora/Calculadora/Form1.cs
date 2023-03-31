using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacao; double v1, v2; 
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operacao = "/";

            v1 = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtTexto.Text += ",";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacao = "+";

            v1 = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacao = "-";

            v1 = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacao = "*";

            v1 = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(txtTexto.Text);

            if (operacao == "+") txtTexto.Text = (v1 + v2).ToString();
            if (operacao == "-") txtTexto.Text = (v1 - v2).ToString();
            if (operacao == "*") txtTexto.Text = (v1 * v2).ToString();
            if (operacao == "/") txtTexto.Text = (v1 / v2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "9";
        }
    }
}
