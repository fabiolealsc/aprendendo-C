using System;
using System.Drawing;
using System.Windows.Forms;

namespace arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = "COM4";
                serialPort.Open();
                lblConexao.Text = "ONLINE";
                panel1.BackColor = Color.Green;
                serialPort.Write("0");
                panel2.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("1");
                panel2.BackColor = Color.Green;
                lvlLed.Text = "ON";
            }
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("0");
                panel2.BackColor = Color.Red;
                lvlLed.Text = "OFF";
            }
        }
    }
}
