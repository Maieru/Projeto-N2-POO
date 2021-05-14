using Projeto_N2_POO.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    class Marca
    {
        private int codigo;
        private string descricao;
        private List<EnumTipoVeiculo> tiposProduzidos;

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
                    throw new Exception("A descrição deve ser preenchida.");
                descricao = value;
            }
        } 
        public List<EnumTipoVeiculo> TiposProduzidos
        {
            get => tiposProduzidos;
            set
            {
                if (value == null || value.Count <= 0)
                    throw new Exception("A marca deve produzir ao menos 1 tipo de veiculo.");
                tiposProduzidos = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (EnumTipoVeiculo tipo in tiposProduzidos)
                sb.Append(tipo.ToString() + ", ");

            return "Código: " + Codigo + "|" +
                   "Descrição: " + Descricao + "|" +
                   "Tipos de veiculos manufaturados: " + sb.ToString();
        }

        public Marca(int codigo, string descricao, List<EnumTipoVeiculo> tiposProduzidos)
        {
            Codigo = codigo;
            Descricao = descricao;
            TiposProduzidos = tiposProduzidos;
        }
    }
}
