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
    public partial class frCadastroMarca : frBase
    {
        public frCadastroMarca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.AdicionarMarca(new Marca(Convert.ToInt32(ucCodigo.TextoDaTextBox),
                                               ucDescricao.TextoDaTextBox,
                                               ucSeletorDeTipos.TiposMarcados));
                ucDescricao.TextoDaTextBox = "";
                ucCodigo.TextoDaTextBox = "";
                ucMarcador.AlterarCheckbox(false);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
