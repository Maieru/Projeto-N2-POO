using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class Aviao : VeiculoBase, IVeiculoPossuiPassageiro, IVeiculoComLimpador
    {
        public int CapacidadeDePassageiro { get; set; }
        public bool LimpadorLigado { get; private set; }
        public string AlteraLimpador()
        {
            if (LimpadorLigado)
                return "Limpador do veículo " + " " + Identificacao + " desligado.";

            return "Limpador do veículo " + " " + Identificacao + " ligado.";
        }
    }
}
