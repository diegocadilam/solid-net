using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    public class DescontoService
    {
        public decimal CalcularDesconto(IDesconto desconto, decimal valorCompra)
        {
            return desconto.Calcular(valorCompra);
        }
    }
}
