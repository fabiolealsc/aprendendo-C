using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoPesoIdeal
{
    public partial class frmCalculoPesoIdeal : Form
    {
        RadioButton rbnSelecionado = null;
        public frmCalculoPesoIdeal()
        {
            InitializeComponent();
        }
        private void SetPesoIdeal()
        {
            try {
                double altura = double.Parse(txtAltura.Text);
                double pesoIdeal;
                if (rbnSelecionado.Text.Equals("Masculino"))
                    pesoIdeal = (72.7 * altura) - 58;
                
                else
                    pesoIdeal = (61.1 * altura) - 44.7;
                lblPesoIdeal.Text = pesoIdeal.ToString("N");
            }
            catch {
                //MessageBox.Show("Selecione o sexo e informe a altura corretamente",
                //    "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
            }
        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }
}
