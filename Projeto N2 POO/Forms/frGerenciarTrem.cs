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
    public partial class frGerenciarTrem : frBase
    {
        private List<VeiculoTrem> veiculosDoTipoCadastrados = new List<VeiculoTrem>();
        private int index = 0;
        public frGerenciarTrem()
        {
            InitializeComponent();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is VeiculoTrem)
                    veiculosDoTipoCadastrados.Add(veiculo as VeiculoTrem);

            if (veiculosDoTipoCadastrados.Count == 0)
            {
                ExibeTelaDeErro();
                return;
            }


            #region Atribuição de Delegados

            ucAcelerar.metodoAtualizacao = new User_Controls.ucAcelerar.AtualizarValores(AtualizaValor);
            ucDesacelerar.metodoAtualizacao = new User_Controls.ucDesacelerar.AtualizarValores(AtualizaValor);

            #endregion

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
            ucIdentificacao.TextoLabel2 = veiculosDoTipoCadastrados[index].Identificacao;
            ucMarca.TextoLabel2 = veiculosDoTipoCadastrados[index].Modelo.Marca.Descricao;
            ucModelo.TextoLabel2 = veiculosDoTipoCadastrados[index].Modelo.Descricao;
            ucVelocidade.TextoLabel2 = veiculosDoTipoCadastrados[index].Velocidade.ToString() + " km/h";

            ucQtdVagoes.TextoLabel2 = veiculosDoTipoCadastrados[index].QuantidadeDeVagoes.ToString();
            ucQtdPassageiro.TextoLabel2 = veiculosDoTipoCadastrados[index].CapacidadeDePassageiro.ToString();
            ucEstadoLimpador.TextoLabel2 = veiculosDoTipoCadastrados[index].LimpadorLigado ? "Ligado" : "Desligado";

            ucAcelerar.VeiculoControlado = veiculosDoTipoCadastrados[index];
            ucDesacelerar.VeiculoControlado = veiculosDoTipoCadastrados[index];
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (index < veiculosDoTipoCadastrados.Count - 1)
                index++;
            else
                MessageBox.Show("Este é o último trem cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                MessageBox.Show("Este é o primeiro trem cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int aux = veiculosDoTipoCadastrados.FindIndex(c => c.Identificacao == txtPesquisa.Text);

            if (aux >= 0)
                index = aux;
            else
                MessageBox.Show("Este trem não existe.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAlterarLimpador_Click(object sender, EventArgs e)
        {
            veiculosDoTipoCadastrados[index].AlteraLimpador();
            Dados.SalvarVeiculos();
            AtualizaValor();
        }
    }
}
