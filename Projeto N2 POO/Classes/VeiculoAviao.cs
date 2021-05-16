using Projeto_N2_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class VeiculoAviao : VeiculoBaseComPassageiro, IVeiculoVoa, IVeiculoComLimpador
    {
        public bool LimpadorLigado { get; private set; } = false;
        public bool VeiculoEstaNoAr { get; private set; } = false;

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
        public string Arremeter()
        {
            if (VeiculoEstaNoAr)
                return "O avião " + Identificacao + " arremeteu.";
            else
                return "O avião " + Identificacao + " não arremeteu por que está no chao.";
        }
        public void Decolar() => VeiculoEstaNoAr = true;
        public void Pousar() => VeiculoEstaNoAr = false;
    }
}
