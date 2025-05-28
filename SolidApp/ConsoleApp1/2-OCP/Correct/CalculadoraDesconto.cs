using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    public class CalculadoraDesconto
    {
        private readonly IDesconto _estrategiaDesconto;
        
        public CalculadoraDesconto(IDesconto estrategiaDesconto)
        {
            _estrategiaDesconto = estrategiaDesconto;
        }

        public decimal AplicarDesconto(decimal valor)
        {
            return _estrategiaDesconto.Calcular(valor);
        }
    }
}
