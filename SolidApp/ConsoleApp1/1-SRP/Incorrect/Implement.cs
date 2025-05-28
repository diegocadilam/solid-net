using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Incorrect
{
    public class Implement
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public void SaveToDatabase()
        {
            // lógica de persistência
        }

        public void PrintInvoice()
        {
            // lógica de impressão
        }

        public void SendInvoiceEmail()
        {
            // lógica de envio de e-mail
        }
    }
}
