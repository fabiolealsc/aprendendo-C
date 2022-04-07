using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoDeEnergiaDeUmCondominio
{
    public partial class frmConsumoDeEnergiaDeUmCondominio : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();
        public frmConsumoDeEnergiaDeUmCondominio()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dgvConsumoDeEnergia.DataSource = leituraSource;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarConsumo(txtNumeroCasa.Text, double.Parse(txtConsumo.Text));
        }
        private void registrarConsumo(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura))
            {
                MessageBox.Show("A leitura para essa casa já foi registrada", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.leituras.Add(leitura);
                inicializaFormulario();
            }
        }
        private void inicializaFormulario()
        {
            txtNumeroCasa.Clear();
            txtConsumo.Clear();
            txtNumeroCasa.Focus();
        }

        private void btnProsessarDados_Click(object sender, EventArgs e)
        {
            processarLeituras(dgvConsumoDeEnergia);
        }
        private void processarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgv.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows[dgvConsumoDeEnergia.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                dgv.Rows[dgvConsumoDeEnergia.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dgv.Rows[dgvConsumoDeEnergia.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }
            double totalConsumo = 0, totalDesconto = 0;
            foreach(var leitura in leituras)
            {
                totalConsumo += leitura.Consumo;
                totalDesconto += leitura.Desconto;
            }
            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString("N");
            lblTotalDeConsumo.Text = "Total consumo sem desconto: " + (totalConsumo - totalDesconto).ToString("N");
        }
    }        
}


