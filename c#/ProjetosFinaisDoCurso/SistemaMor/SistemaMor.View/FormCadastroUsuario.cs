using System.Windows.Forms;

namespace SistemaMor.View
{
    public partial class FormCadastroUsuario : Form
    {
        Form frmPric = new FormLogin();
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmPric.Show();
        }
    }
}
