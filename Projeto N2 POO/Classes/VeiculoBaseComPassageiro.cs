using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class VeiculoBaseComPassageiro : VeiculoBase, IVeiculoPossuiPassageiro
    {
        private int capacidadeDePassageiro;

        public int CapacidadeDePassageiro
        {
            get => capacidadeDePassageiro;
            set
            {
                if (value <= 0)
                    throw new Exception("O numero de passageiros deve ser maior ou igual a 1.");
                capacidadeDePassageiro = value;
            }
        }
    }
}
