using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.Correct
{
    public class PedidoService
    {
        private readonly INotificador _notificador;

        public PedidoService()
        {            
        }

        public void FinalizarPedido(INotificador notificador)
        {
            Console.WriteLine("Pedido finalizado");
            _notificador.Notificar("Seu pedido foi concluído.");
        }
    }
}
