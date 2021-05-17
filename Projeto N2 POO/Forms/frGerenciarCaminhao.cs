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
    public partial class frGerenciarCaminhao : frBase
    {
        private List<VeiculoCaminhao> veiculosDoTipoCadastrados = new List<VeiculoCaminhao>();
        private int index = 0;

        

        public frGerenciarCaminhao()
        {
            InitializeComponent();

            foreach (VeiculoBase veiculo in Dados.Veiculos)
                if (veiculo is VeiculoCaminhao)
                    veiculosDoTipoCadastrados.Add(veiculo as VeiculoCaminhao);

            if (veiculosDoTipoCadastrados.Count == 0)
            {
                ExibeTelaDeErro(this);
                return;
            }

            cbmPedagios.DataSource = Dados.Pedagios;
            cbmPedagios.DisplayMember = "Identificacao";

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

            ucPesoCarregado.TextoLabel2 = veiculosDoTipoCadastrados[index].PesoCarregado.ToString() + " kg";
            ucCapacidadeDeCarga.TextoLabel2 = veiculosDoTipoCadastrados[index].CapacidadeMaxima.ToString() + " kg";
            ucQtdPassageiro.TextoLabel2 = veiculosDoTipoCadastrados[index].CapacidadeDePassageiro.ToString();
            ucEstadoLimpador.TextoLabel2 = (veiculosDoTipoCadastrados[index].LimpadorLigado ? "Ligado" : "Desligado");
            ucQtdDeEixos.TextoLabel2 = veiculosDoTipoCadastrados[index].QuantidadeDeEixos.ToString();

            ucAcelerar.VeiculoControlado = veiculosDoTipoCadastrados[index];
            ucDesacelerar.VeiculoControlado = veiculosDoTipoCadastrados[index];
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (index < veiculosDoTipoCadastrados.Count - 1)
                index++;
            else
                MessageBox.Show("Este é o último caminhão cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                MessageBox.Show("Este é o primeiro caminhão cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int aux = veiculosDoTipoCadastrados.FindIndex(c => c.Identificacao == txtPesquisa.Text);

            if (aux >= 0)
                index = aux;
            else
                MessageBox.Show("Este caminhão não existe.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAlterarLimpador_Click(object sender, EventArgs e)
        {
            MessageBox.Show(veiculosDoTipoCadastrados[index].AlteraLimpador(), "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dados.SalvarVeiculos();
            AtualizaValor();
        }
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            double valor = 0;
            try
            {
                valor = Convert.ToDouble(txtValor.Text);
                veiculosDoTipoCadastrados[index].Carregar(valor);
                AtualizaValor();
                MessageBox.Show("Carregado com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            double valor = 0;
            try
            {
                valor = Convert.ToDouble(txtValor.Text);
                veiculosDoTipoCadastrados[index].Descarregar(valor);
                AtualizaValor();

                MessageBox.Show("Descarregado com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        private void btnPagarPedagio_Click(object sender, EventArgs e)
        {
            if (cbmPedagios.SelectedItem == null)
            {
                MessageBox.Show("Não existe pedágio selecionado", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show((cbmPedagios.SelectedItem as Pedagio).Receber(veiculosDoTipoCadastrados[index]), "Sucesso !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            Dados.SalvarPedagios();
        }
    }
}
