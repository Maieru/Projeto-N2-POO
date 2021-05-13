using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class Modelo
    {
        private int codigo;
        private string descricao;

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("O código deve ser válido ( maior que 0 )");
                codigo = value;
            }
        }
        public string Descricao
        {
            get => descricao;
            set
            {
                if (value.Trim().Length <= 0)
                    throw new Exception("A identificação deve ser preenchida.");
                descricao = value;
            }
        }
        public Marca Marca { get; set; }

        public Modelo(int codigo, string descricao, Marca marca)
        {
            Codigo = codigo;
            Descricao = descricao;
            Marca = marca;
        }
    }
}
