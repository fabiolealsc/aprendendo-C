using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMor
{
    public partial class AdicionarItem : Form
    {
        public AdicionarItem()
        {
            InitializeComponent();
        }

        private void baiasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.baiasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void baiasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.baiasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void AdicionarItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Baias' table. You can move, or remove it, as needed.
            this.baiasTableAdapter.Fill(this.databaseDataSet.Baias);

        }
    }
}
