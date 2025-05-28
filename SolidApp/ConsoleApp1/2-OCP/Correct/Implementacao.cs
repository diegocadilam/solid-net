using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    internal class Implementacao
    {
        public void ImplementacaoMethod(){
            var service = new DescontoService();

            var desconto = new DescontoPremium();
            var totalComDesconto = service.CalcularDesconto(desconto, 100); // retorna 80
        }
    }
}
