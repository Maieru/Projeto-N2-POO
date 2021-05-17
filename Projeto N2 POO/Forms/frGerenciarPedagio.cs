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
    public partial class frGerenciarPedagio : frBase
    {
        private int index = 0;
        public frGerenciarPedagio()
        {
            InitializeComponent();
            if (Dados.Pedagios.Count == 0)
            {
                ExibeTelaDeErro(this);
                return;
            }

            ucQtdCadastrado.TextoLabel2 = Dados.Pedagios.Count.ToString();

            double totalArrecadado = 0;

            foreach (Pedagio pedagio in Dados.Pedagios)
                totalArrecadado += pedagio.TotalRecebidoDePedagios;

            ucValorTotalRecebido.TextoLabel2 = "R$ " + totalArrecadado.ToString("0.00");
            AtualizaValor();
        }
        public void AtualizaValor()
        {
            ucIdentificacao.TextoLabel2 = Dados.Pedagios[index].Identificacao;
            ucLocalizacao.TextoLabel2 = Dados.Pedagios[index].Localizacao;
            ucValorArrecadado.TextoLabel2 = "R$ " + Dados.Pedagios[index].TotalRecebidoDePedagios.ToString("0.00");
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (index < Dados.Pedagios.Count - 1)
                index++;
            else
                MessageBox.Show("Este é o último pedágio cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                MessageBox.Show("Este é o primeiro pedágio cadastrado.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int aux = Dados.Pedagios.FindIndex(c => c.Identificacao == txtPesquisa.Text);

            if (aux >= 0)
                index = aux;
            else
                MessageBox.Show("Este pedágio não existe.", "Erro !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            AtualizaValor();
        }
    }
}
