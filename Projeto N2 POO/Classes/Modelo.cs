using Projeto_N2_POO.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Classes
{
    public class Modelo
    {
        private int codigo;
        private string descricao;
        EnumTipoVeiculo tipoVeiculo;

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
        public EnumTipoVeiculo TipoVeiculo
        {
            get => tipoVeiculo;
            set
            {
                if (value < 0)
                    throw new Exception("O modelo deve estar associado a um tipo de veículo.");
                tipoVeiculo = value;
            }
        }

        /// <summary>
        /// Método que retorna as propriedades da classe como string.
        /// </summary>
        /// <returns>Os atributos da classe, na seguinte ordem: 
        /// Codigo|Descrição|Codigo da Marca|Tipo|Descrição da Marca|Tipos Produzidos</returns>
        public override string ToString()
        {
            return "Codigo: " + Codigo + "|" + "Descrição: " + "|" + 
                "Tipo: " + TipoVeiculo.ToString() + "|" + Descricao + "|" + Marca.ToString();
        }

        public Modelo(int codigo, string descricao, Marca marca, EnumTipoVeiculo tipoVeiculo)
        {
            Codigo = codigo;
            Descricao = descricao;
            Marca = marca;
            TipoVeiculo = tipoVeiculo;
        }
    }
}
