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
            {
                Empinando = false;
                return "A moto " + Modelo + "não está mais empinando.";
            }
            else
            {
                Empinando = false;
                return "A moto " + Modelo + "não está mais empinando.";
            }
        }
        public double PagarPedagio() => 3;
    }
}
