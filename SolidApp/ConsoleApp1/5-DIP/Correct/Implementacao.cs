using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.Correct
{
    internal class Implementacao
    {
        /*
         * O Princípio da Inversão de Dependência (Dependency Inversion Principle - DIP) é o "D" do SOLID e afirma:
           "Dependa de abstrações, não de implementações."
            Ou seja, módulos de alto nível não devem depender de módulos de baixo nível; ambos devem depender de abstrações.
         */
        public void ImplementacaoMethod() 
        {
            INotificador notificador = new EmailService();
            var pedidoService = new PedidoService();
            pedidoService.FinalizarPedido(notificador);

            INotificador notificadorWa = new WhatsAppService();            
            pedidoService.FinalizarPedido(notificadorWa);
        }
    }
}
