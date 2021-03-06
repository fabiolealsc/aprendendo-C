using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class frmMatriculaDeAlunoV2 : Form
    {
        public frmMatriculaDeAlunoV2()
        {
            InitializeComponent();
            lblHoje.Text = "Hoje é: "+ DateTime.Now.ToShortDateString();
        }

        private void txtAnoUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now <= dtpDataDeNascimento.Value)
            {
                MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO DEVE SER MAIOR QUE O ANO DE NASCIMENTO.",
                    "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty ||
                dtpDataDeNascimento.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados devem ser informados",
                    "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataDeNascimento.Value;
                int idade = tsQuantidadeDias.Days / 365;
                if (idade > 17) {
                    lblCategoria.Text = "Adulto";
                }else if(idade > 13) {
                    lblCategoria.Text = "Juvenil B";
                }else if(idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";
                }else if(idade > 7)
                {
                    lblCategoria.Text = "Infantil B";
                }else if(idade >= 5)
                {
                    lblCategoria.Text = "Infantil A";
                }
                else
                {
                    lblCategoria.Text = "Não existe categoria!";
                }
            }
        }
    }
}
