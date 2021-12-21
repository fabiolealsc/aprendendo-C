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

        private void btnAdicionar_Click(object sender, EventArgs e)
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
}
