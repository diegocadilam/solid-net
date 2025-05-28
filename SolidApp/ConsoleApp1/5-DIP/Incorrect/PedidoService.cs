using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.Incorrect
{
    public class PedidoService
    {
        private readonly EmailService _emailService;

        public PedidoService()
        {
            _emailService = new EmailService(); // Forte acoplamento
        }

        public void FinalizarPedido()
        {
            Console.WriteLine("Pedido finalizado");
            _emailService.EnviarEmail("Seu pedido foi concluído.");
        }
    }
}
