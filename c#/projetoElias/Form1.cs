using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoElias
{
    public partial class ItensSearch : Form
    {
        public static string btn;

        public ItensSearch()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ItensSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn = "mupi";
            carregaDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn = "coloman";
            carregaDados();
        }

        public void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void button16_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
        public void carregaDados()
        {
            dgv1.DataSource = Banco.ObterDados(btn);
            
            
        }
    }
}
