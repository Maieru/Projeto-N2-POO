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

namespace Projeto_N2_POO.Forms
{
    public partial class frCadastroDeModelo : frBase
    {
        public frCadastroDeModelo()
        {
            InitializeComponent();

            cbmMarca.DataSource = Dados.Marcas;
            cbmMarca.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.AdicionarModelo(new Modelo(Convert.ToInt32(ucCodigo.TextoDaTextBox),
                                               ucDescricao.TextoDaTextBox,
                                               cbmMarca.SelectedItem as Marca));

                ucCodigo.TextoDaTextBox = "";
                ucDescricao.TextoDaTextBox = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
