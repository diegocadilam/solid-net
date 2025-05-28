using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    public class DescontoRegular : IDesconto
    {
        public decimal Calcular(decimal valorCompra) => valorCompra * 0.1m;
    }
}
