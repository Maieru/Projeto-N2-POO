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
    public partial class frCadastroNavioDeGuerra : frBase
    {
        public frCadastroNavioDeGuerra()
        {
            InitializeComponent();

            List<Modelo> modelosDeNavioDeGuerra = new List<Modelo>();

            foreach (Modelo modelo in Dados.Modelos)
                if (modelo.TipoVeiculo == EnumTipoVeiculo.NavioDeGuerra)
                    modelosDeNavioDeGuerra.Add(modelo);

            cbmModelo.DataSource = modelosDeNavioDeGuerra;
            cbmModelo.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoNavioDeGuerra navio = new VeiculoNavioDeGuerra();
                navio.Identificacao = ucIdentificacao.TextoDaTextBox;
                navio.Modelo = cbmModelo.SelectedItem as Modelo;
                navio.CapacidadeDePassageiro = Convert.ToInt32(nudCapacidadePassageiros.Value);
                Dados.AdicionarVeiculo(navio);

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
