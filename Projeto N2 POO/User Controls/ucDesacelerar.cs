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

namespace Projeto_N2_POO.User_Controls
{
    public partial class ucDesacelerar : UserControl
    {
        public VeiculoBase VeiculoControlado { get; set; }

        public delegate void AtualizarValores();
        public AtualizarValores metodoAtualizacao;

        public ucDesacelerar()
        {
            InitializeComponent();
        }
        private void btnAcelarar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoControlado.Desacelera();
                metodoAtualizacao.Invoke();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
