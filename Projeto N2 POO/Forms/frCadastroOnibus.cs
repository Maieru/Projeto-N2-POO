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
    public partial class frCadastroOnibus : frBase
    {
        public frCadastroOnibus()
        {
            InitializeComponent();

            List<Modelo> modelosDeOnibus = new List<Modelo>();

            foreach (Modelo modelo in Dados.Modelos)
                if (modelo.TipoVeiculo == EnumTipoVeiculo.Onibus)
                    modelosDeOnibus.Add(modelo);

            cbmModelo.DataSource = modelosDeOnibus;
            cbmModelo.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoOnibus onibus = new VeiculoOnibus();
                onibus.Identificacao = ucIdentificacao.TextoDaTextBox;
                onibus.Modelo = cbmModelo.SelectedItem as Modelo;
                onibus.QuantidadeDeEixos = Convert.ToInt32(nudQtdEixos.Value);
                onibus.CapacidadeDePassageiro = Convert.ToInt32(nudCapacidadePassageiros.Value);
                onibus.PossuiLeito = chkLeito.Checked;
                Dados.AdicionarVeiculo(onibus);

                LimpaCampos(Controls);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
