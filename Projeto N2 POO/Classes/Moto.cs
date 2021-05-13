using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class Moto : VeiculoBase, IVeiculoPagaPedagio, IVeiculoPossuiPassageiro
    {
        public int CapacidadeDePassageiro { get; set; }

        public string Empinar() => "Empinando.";
        public double PagarPedagio() => 3;
    }
}
