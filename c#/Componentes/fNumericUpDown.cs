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
    public partial class fNumericUpDown : Form
    {
        public fNumericUpDown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Decimal.Parse(textBox1.Text) >= numericUpDown1.Minimum ) & (Decimal.Parse(textBox1.Text) <= numericUpDown1.Maximum)){
                numericUpDown1.Value = Decimal.Parse(textBox1.Text);
            }
        }
    }
}
