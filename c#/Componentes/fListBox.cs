using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fListBox : Form
    {
        List<string> carros = new List<string>();
        public fListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lbxCarros.DataSource = carros;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCarro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
                txtCarro.Focus();
            }
            else
            {
                carros.Add(txtCarro.Text);                
                atualizarListBox(lbxCarros, carros);
                txtCarro.Clear();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lbxCarros.SelectedIndex);
            atualizarListBox(lbxCarros, carros);
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            txtCarro.Text = carros[lbxCarros.SelectedIndex];
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizarListBox(lbxCarros, carros);
        }
        private void atualizarListBox(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }
    }
}
