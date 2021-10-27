using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPWindow1
{
    public partial class Form1 : Form
    {
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime hj = DateTime.Today;
            MessageClass primeiraMsg = new MessageClass(hj.ToString("d"));
        }



        private void somaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void somaB_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            count++;
            Operacoes calc = new Operacoes();
            int res = calc.sum(int.Parse(somaA.Text), int.Parse(somaB.Text));
            listBox1.Items.Add("O resultado da " + count + "º Operação Soma é: " + res);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            count++;
            Operacoes calc = new Operacoes();
            int res = calc.sub(int.Parse(somaA.Text), int.Parse(somaB.Text));
            listBox1.Items.Add("O resultado da " + count + "º Operação Subtração é: " + res);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            count++;
            Operacoes calc = new Operacoes();
            float res = calc.mult(int.Parse(somaA.Text), int.Parse(somaB.Text));
            listBox1.Items.Add("O resultado da " + count + "º Operação Multiplicação é: " + res);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            count++;
            Operacoes calc = new Operacoes();
            float res = calc.div(int.Parse(somaA.Text), int.Parse(somaB.Text));
            listBox1.Items.Add("O resultado da " + count + "º Operação Divisão é: " +  res);
        }
    }
}
