using System;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fMaskedTextBox : Form
    {
        public fMaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                mtbMask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtbMask.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            String msg = mtbMask.Text;
            MessageBox.Show(msg);
            
;        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbMostrarSenha.Checked)
            {
                mtbSenha.PasswordChar = '\0';
            }
            else
            {
                mtbSenha.PasswordChar = '*';
            }
        }
    }
}
