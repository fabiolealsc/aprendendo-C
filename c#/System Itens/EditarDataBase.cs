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
    public partial class EditarDataBase : Form
    {
        byte[] bytes = {};
        public EditarDataBase()
        {
            InitializeComponent();
        }
        DatabaseDataSetTableAdapters.BaiasTableAdapter baia = new DatabaseDataSetTableAdapters.BaiasTableAdapter();

        private void baiasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.baiasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void baiasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            baia.Inserir(int.Parse(idTextBox1.Text), int.Parse(itemTextBox1.Text), descriçãoTextBox1.Text, bytes);
            this.baiasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void EditarDataBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Baias' table. You can move, or remove it, as needed.
            this.baiasTableAdapter.Fill(this.databaseDataSet.Baias);

        }

        public void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagemPictureBox.Image = Image.FromFile(ofd.FileName);
                    Image image = Image.FromFile(ofd.FileName);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    bytes = ms.ToArray();
                }
            }
        }
    }
}
