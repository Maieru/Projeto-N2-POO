using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class Carro : VeiculoBase, IVeiculoPagaPedagio, IVeiculoPossuiPassageiro, IVeiculoComLimpador
    {
        public int CapacidadeDePassageiro { get; set; }

        public Marca Marca { get; set; }

        public double PagarPedagio()
        {
            return 7.00;
        }

        public string LigaDesligaLimpador()
        {
            return "Limpador do veículo " + Marca + " " + Modelo + "  ligado.";
        }

        public override string ToString()
        {
            return base.ToString() + Marca +  "|" + CapacidadeDePassageiro;
        }

    }
}
