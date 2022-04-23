using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Model;
using Sistema.Entidades;

namespace Sistema.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o campo Usuário");
                    txtUsuario.Focus();
                    return;
                }
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Senha");
                    txtSenha.Focus();
                    return;
                }
                UsuarioEnt obj = new UsuarioEnt();
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;

                obj = new UsuarioModel().Login(obj);

                if(obj.Usuario == null)
                {
                    lblMensagem.Text = "Usuário ou senha não encontrado";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.Show();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Erro ao logar: " + ex.Message);

                throw;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o campo Usuário");
                    txtUsuario.Focus();
                    return;
                }
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Senha");
                    txtSenha.Focus();
                    return;
                }
                UsuarioEnt obj = new UsuarioEnt();
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;

                obj = new UsuarioModel().Login(obj);

                if (obj.Usuario == null)
                {
                    lblMensagem.Text = "Usuário ou senha não encontrado";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }
                frmCadUsuario formCadUs = new frmCadUsuario();
                formCadUs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar: " + ex.Message);

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
