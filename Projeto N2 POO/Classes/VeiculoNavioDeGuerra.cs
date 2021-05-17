using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class VeiculoNavioDeGuerra : VeiculoNavio, IVeiculoDeGuerra
    {
        static private Random gerador = new Random(1);

        public string Atacar() => "O navio " + Identificacao + " disparou " +
                                  gerador.Next(1, 50) + " mísseis.";
    }
}
