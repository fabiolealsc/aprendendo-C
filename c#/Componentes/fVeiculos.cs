using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fVeiculos : Form
    {
        formComponentes fcc;
        public fVeiculos(String v, formComponentes fc)
        {
            InitializeComponent();
            txtListaVeiculos.Text = v;
            fcc = fc;
            fcc.num = 10;
        }

        private void fVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void fVeiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fcc.txtListaVeiculos.Text = txtListaVeiculos.Text;
        }
    }
}
