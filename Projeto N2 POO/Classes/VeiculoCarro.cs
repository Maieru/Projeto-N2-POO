using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class VeiculoCarro : VeiculoBaseComPassageiro, IVeiculoPagaPedagio, IVeiculoComLimpador
    {
        private int quantidadeDePortas;

        public int QuantidadeDePortas
        {
            get => quantidadeDePortas;
            set
            {
                if (value <= 0)
                    throw new Exception("O numero de portas deve ser maior ou igual a 1.");
                quantidadeDePortas = value;
            }
        }
        public bool LimpadorLigado { get; private set; }

        public double PagarPedagio() => 7;
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
        public override string ToString()
        {
            return base.ToString() + CapacidadeDePassageiro + "|" +
                                   (LimpadorLigado? "Está" : "Não está") + "com limpador ligado";
        }
    }
}
