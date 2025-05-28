using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Incorrect
{
    public class DescontoService
    {
        public decimal CalcularDesconto(string tipoCliente, decimal valorCompra)
        {
            if (tipoCliente == "Regular")
                return valorCompra * 0.1m;
            else if (tipoCliente == "Premium")
                return valorCompra * 0.2m;
            else
                return 0;
        }
    }
}
