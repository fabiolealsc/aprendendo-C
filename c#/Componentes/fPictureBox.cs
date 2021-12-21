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
    public partial class fPictureBox : Form
    {
        public fPictureBox()
        {
            InitializeComponent();
        }

        private void fPictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.Endereço_Canal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.android_chrome_512x512;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2021_11_29_at_22_08_46;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rabisco;
        }
    }
}
