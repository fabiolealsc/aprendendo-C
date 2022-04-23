using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMor.Entidades;
using SistemaMor.Model;

namespace SistemaMor.View
{
    public partial class FormPrincipal : Form
    {
        
        public string opc;
        public ItensEnt itensEnt = new ItensEnt();
        public string table = "Baias";
        public FormPrincipal()
        {
            InitializeComponent();
            ListarGrid();
        }
        private void IniciarOpc()
        {
            switch (opc)
            {
                case "Excluir":
                    try
                    {
                        
                        int x = ItensModel.Excluir(itensEnt, table);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Item {0} excluido(a)!", itensEnt.Id));
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
                    break;
                case "Novo":
                    FormCadastroItem formCadastroItem = new FormCadastroItem(table);
                    formCadastroItem.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        private void ListarGrid()
        {
            try
            {
                List<ItensEnt> lista = new List<ItensEnt>();
                lista = new ItensModel().Lista(table);
                dgvItens.AutoGenerateColumns = false;
                dgvItens.DataSource = lista;
                imagemItem.Image = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Dados" + ex.Message);
            }
        }

        private void btnBaia_Click(object sender, EventArgs e)
        {
            table = "Baias";
            ListarGrid();
        }

        private void btnCarroRapido_Click(object sender, EventArgs e)
        {
            table = "CarroRapido";
            ListarGrid();
        }

        private void btnColoman_Click(object sender, EventArgs e)
        {
            table = "Coloman";
            ListarGrid();
        }

        private void btnCorteDeFita_Click(object sender, EventArgs e)
        {
            table = "CorteDeFitas";
            ListarGrid();
        }

        private void btnDoca_Click(object sender, EventArgs e)
        {
            table = "Docas";
            ListarGrid();
        }

        private void btnEntradaDePallet_Click(object sender, EventArgs e)
        {
            table = "EntradaDePallets";
            ListarGrid();
        }

        private void btnGeral_Click(object sender, EventArgs e)
        {
            table = "Geral";
            ListarGrid();
        }

        private void btnMezanino_Click(object sender, EventArgs e)
        {
            table = "Mezanino";
            ListarGrid();
        }

        private void btnMupi_Click(object sender, EventArgs e)
        {
            table = "Mupi";
            ListarGrid();
        }

        private void btnSls_Click(object sender, EventArgs e)
        {
            table = "Slss";
            ListarGrid();
        }

        private void btnSoldaPVC_Click(object sender, EventArgs e)
        {
            table = "SoldaPVC";
            ListarGrid();
        }

        private void btnTraslo_Click(object sender, EventArgs e)
        {
            table = "Traslo";
            ListarGrid();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            IniciarOpc();
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            IniciarOpc();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            FormEditarItem formEditarItem = new FormEditarItem(itensEnt, table);
            formEditarItem.ShowDialog();
        }
        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itensEnt.Id = Convert.ToInt32(dgvItens.CurrentRow.Cells[0].Value.ToString());
            itensEnt.Item = dgvItens.CurrentRow.Cells[1].Value.ToString();
            itensEnt.Descricao = dgvItens.CurrentRow.Cells[2].Value.ToString();
            itensEnt.Imagem = (Image)(dgvItens.CurrentRow.Cells[3].Value);
            imagemItem.Image = itensEnt.Imagem;
            
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    ListarGrid();
                }
                itensEnt.Descricao = txtBuscar.Text;
                List<ItensEnt> lista = new List<ItensEnt>();
                lista = new ItensModel().Buscar(itensEnt, table);
                dgvItens.AutoGenerateColumns = false;
                dgvItens.DataSource = lista;
            }
            catch
            {

            }
        }

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            ListarGrid();
        }
    }
}
