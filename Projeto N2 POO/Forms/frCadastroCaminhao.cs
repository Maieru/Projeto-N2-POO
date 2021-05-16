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
    public partial class frCadastroCaminhao : frBase
    {
        public frCadastroCaminhao()
        {
            InitializeComponent();

            List<Modelo> modelosCaminhao = new List<Modelo>();

            foreach (Modelo modelo in Dados.Modelos)
                if (modelo.TipoVeiculo == EnumTipoVeiculo.Caminhao)
                    modelosCaminhao.Add(modelo);

            cbmModelo.DataSource = modelosCaminhao;
            cbmModelo.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoCaminhao caminhao = new VeiculoCaminhao();
                caminhao.Identificacao = ucIdentificacao.TextoDaTextBox;
                caminhao.Modelo = cbmModelo.SelectedItem as Modelo;
                caminhao.QuantidadeDeEixos = Convert.ToInt32(nudQtdEixos.Value);
                caminhao.CapacidadeDePassageiro = Convert.ToInt32(nudCapacidadePassageiros.Value);
                caminhao.CapacidadeMaxima = Convert.ToDouble(ucCargaMaxima.TextoDaTextBox);
                Dados.AdicionarVeiculo(caminhao);

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
