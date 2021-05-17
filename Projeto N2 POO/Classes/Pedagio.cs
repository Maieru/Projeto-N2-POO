using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class Pedagio
    {
        private string identificacao;
        private string localizacao;
        private double valorRecebido;

        public string Identificacao
        {
            get => identificacao;
            set
            {
                if (value.Trim().Length <= 0)
                    throw new Exception("A identificação deve ser preenchida.");
                identificacao = value;
            }
        }
        public string Localizacao
        {
            get => localizacao;
            set
            {
                if (value.Trim().Length <= 0)
                    throw new Exception("A identificação deve ser preenchida.");
                localizacao = value;
            }
        }
        public double TotalRecebidoDePedagios
        {
            get => valorRecebido;
            set
            {
                if (value < 0)
                    throw new Exception("O total de valor recebido no pedágio não pode ser menor que 0.");
                valorRecebido = value;
            }
        }

        public string Receber(IVeiculoPagaPedagio veiculo)
        {
            TotalRecebidoDePedagios += veiculo.PagarPedagio();

            return (veiculo as VeiculoBase).Identificacao + " pagou: " + veiculo.PagarPedagio();
        }
        public override string ToString()
        {
            return "Nome: " + Identificacao + 
                   "|Localização: " + Localizacao +
                   "|Total recebido: " + TotalRecebidoDePedagios;
        }
        public Pedagio(string identificacao, string localizacao)
        {
            Identificacao = identificacao;
            Localizacao = localizacao;
        }
    }
}
