using Projeto_N2_POO.Classes;
using Projeto_N2_POO.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_N2_POO.Forms
{
    public partial class frCadastroCarro : frBase
    {
        public frCadastroCarro()
        {
            InitializeComponent();

            List<Modelo> modelosDeCarro = new List<Modelo>();

            foreach (Modelo modelo in Dados.Modelos)
                if (modelo.TipoVeiculo == EnumTipoVeiculo.Carro)
                    modelosDeCarro.Add(modelo);

            cbmModelo.DataSource = modelosDeCarro;
            cbmModelo.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoCarro carro = new VeiculoCarro();
                carro.Identificacao = ucIdentificacao.TextoDaTextBox;
                carro.Modelo = cbmModelo.SelectedItem as Modelo;
                carro.QuantidadeDePortas = Convert.ToInt32(nudQtdPortas.Value);
                carro.CapacidadeDePassageiro = Convert.ToInt32(nudCapacidadePassageiros.Value);
                Dados.AdicionarVeiculo(carro);

                LimpaCampos(Controls);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
