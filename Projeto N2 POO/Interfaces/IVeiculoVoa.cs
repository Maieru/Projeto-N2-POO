using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Interfaces
{
    interface IVeiculoVoa
    {
        bool VeiculoEstaNoAr { get; }

        void Pousar();
        string Arremeter();
        void Decolar();
    }
}
