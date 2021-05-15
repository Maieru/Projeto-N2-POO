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
        public bool LimpadorLigado { get; private set; }

        public double PagarPedagio() => 7;
        public string AlteraLimpador()
        {
            if (LimpadorLigado)
                return "Limpador do veículo " + " " + Modelo + " desligado.";

            return "Limpador do veículo " + " " + Modelo + " ligado.";
        }
        public override string ToString()
        {
            return base.ToString() + CapacidadeDePassageiro + "|" +
                                   (LimpadorLigado? "Está" : "Não está") + "com limpador ligado";
        }
    }
}
