using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItensManut
{
    public partial class FormPrincipal : Form
    {
        public FormAdicionarItem adicionarItem = new FormAdicionarItem();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void adicionarItemTSMI_Click(object sender, EventArgs e)
        {
            adicionarItem.Show();
        }

        private void sairTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarItemTSMI_Click(object sender, EventArgs e)
        {
            adicionarItem.Show();
        }
    }
}
