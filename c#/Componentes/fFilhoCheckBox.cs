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
    public partial class fFilhoCheckBox : Form
    {
        public fCheckBox fcb;
        public fFilhoCheckBox()
        {
            InitializeComponent();
            fcb = Application.OpenForms["fCheckBox"] as fCheckBox;
            cbxCarro.Checked = fcb.cbxCarro.Checked;
            cbxAviao.Checked = fcb.cbxAviao.Checked;
            cbxMoto.Checked = fcb.cbxMoto.Checked;
            cbxCavalo.Checked = fcb.cbxCavalo.Checked;
            cbxNavio.Checked = fcb.cbxNavio.Checked;
            cbxPatinete.Checked = fcb.cbxPatinete.Checked;
        }

        private void cbxCarro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cbxCarro.Checked = cbxCarro.Checked;
        }

        private void cbxAviao_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cbxAviao.Checked = cbxAviao.Checked;
        }

        private void cbxNavio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cbxNavio.Checked = cbxNavio.Checked;
        }

        private void cbxMoto_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cbxMoto.Checked = cbxMoto.Checked;
        }

        private void cbxCavalo_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cbxCavalo.Checked = cbxCavalo.Checked;
        }

        private void cbxPatinete_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cbxPatinete.Checked = cbxPatinete.Checked;
        }
    }
}
