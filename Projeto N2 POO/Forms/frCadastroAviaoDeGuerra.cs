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
    public partial class frCadastroAviaoDeGuerra : frBase
    {
        public frCadastroAviaoDeGuerra()
        {
            InitializeComponent();

            List<Modelo> modelosDeAviaoDeGuerra = new List<Modelo>();

            foreach (Modelo modelo in Dados.Modelos)
                if (modelo.TipoVeiculo == EnumTipoVeiculo.AviaoDeGuerra)
                    modelosDeAviaoDeGuerra.Add(modelo);

            cbmModelo.DataSource = modelosDeAviaoDeGuerra;
            cbmModelo.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoAviaoDeGuerra aviao = new VeiculoAviaoDeGuerra();
                aviao.Identificacao = ucIdentificacao.TextoDaTextBox;
                aviao.Modelo = cbmModelo.SelectedItem as Modelo;
                aviao.CapacidadeDePassageiro = Convert.ToInt32(nudCapacidadePassageiros.Value);
                Dados.AdicionarVeiculo(aviao);

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
