using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Interfaces
{
    interface IVeiculoPagaPedagio
    {
        /// <summary>
        /// Método para pagar o pedágio.
        /// </summary>
        /// <returns>Retorna o valor que o veiculo pagou de pedágio.</returns>
        double PagarPedagio();
    }
}
