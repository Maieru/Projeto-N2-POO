using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    abstract class VeiculoAereoBase : VeiculoBase, IVeiculoVoa, IVeiculoPossuiPassageiro
    {
        private bool aeronaveVoando = false;
        public int CapacidadeDePassageiro { get; set; }
        public void Pousar()
        {
            if (aeronaveVoando)
                aeronaveVoando = false;
            else
                throw new Exception("A aeronave " + Identificacao + " já está no solo.");
        }
        public void Decolar()
        {
            if (!aeronaveVoando)
                aeronaveVoando = true;
            else
                throw new Exception("A aeronave " + Identificacao + " já está voanda.");
        }
        public void Arremeter()
        {

        }
    }
}
