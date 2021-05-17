using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class VeiculoTrem : VeiculoBaseComPassageiro, IVeiculoComLimpador
    {
        private int quantidadeDeVagoes;

        public bool LimpadorLigado { get; private set; }
        public int QuantidadeDeVagoes
        {
            get => quantidadeDeVagoes;
            set
            {
                if (value < 0)
                    throw new Exception("Número de vagões deve ser maior ou igual a 0");
                quantidadeDeVagoes = value;
            }
        }

        public string AlteraLimpador()
        {
            if (LimpadorLigado)
            {
                LimpadorLigado = false;
                return "Limpador do veículo " + " " + Identificacao + " desligado.";
            }
            LimpadorLigado = true;
            return "Limpador do veículo " + " " + Identificacao + " ligado.";
        }
    }
}
