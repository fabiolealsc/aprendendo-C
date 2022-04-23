using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidades;
using Sistema.Model;

namespace Sistema.View
{
    public partial class frmPrincipal : Form
    {
        ProdutoEnt objTabela = new ProdutoEnt();
        public frmPrincipal()
        {
            InitializeComponent();
            ListarGrid();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            IniciarOpc();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            IniciarOpc();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela");
                return;
            }
            opc = "Excluir";
            IniciarOpc();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela");
                return;
            }
            opc = "Editar";
            IniciarOpc();
        }

        private string opc = "";
        private void IniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;
                case "Salvar":
                    try
                    {
                        objTabela.Produto = txtProduto.Text;
                        objTabela.Descricao = txtDescricao.Text;
                        objTabela.Valor = Convert.ToDouble(txtValor.Text);

                        int x = ProdutoModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} cadastrado(a)!", txtProduto.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não inserido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex);
                    }
                    ListarGrid();
                    LimparCampos();
                    DesabilitarCampos();
                    break;
                case "Excluir":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtId.Text);

                        int x = ProdutoModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Produto {0} excluido(a)!", txtProduto.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não excluido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                    ListarGrid();
                    DesabilitarCampos();
                    LimparCampos();
                    break;
                case "Editar":
                    HabilitarCampos();
                    try
                    {
                        objTabela.Id = int.Parse(txtId.Text);
                        objTabela.Produto = txtProduto.Text;
                        objTabela.Descricao = txtDescricao.Text;
                        objTabela.Valor = Convert.ToDouble(txtValor.Text);

                        int x = ProdutoModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Produto {0} Editato(a)!", txtProduto.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não editado!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex);
                    }
                    ListarGrid();
                    LimparCampos();
                    break;
                default:
                    break;
            }
        }


        private void HabilitarCampos()
        {
            txtProduto.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtProduto.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
        }
        private void LimparCampos()
        {
            txtId.Text = "";
            txtProduto.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
        }
        private void ListarGrid()
        {
            try
            {
                List<ProdutoEnt> lista = new List<ProdutoEnt>();
                lista = new ProdutoModel().Lista();
                dgvProdutos.AutoGenerateColumns = false;
                dgvProdutos.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Dados" + ex.Message);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objTabela.Produto = txtBuscar.Text;
                List<ProdutoEnt> lista = new List<ProdutoEnt>();
                lista = new ProdutoModel().Buscar(objTabela);
                dgvProdutos.AutoGenerateColumns = false;
                dgvProdutos.DataSource = lista;
            }
            catch
            {

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            txtProduto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }
    }
}
