using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    public class DescontoPremium : IDesconto
    {
        public decimal Calcular(decimal valorCompra) => valorCompra * 0.2m;
    }
}
