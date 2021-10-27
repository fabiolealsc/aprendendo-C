using System;
using System.Windows.Forms;

namespace cacaNiquel
{
    public partial class Form1 : Form
    {
        sort s = new sort();
        teste t = new teste();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            lblN1.Text = Convert.ToString(s.sortei());
            lblN2.Text = Convert.ToString(s.sortei());
            lblN3.Text = Convert.ToString(s.sortei());
            bool c = t.test(lblN1.Text, lblN2.Text, lblN3.Text);
            if (c == true)
            {
                MessageBox.Show("Você Ganhou");
            }
        }

    }
    
}
