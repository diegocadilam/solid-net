using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Correct
{
    /*
     * "Entidades de software (classes, módulos, funções, etc.) devem estar abertas para extensão, mas fechadas para modificação."
     * Ou seja, você deve conseguir adicionar funcionalidades sem alterar o código existente, favorecendo a extensibilidade sem quebrar funcionalidades.
     */
    internal class Implementacao
    {
        public void ImplementacaoMethod(){
            var service = new DescontoService();

            var desconto = new DescontoPremium();
            var totalComDesconto = service.CalcularDesconto(desconto, 100); // retorna 80
        }
    }
}
