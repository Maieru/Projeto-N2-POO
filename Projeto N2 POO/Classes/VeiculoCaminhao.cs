using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class VeiculoCaminhao : VeiculoBaseComPassageiro, IVeiculoComEixos, IVeiculoComLimpador, IVeiculoPagaPedagio
    {
        private double pesoCarregado = 0;
        private double capacidadeMaxima = 0;
        private int quantidadeDeEixos;

        public int QuantidadeDeEixos
        { 
            get => quantidadeDeEixos;
            set
            {
                if (value <= 0)
                    throw new Exception("O veiculo deve ter ao menos 1 eixo.");
                quantidadeDeEixos = value;
            }
        }
        public bool LimpadorLigado { get; private set; }
        public double PesoCarregado
        {
            get => pesoCarregado;
            private set
            {
                if (value < 0)
                    throw new Exception($"Você não pode descarregar {value}" +
                        $" kg, pois o caminhão só está carregado com {PesoCarregado}");
                pesoCarregado = value;
            }
        }
        public double CapacidadeMaxima
        {
            get => capacidadeMaxima;
            set
            {
                if (value < 3000)
                    throw new Exception("Capacidade máxima não deve ser menor que 3000 kg.");
                capacidadeMaxima = value;
            }
        }

        public string AlteraLimpador()
        {
            if (LimpadorLigado)
            {
                LimpadorLigado = false;
                return "Limpador do veículo " + " " + Identificacao + " desligado.";
            }
            LimpadorLigado = true;
            return "Limpador do veículo " + " " + Identificacao + " ligado.";
        }
        public double PagarPedagio() => 8.5 * QuantidadeDeEixos;
        public void Carregar(double peso) => PesoCarregado += peso;
        public void Descarregar(double peso) => PesoCarregado -= peso;
        public override void Acelera()
        {
            if (PesoCarregado > CapacidadeMaxima)
                throw new Exception("Não é possivel acelerar, já que o caminhão está carregado além de sua capacidade máxima.");
            base.Acelera();
        }
    }
}
