using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fComboBox : Form
    {
        public fComboBox()
        {
            InitializeComponent();
        }

        private void btnMostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbTransportes.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbTransportes.Items.Clear();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            cbTransportes.Items.AddRange(tr.ToArray());
        }

        private void cbTransportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTransporte.Text = cbTransportes.Text;
        }

        private void btnAdicionarTransporte_Click(object sender, EventArgs e)
        {
            if(txtTransporte.Text != "")
            {
                if (cbTransportes.FindString(txtTransporte.Text) < 0)
                {
                    cbTransportes.Items.Add(txtTransporte.Text);
                }
                txtTransporte.Clear();
                txtTransporte.Focus();
            }
        }
    }
}
