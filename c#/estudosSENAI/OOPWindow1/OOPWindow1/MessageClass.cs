using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPWindow1
{
    class MessageClass
    {
        public MessageClass(string msg)
        {
            MessageBox.Show("Programa de teste de conceitos de OOP, Data: " + msg);
        }
    }
    class Operacoes
    {
        private int numa = 0;
        private int numb = 0;

        public Operacoes()
        {

        }
        public int sum(int soma, int somb)
        {
            this.numa = soma;
            this.numb = somb;
            return this.numa + this.numb;
        }
        public int sub(int soma, int somb)
        {
            this.numa = soma;
            this.numb = somb;
            return this.numa - this.numb;
        }
        public float mult(int soma, int somb)
        {
            this.numa = soma;
            this.numb = somb;
            return this.numa * this.numb;
        }
        public float div(int soma, int somb)
        {
            this.numa = soma;
            this.numb = somb;
            return this.numa / this.numb;
        }
    }
}
