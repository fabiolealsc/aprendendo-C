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
    public partial class fCheckedListBox : Form
    {
        public fCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnMostrarSelecionado_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string t in clbTransportes.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clbTransportes.Items.Clear();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            clbTransportes.Items.Clear();
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Motocicleta");
            tr.Add("Cavalo");
            clbTransportes.Items.AddRange(tr.ToArray());
        }

        private void btnNovoTransporte_Click(object sender, EventArgs e)
        {
            if (txtNovoTransporte.Text != "")
            {
                clbTransportes.Items.Add(txtNovoTransporte.Text);

            }
            txtNovoTransporte.Clear();
            txtNovoTransporte.Focus();
        }
    }
}
