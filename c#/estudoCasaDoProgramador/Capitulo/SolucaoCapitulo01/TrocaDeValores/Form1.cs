using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux = txtPrimeiroValor.Text;
            txtPrimeiroValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = aux;
            MessageBox.Show("Troca Realizada com Sucesso", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
