using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class VeiculoNavio : VeiculoBaseComPassageiro, IVeiculoMarinho
    {
        public bool VeiculoEstaNoMar { get; private set; }

        public string Atracar()
        {
            if (VeiculoEstaNoMar)
            {
                VeiculoEstaNoMar = false;
                return "O navio " + Identificacao + " atracou com sucesso.";
            }
            else
                return "O navio " + Identificacao + " já está atracado.";
        }
        public string Navegar()
        {
            if (!VeiculoEstaNoMar)
            {
                VeiculoEstaNoMar = true;
                return "O navio " + Identificacao + " saiu para navegar.";
            }
            else
                return "O navio " + Identificacao + " já está navegando.";
        }
    }
}
