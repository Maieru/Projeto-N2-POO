using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class Carro : VeiculoBase, IVeiculoComEixos, IVeiculoPagaPedagio, IVeiculoPossuiPassageiro, IVeiculoComLimpador
    {
        public int QuantidadeDeEixos { get; set; }
        public int CapacidadeDePassageiro { get; set; }

        public Marca Marca { get; set; }

        public double PagarPedagio()
        {
            Console.WriteLine("Veículo " + Marca + " " + Modelo + " pagou R$ 7,00.");

            return 7.00;
        }

        public void LigaDesligaLimpador()
        {
            Console.WriteLine("Limpador do veículo " + Marca + " " + Modelo + "  ligado.");
        }

        
    }
}
