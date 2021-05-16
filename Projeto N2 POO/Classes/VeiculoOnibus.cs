using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    class VeiculoOnibus : VeiculoBaseComPassageiro, IVeiculoComLimpador, IVeiculoComEixos, IVeiculoPagaPedagio
    {
        private int quantidadeDeEixos;

        public bool LimpadorLigado { get; private set; } = false;
        public int QuantidadeDeEixos
        {
            get => quantidadeDeEixos;
            set
            {
                if (value <= 0)
                    throw new Exception("O veiculo deve ter ao menos 1 eixo.");
                quantidadeDeEixos = value;
            }
        }
        public bool PossuiLeito { get; set; } = false;

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
        public double PagarPedagio() => 8.5 * QuantidadeDeEixos;
    }
}
