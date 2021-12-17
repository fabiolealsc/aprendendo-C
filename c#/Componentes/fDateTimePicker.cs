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
    public partial class fDateTimePicker : Form
    {
        public fDateTimePicker()
        {
            InitializeComponent();
        }

        private void btnObterData_Click(object sender, EventArgs e)
        {
            txtData.Text = dtpData.Text;
            txtDia.Text = dtpData.Value.Day.ToString();
            txtMes.Text = dtpData.Value.Month.ToString();
            txtAno.Text = dtpData.Value.Year.ToString();
        }

        private void btnSetarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(txtDia.Text);
            m = Int32.Parse(txtMes.Text);
            a = Int32.Parse(txtAno.Text);
            DateTime dt = new DateTime(a,m,d);
            dtpData.Value = dt; 
        }
    }
}
