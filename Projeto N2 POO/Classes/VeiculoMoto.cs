using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class VeiculoMoto : VeiculoBaseComPassageiro, IVeiculoPagaPedagio
    {
        public bool Empinando { get; private set; } = false;
        public string Empinar()
        {
            if (Empinando)
                Empinando = false;
            else
                Empinando = true;

            return "A moto " + Identificacao +
                   (Empinando ? " está" : " não está") + " empinando";
        }
        public double PagarPedagio() => 3;
    }
}
