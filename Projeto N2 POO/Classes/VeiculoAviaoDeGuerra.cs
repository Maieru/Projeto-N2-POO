using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class VeiculoAviaoDeGuerra : VeiculoAereoBase, IVeiculoDeGuerra, IVeiculoEjetavel
    {
        static private Random gerador = new Random(0);
        public string Atacar() => "O avião " + Identificacao + " bombardeou " +
                                  gerador.Next(1, 50) + " inimigos.";
        public string Ejetar() => "O piloto do avião " + Identificacao + " ejetou e" +
                                  (gerador.Next() % 4 == 0 ?
                                  " foi capturado por nossos inimigos." : " passa bem.");
    }
}
