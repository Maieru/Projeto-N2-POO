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
    public partial class frGerenciarMarcas : frBase
    {
        private int index = 0;
        public frGerenciarMarcas()
        {
            InitializeComponent();

            if (Dados.Marcas.Count == 0)
            {
                ExibeTelaDeErro();
                return;
            }

            ucQtdCadastrado.TextoLabel2 = Dados.Marcas.Count.ToString();

            AtualizaValor();
        }

        public void ExibeTelaDeErro()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(
            new Label
            {
                Text = "Nenhum pedágio encontrado",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            });
            Controls.Add(panel);
        }
        public void AtualizaValor()
        {
            ucCodigo.TextoLabel2 = Dados.Marcas[index].Codigo.ToString();
            ucDescricao.TextoLabel2 = Dados.Marcas[index].Descricao;
            ucTipos.TiposMarcados = Dados.Marcas[index].TiposProduzidos;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (index < Dados.Marcas.Count - 1)
                index++;
            else
                MessageBox.Show("Este é a útima marca cadastrada.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                MessageBox.Show("Este é a primeira marca cadastrada.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int codigoPesquisa;
            try
            {
                codigoPesquisa = Convert.ToInt32(txtPesquisa.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            int aux = Dados.Marcas.FindIndex(c => c.Codigo == codigoPesquisa);

            if (aux >= 0)
                index = aux;
            else
                MessageBox.Show("Esta marca não existe.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
    }
}
