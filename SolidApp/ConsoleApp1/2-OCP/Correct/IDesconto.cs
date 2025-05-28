using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    public interface IDesconto
    {
        decimal Calcular(decimal valorCompra);
    }
}
