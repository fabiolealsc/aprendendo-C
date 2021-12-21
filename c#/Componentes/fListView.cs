using System;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fListView : Form
    {
        public fListView()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            txtPreco.Clear();
            txtId.Clear();
            txtProd.Clear();
            txtQuant.Clear();
        }
        private void obter()
        {
            txtId.Text = lvProdutos.SelectedItems[0].SubItems[0].Text;
            txtProd.Text = lvProdutos.SelectedItems[0].SubItems[1].Text;
            txtQuant.Text = lvProdutos.SelectedItems[0].SubItems[2].Text;
            txtPreco.Text = lvProdutos.SelectedItems[0].SubItems[3].Text;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio");
                txtId.Focus();
                return;
            }
            if (txtProd.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio");
                txtProd.Focus();
                return;
            }
            if (txtQuant.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazio");
                txtQuant.Focus();
                return;
            }
            if (txtPreco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio");
                txtPreco.Focus();
                return;
            }
            else
            {
                string[] pr = new string[4];
                pr[0] = txtId.Text;
                pr[3] = txtPreco.Text;
                pr[2] = txtQuant.Text;
                pr[1] = txtProd.Text;

                ListViewItem l = new ListViewItem(pr);
                lvProdutos.Items.Add(l);
                limpar();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lvProdutos.Items.RemoveAt(lvProdutos.SelectedIndices[0]);
        }

        private void btnObter_Click(object sender, EventArgs e)
        {

            try
            {
                txtId.Text = lvProdutos.SelectedItems[0].SubItems[0].Text;
                txtProd.Text = lvProdutos.SelectedItems[0].SubItems[1].Text;
                txtQuant.Text = lvProdutos.SelectedItems[0].SubItems[2].Text;
                txtPreco.Text = lvProdutos.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {
                MessageBox.Show("Selecione um Item!");
            }
        }

        private void lvProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count > 0)
            {
                obter();
            }
        }
    }
}
