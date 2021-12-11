using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Cursos
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()

        {
            InitializeComponent();
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
        }
    }
}
