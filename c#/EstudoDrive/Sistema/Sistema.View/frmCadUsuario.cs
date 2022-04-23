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
    public partial class frmCadUsuario : Form
    {
        UsuarioEnt objTabela = new UsuarioEnt();
        
        public frmCadUsuario()
        {
            InitializeComponent();
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
        {   if (txtId.Text == "")
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
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} cadastrado(a)!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não inserido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: "+ ex);
                    }
                    ListarGrid();
                    LimparCampos();
                    DesabilitarCampos();
                    break;
                case "Excluir":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtId.Text);

                        int x = UsuarioModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} excluido(a)!", txtNome.Text));
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
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} Editato(a)!", txtNome.Text));
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
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
        }
        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }
        private void ListarGrid()
        {
            try
            {
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                lista = new UsuarioModel().Lista();
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Dados" + ex.Message);
            }
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtBuscar.Text == "")
                {
                    ListarGrid();
                }
                objTabela.Nome = txtBuscar.Text;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                lista = new UsuarioModel().Buscar(objTabela);
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = lista;
            }
            catch
            {

            }
        }
    }
}
