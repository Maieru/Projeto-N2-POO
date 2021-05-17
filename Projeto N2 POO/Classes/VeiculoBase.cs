using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_N2_POO.Interfaces;

namespace Projeto_N2_POO.Classes
{
    public abstract class VeiculoBase
    {
        private string identificacao;
        private int velocidade = 0;

        public string Identificacao
        {
            get => identificacao;
            set
            {
                if (value.Trim().Length <= 0)
                    throw new Exception("A identificação deve ser preenchida.");
                identificacao = value;
            }
        }
        public Modelo Modelo { get; set; }
        public int Velocidade
        {
            get => velocidade;
            private set
            {
                if (value < 0)
                    throw new Exception("A velocidade não pode ser negativa.");
                velocidade = value;
            }
        }

        public virtual void Acelera() => Velocidade++;
        public void Desacelera() => Velocidade--;

        public override string ToString() {

            return Identificacao + "|" + Modelo + "|" + Velocidade + "|";
        }
    }
}
