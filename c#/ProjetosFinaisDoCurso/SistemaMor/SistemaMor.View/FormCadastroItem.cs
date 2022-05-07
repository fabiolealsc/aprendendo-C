using SistemaMor.Entidades;
using SistemaMor.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMor.View
{
    public partial class FormCadastroItem : Form
    {
        ItensEnt itensEnt = new ItensEnt();
        string table;
        public FormCadastroItem(string _table)
        {
            table = _table;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                itensEnt.Descricao = txtDescricao.Text;
                itensEnt.Item = txtItem.Text;
                itensEnt.Imagem = imagemItem.Image;

                int x = ItensModel.Inserir(itensEnt, table);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("Item {0} cadastrado(a)!", txtItem.Text));
                }
                else
                {
                    MessageBox.Show("Não inserido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "img files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                imagemItem.Image = Image.FromFile(file);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
