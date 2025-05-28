using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.Correct
{
    public class WhatsAppService : INotificador
    {
        public void Notificar(string mensagem)
        {
            Console.WriteLine("Whatsapp enviado...");
        }
    }
}
