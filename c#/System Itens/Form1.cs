using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Itens
{
    public partial class Form1 : Form
    {
        Form EditarDataBase = new EditarDataBase();
        DatabaseDataSetTableAdapters.BaiasTableAdapter baia = new DatabaseDataSetTableAdapters.BaiasTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Baias' table. You can move, or remove it, as needed.
            this.baiasTableAdapter.Fill(this.databaseDataSet.Baias);
            dataGridView1.DataSource = baia.List2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void databaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void editarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarDataBase.Show();
        }
    }
}
