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
    public partial class frGerenciarAviao : frBase
    {
        private List<VeiculoAviao> veiculosDoTipoCadastrados = new List<VeiculoAviao>();
        private int index = 0;
        public frGerenciarAviao()
        {
            InitializeComponent();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is VeiculoAviao)
                    veiculosDoTipoCadastrados.Add(veiculo as VeiculoAviao);

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
        public void AtualizaValor()
        {
            ucIdentificacao.TextoLabel2 = veiculosDoTipoCadastrados[index].Identificacao;
            ucMarca.TextoLabel2 = veiculosDoTipoCadastrados[index].Modelo.Marca.Descricao;
            ucModelo.TextoLabel2 = veiculosDoTipoCadastrados[index].Modelo.Descricao;
            ucVelocidade.TextoLabel2 = veiculosDoTipoCadastrados[index].Velocidade.ToString() + " km/h";

            ucQtdPassageiro.TextoLabel2 = veiculosDoTipoCadastrados[index].CapacidadeDePassageiro.ToString();
            ucEstadoLimpador.TextoLabel2 = veiculosDoTipoCadastrados[index].LimpadorLigado ? "Ligado" : "Desligado";
            ucVoando.TextoLabel2 = veiculosDoTipoCadastrados[index].VeiculoEstaNoAr ? "Sim" : "Não";

            ucAcelerar.VeiculoControlado = veiculosDoTipoCadastrados[index];
            ucDesacelerar.VeiculoControlado = veiculosDoTipoCadastrados[index];
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (index < veiculosDoTipoCadastrados.Count - 1)
                index++;
            else
                MessageBox.Show("Este é o último avião cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                MessageBox.Show("Este é o primeiro avião cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int aux = veiculosDoTipoCadastrados.FindIndex(c => c.Identificacao == txtPesquisa.Text);

            if (aux >= 0)
                index = aux;
            else
                MessageBox.Show("Este avião não existe.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAlterarLimpador_Click(object sender, EventArgs e)
        {
            veiculosDoTipoCadastrados[index].AlteraLimpador();
            Dados.SalvarVeiculos();
            AtualizaValor();
        }
        private void btnPousar_Click(object sender, EventArgs e)
        {
            try
            {
                veiculosDoTipoCadastrados[index].Pousar();
                Dados.SalvarVeiculos();
                AtualizaValor();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        private void btnDecolar_Click(object sender, EventArgs e)
        {
            try
            {
                veiculosDoTipoCadastrados[index].Decolar();
                Dados.SalvarVeiculos();
                AtualizaValor();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        private void btnArremeter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(veiculosDoTipoCadastrados[index].Arremeter(), "Sucesso !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }
    }
}
