using System; 
using System.Windows.Forms;

namespace Componentes
{
    public partial class formComponentes : Form
    {
        public int num;
        public formComponentes()
        {
            InitializeComponent();
            num = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtVeiculo.Text == "") {
                MessageBox.Show("Digite um Veículo!");
                txtVeiculo.Focus();
                return;
            }

            txtListaVeiculos.Text += txtVeiculo.Text + ", ";
            txtVeiculo.Clear();
            txtVeiculo.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtListaVeiculos.Clear();
            txtVeiculo.Clear();
            txtVeiculo.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            fVeiculos fVeiculo = new fVeiculos(txtListaVeiculos.Text, this);
            fVeiculo.ShowDialog();
        }

        private void btnValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCheckBox fcheckbox = new fCheckBox();
            fcheckbox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCheckedListBox fcheckedlistbox = new fCheckedListBox();
            fcheckedlistbox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComboBox fcombobox = new fComboBox();
            fcombobox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDateTimePicker fdatetimerpicker = new fDateTimePicker();
            fdatetimerpicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLinkLabel flinklabel = new fLinkLabel();
            flinklabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListBox flistbox = new fListBox();
            flistbox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListView flistview = new fListView();
            flistview.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMaskedTextBox fmaskedbox = new fMaskedTextBox();
            fmaskedbox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMonthCalendar fmonthcalendar = new fMonthCalendar();
            fmonthcalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmiFechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsmiRestaurar")
            {
                this.WindowState= FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmiMensagem")
            {
                MessageBox.Show("CFB Cursos - Cursos de c#");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNumericUpDown fnud = new fNumericUpDown();
            fnud.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPictureBox fpb = new fPictureBox();
            fpb.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProgressBar fpb = new fProgressBar();
            fpb.ShowDialog();
        }
    }
}