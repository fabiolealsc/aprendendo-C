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
        public int cod;

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
            dgv1.Columns[0].Width = 40;
            dgv1.Columns[1].Width = 530;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn = "projepack";
            carregaDados();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn = "corte_de_fitas";
            carregaDados();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn = "geral";
            carregaDados();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn = "solda_pvc";
            carregaDados();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn = "tesoura_eletrica";
            carregaDados();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn = "sannet";
            carregaDados();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn = "traslos";
            carregaDados();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn = "carro_rapido";
            carregaDados();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn = "sls";
            carregaDados();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btn = "baias";
            carregaDados();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btn = "docas";
            carregaDados();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            btn = "mezanino";
            carregaDados();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            btn = "entrada_de_pallets";
            carregaDados();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Banco.deletar(btn, cod);
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            int cl = dvg.SelectedRows.Count;
            if (cl > 0)
            {
                cod = Convert.ToInt32(dgv1.SelectedRows[0].Cells[0].Value.ToString());
            }
            
        }
    }
}
