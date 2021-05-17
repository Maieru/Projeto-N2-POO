using Projeto_N2_POO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Forms
{
    public partial class frGerenciar : frBase
    {
        public frGerenciar()
        {
            InitializeComponent();
            cmbSelecaoPedagio.DataSource = Dados.Pedagios;
            cmbSelecaoPedagio.DisplayMember = "Identificacao";
        }
        private void btnAlterarLimpador_Click(object sender, EventArgs e)
        {
            StringBuilder sg = new StringBuilder();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is IVeiculoComLimpador)
                    sg.AppendLine((veiculo as IVeiculoComLimpador).AlteraLimpador());

            MessageBox.Show("Os seguintes veiculos tiveram seu limpador alterado: \n" +
                            sg.ToString(), "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Dados.SalvarVeiculos();
        }
        private void btnPagarPedagio_Click(object sender, EventArgs e)
        {
            StringBuilder sg = new StringBuilder();

            Pedagio pedagio = Dados.Pedagios.Find(p => p == cmbSelecaoPedagio.SelectedItem);

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is IVeiculoPagaPedagio)
                    sg.AppendLine(pedagio.Receber(veiculo as IVeiculoPagaPedagio));

            MessageBox.Show("Os seguintes veiculos pagaram pedágio: \n" +
                            sg.ToString(), "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Dados.SalvarPedagios();
        }
        private void btnAtracar_Click(object sender, EventArgs e)
        {
            StringBuilder sg = new StringBuilder();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is IVeiculoMarinho)
                    sg.AppendLine((veiculo as IVeiculoMarinho).Atracar());

            MessageBox.Show("Os seguintes veiculos atracaram: \n" +
                            sg.ToString(), "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Dados.SalvarVeiculos();
        }
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            StringBuilder sg = new StringBuilder();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is IVeiculoDeGuerra)
                    sg.AppendLine((veiculo as IVeiculoDeGuerra).Atacar());

            MessageBox.Show("Os seguintes veiculos atacaram: \n" +
                            sg.ToString(), "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            StringBuilder sg = new StringBuilder();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is VeiculoMoto)
                    sg.AppendLine((veiculo as VeiculoMoto).Empinar());

            MessageBox.Show(sg.ToString(), "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Dados.SalvarVeiculos();
        }
    }
}
