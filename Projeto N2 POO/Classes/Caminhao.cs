using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class Caminhao : VeiculoBase, IVeiculoComEixos, IVeiculoComLimpador, IVeiculoPossuiPassageiro, IVeiculoPagaPedagio
    {
        private double pesoCarregado = 0;
        private double capacidadeMaxima = 0;

        public int QuantidadeDeEixos { get; set; }
        public bool LimpadorLigado { get; private set; }
        public int CapacidadeDePassageiro { get; set; }
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
                return "Limpador do veículo " + " " + Modelo + " desligado.";

            return "Limpador do veículo " + " " + Modelo + " ligado.";
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
