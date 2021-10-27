using System;
using System.Windows.Forms;

namespace ListaCompras
{
    public partial class Form1 : Form
   {
        double totalCompras = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializaListBox();
        }

        private void inicializaListBox()
        {
            lbDados.Items.Clear();
            lbDados.Items.AddRange(new Alimento[] { new Banana(), new Tomate(), new Laranja() });
            lbDados.Items.AddRange(new Alimento[] { new Leite(), new Queijo(), new Laranja() });
            lbDados.Items.AddRange(new Alimento[] { new Ovo(), new Presunto(), new Salmao() });
            lbDados.Items.AddRange(new Alimento[] { new Cenoura(), new Alface() });
            lbDados.Items.AddRange(new Alimento[] { new Guarana(), new Agua()});
            totalCompras = 0;
        }

        private void ExibirItem(Alimento _item)
        {
            txtCalorias.Text = _item.Calorias.ToString();
            txtCustoTotal.Clear();
            txtTipo.Text = _item.Tipo;
            txtUnidade.Text = _item.Unidade;
            txtPreco.Text = _item.Preco.ToString("C");
            if (_item.Custo != 0)
                txtCustoTotal.Text = _item.Custo.ToString("C");
        }

        private void LimpaDetalhes(Control ctrl)
        {
            foreach (var c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            LimpaDetalhes(this);
            inicializaListBox();
        }

        private void lbDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            erro1.Clear();
            ExibirItem((Alimento) lbDados.Items[lbDados.SelectedIndex]);
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            erro1.Clear();
            try
            {
                double quantidade = Convert.ToDouble(txtQuantidade.Text);
                Alimento item = (Alimento)lbDados.Items[lbDados.SelectedIndex];
                item.SetCusto(quantidade);
                txtCustoTotal.Text = item.Custo.ToString("C");
                txtQuantidade.Clear();
                totalCompras += item.GetCustoCompra(quantidade);
                txtValorTotal.Text = totalCompras.ToString("C");
            }
            catch (FormatException)
            {
                erro1.SetError(txtQuantidade, "Informe um valor");
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
            catch (ArgumentOutOfRangeException)
            {
                erro1.SetError(lbDados, "Selecione um item da lista");
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            erro1.Clear();
            try
            {
                Alimento item = (Alimento)lbDados.Items[lbDados.SelectedIndex];
                totalCompras -= item.Custo;
                item.ResetarCusto();
                txtCustoTotal.Clear();
                txtQuantidade.Clear();
                txtValorTotal.Clear();
                if (totalCompras != 0)
                    txtValorTotal.Text = totalCompras.ToString("C");
            }
            catch (ArgumentOutOfRangeException)
            {
                erro1.SetError(lbDados, "Selecione um item da lista");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
