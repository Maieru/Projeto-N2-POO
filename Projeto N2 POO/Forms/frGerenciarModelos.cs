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
    public partial class frGerenciarModelos : frBase
    {
        private int index = 0;
        public frGerenciarModelos()
        {
            InitializeComponent();

            if (Dados.Pedagios.Count == 0)
            {
                ExibeTelaDeErro();
                return;
            }

            ucQtdCadastrado.TextoLabel2 = Dados.Modelos.Count.ToString();

            AtualizaValor();
        }

        public void AtualizaValor()
        {
            ucCodigo.TextoLabel2 = Dados.Modelos[index].Codigo.ToString();
            ucDescricao.TextoLabel2 = Dados.Modelos[index].Descricao;
            ucMarca.TextoLabel2 = Dados.Modelos[index].Marca.Descricao;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (index < Dados.Modelos.Count - 1)
                index++;
            else
                MessageBox.Show("Este é o útimo modelo cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                MessageBox.Show("Este é o primeiro modelo cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int aux = Dados.Modelos.FindIndex(c => c.Descricao == txtPesquisa.Text);

            if (aux >= 0)
                index = aux;
            else
                MessageBox.Show("Este modelo não existe.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
    }
}
