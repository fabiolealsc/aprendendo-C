using System;
using System.Windows.Forms;

namespace SistemaMor.View
{
    public partial class FormLogin : Form
    {
        Form frmPrin = new FormPrincipal();
        Form frmCad = new FormCadastroUsuario();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrin.Show();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCad.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
