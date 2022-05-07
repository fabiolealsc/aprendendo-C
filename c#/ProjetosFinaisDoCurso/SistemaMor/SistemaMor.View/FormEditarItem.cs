using SistemaMor.Entidades;
using SistemaMor.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMor.View
{
    public partial class FormEditarItem : Form
    {
        ItensEnt itensEnt;
        string table;
        public FormEditarItem(ItensEnt _itensEnt, string _table)
        {
            itensEnt = _itensEnt;
            table = _table;
            InitializeComponent();
            CarregarDados();
        }
        public void CarregarDados()
        {
            txtItem.Text = itensEnt.Item;
            txtDescricao.Text = itensEnt.Descricao;
            imagemItem.Image = itensEnt.Imagem;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                itensEnt.Descricao = txtDescricao.Text;
                itensEnt.Item = txtItem.Text;
                itensEnt.Imagem = imagemItem.Image;

                int x = ItensModel.Editar(itensEnt, table);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("Item {0} editado(a)!", txtItem.Text));
                }
                else
                {
                    MessageBox.Show("Não editado!");
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
