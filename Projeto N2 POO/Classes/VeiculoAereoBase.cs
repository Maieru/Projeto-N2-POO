using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    abstract class VeiculoAereoBase : VeiculoBaseComPassageiro, IVeiculoVoa
    {
        public bool VeiculoEstaNoAr { get; private set; }
        public void Pousar()
        {
            if (VeiculoEstaNoAr)
                VeiculoEstaNoAr = false;
            else
                throw new Exception("A aeronave " + Identificacao + " já está no solo.");
        }
        public void Decolar()
        {
            if (!VeiculoEstaNoAr)
                VeiculoEstaNoAr = true;
            else
                throw new Exception("A aeronave " + Identificacao + " já está voanda.");
        }
        public string Arremeter() => "A aeronave " + Identificacao + " está abortando a descida"; 
    }
}
