using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class Aviao : VeiculoAereoBase, IVeiculoComLimpador
    {
        public bool LimpadorLigado { get; private set; }

        public string AlteraLimpador()
        {
            if (LimpadorLigado)
            {
                LimpadorLigado = false;
                return "Limpador do veículo " + Identificacao + " desligado.";
            }
            LimpadorLigado = true;
            return "Limpador do veículo " + Identificacao + " ligado.";
        }
    }
}
