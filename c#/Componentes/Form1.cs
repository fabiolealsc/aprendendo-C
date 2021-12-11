using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class formComponentes : Form
    {
        public int num;
        public formComponentes()
        {
            InitializeComponent();
            num = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtVeiculo.Text == "") {
                MessageBox.Show("Digite um Veículo!");
                txtVeiculo.Focus();
                return;
            }

            txtListaVeiculos.Text += txtVeiculo.Text + ", ";
            txtVeiculo.Clear();
            txtVeiculo.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtListaVeiculos.Clear();
            txtVeiculo.Clear();
            txtVeiculo.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            fVeiculos fVeiculo = new fVeiculos(txtListaVeiculos.Text, this);
            fVeiculo.ShowDialog();
        }

        private void btnValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
    }
}
