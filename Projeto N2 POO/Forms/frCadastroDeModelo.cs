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
    public partial class frCadastroDeModelo : frBase
    {
        public frCadastroDeModelo()
        {
            InitializeComponent();

            cbmMarca.DataSource = Dados.Marcas;
            cbmMarca.DisplayMember = "Descricao";

            if (Dados.Marcas.Count > 0)
                cbmTipoVeiculo.DataSource = (cbmMarca.SelectedItem as Marca).TiposProduzidos;
            else
            {
                ExibeTelaDeErro(this);
                MessageBox.Show("Não foi possivel carregar as marcas. Por favor, tente criar alguma.", "Erro !",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.AdicionarModelo(new Modelo(Convert.ToInt32(ucCodigo.TextoDaTextBox),
                                               ucDescricao.TextoDaTextBox,
                                               cbmMarca.SelectedItem as Marca,
                                               (EnumTipoVeiculo)cbmTipoVeiculo.SelectedItem));

                LimpaCampos(Controls);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        private void cbmMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmTipoVeiculo.DataSource = (cbmMarca.SelectedItem as Marca).TiposProduzidos;
        }
    }
}
