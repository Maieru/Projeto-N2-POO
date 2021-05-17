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
    public partial class frCadastroTrem : frBase
    {
        public frCadastroTrem()
        {
            InitializeComponent();

            List<Modelo> modelosDeTrem = new List<Modelo>();

            foreach (Modelo modelo in Dados.Modelos)
                if (modelo.TipoVeiculo == EnumTipoVeiculo.Trem)
                    modelosDeTrem.Add(modelo);

            cbmModelo.DataSource = modelosDeTrem;
            cbmModelo.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoTrem trem = new VeiculoTrem();
                trem.Identificacao = ucIdentificacao.TextoDaTextBox;
                trem.Modelo = cbmModelo.SelectedItem as Modelo;
                trem.CapacidadeDePassageiro = Convert.ToInt32(nudCapacidadePassageiros.Value);
                trem.QuantidadeDeVagoes = Convert.ToInt32(nudQtdVagoes.Value);
                Dados.AdicionarVeiculo(trem);

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
