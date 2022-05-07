using SistemaMor.Entidades;
using SistemaMor.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMor.View
{
    public partial class FormPrincipal : Form
    {
        private Button currentButton;
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

                        var x = ItensModel.Excluir(itensEnt, table);

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
                    var formCadastroItem = new FormCadastroItem(table);
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
                var lista = new List<ItensEnt>();
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
            ActivatedButton((Button)sender);
        }

        private void btnCarroRapido_Click(object sender, EventArgs e)
        {
            table = "CarroRapido";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnColoman_Click(object sender, EventArgs e)
        {
            table = "Coloman";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnCorteDeFita_Click(object sender, EventArgs e)
        {
            table = "CorteDeFitas";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnDoca_Click(object sender, EventArgs e)
        {
            table = "Docas";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnEntradaDePallet_Click(object sender, EventArgs e)
        {
            table = "EntradaDePallets";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnGeral_Click(object sender, EventArgs e)
        {
            table = "Geral";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnMezanino_Click(object sender, EventArgs e)
        {
            table = "Mezanino";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnMupi_Click(object sender, EventArgs e)
        {
            table = "Mupi";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnSls_Click(object sender, EventArgs e)
        {
            table = "Slss";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnSoldaPVC_Click(object sender, EventArgs e)
        {
            table = "SoldaPVC";
            ListarGrid();
            ActivatedButton((Button)sender);
        }

        private void btnTraslo_Click(object sender, EventArgs e)
        {
            table = "Traslo";
            ListarGrid();
            ActivatedButton((Button)sender);
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
            var formEditarItem = new FormEditarItem(itensEnt, table);
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
                var lista = new List<ItensEnt>();
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

        private void ActivatedButton(Button btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender)
                {
                    DisableButton();
                    lblTitulo.Text = btnSender.Text;
                    currentButton = btnSender;
                    currentButton.BackColor = Color.FromArgb(91, 91, 200);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previuosBtn in tableLayoutPanel2.Controls)
            {
                if (previuosBtn.GetType() == typeof(Button))
                {
                    previuosBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previuosBtn.ForeColor = Color.Gainsboro;
                    previuosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
