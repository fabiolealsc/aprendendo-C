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
    public partial class fCheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public fCheckBox()
        {
            InitializeComponent();
            transp.Add(cbxAviao);
            transp.Add(cbxCarro);
            transp.Add(cbxCavalo);
            transp.Add(cbxMoto);
            transp.Add(cbxNavio);
            transp.Add(cbxPatinete);

        }

        private void btnTransportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cbxPatinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPatinete.Checked)
            {
                MessageBox.Show("Patinete marcada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fFilhoCheckBox ffilhocheckbox = new fFilhoCheckBox();
            ffilhocheckbox.ShowDialog();
        }
    }
}
