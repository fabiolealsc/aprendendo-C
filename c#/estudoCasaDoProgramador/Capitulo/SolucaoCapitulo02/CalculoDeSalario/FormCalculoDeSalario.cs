using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculoDeSalario
{
    public partial class frmCalculoDeSalario : Form
    {
        public frmCalculoDeSalario()
        {InitializeComponent();}
        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double horasTrabalhadas, double valorSalarioMinimo)
        {   double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno, horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetValorImposto(rbnCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetAuxilioAlimentacao(rbnCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;
            ApresentarResultado(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAuxilioAlimentacao, valorSalarioLiquido);}
        private double GetCoeficiente(RadioButton rbnTurno)
        {   double valorCoeficiente = 0;
            switch(rbnTurno.Text)
            {   case "Matutino": valorCoeficiente = double.Parse(txtSalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino": valorCoeficiente = double.Parse(txtSalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno": valorCoeficiente = double.Parse(txtSalarioMinimo.Text) * 0.03;
                    break;}
            return valorCoeficiente;}
        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhadas)
        {   double valorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhadas > 80) valorGratificacao = 50;
            return valorGratificacao;}
        private static double GetValorImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {   double valorImposto = 0;
            switch (rbnCategoria.Text){
                case "Calouro": if (valorSalarioBruto < 300) valorImposto = valorSalarioBruto * 0.01;
                    else valorImposto = valorSalarioBruto * 0.02;
                    break;
                case "Veterano": if (valorSalarioBruto < 400) valorImposto = valorSalarioBruto * 0.03;
                    else valorImposto = valorSalarioBruto * 0.04;
                    break;}
            return valorImposto;}        
        private double GetAuxilioAlimentacao(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {   double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;
            if (rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < (valorSalarioMinimo / 2)))
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            return valorAuxilioAlimentacao;}
        private void ApresentarResultado(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            lbxResumo.Items.Clear();
            lblRemuneracao.Text = GetSituacaoEstagiario(valorSalarioLiquido);
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do coeficiente:", valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário Bruto:", valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do imposto:", valorImposto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor da gratificação:", valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do auxilio alimentação:", valorAuxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salario líquido:", valorSalarioLiquido));}
        private string GetSituacaoEstagiario(double valorSalarioLiquido)
        {  if (valorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (valorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem remunerado";}
        private void btnCalcular_Click(object sender, EventArgs e)
        {   RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RealizarProcessamento(rbnTurno, rbnCategoria,
                double.Parse(txtHorasTrabalhadas.Text),
                double.Parse(txtSalarioMinimo.Text));}
        }
}