using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Correct
{
    /*    
     *  Uma classe deve ter um único motivo para mudar.
     *  Isso significa que uma classe, módulo ou função deve ter apenas uma responsabilidade ou função bem definida dentro de um sistema.
     */
    internal class Implement
    {
        public void ImplementSRPMethod()
        {
            var invoice = new Invoice { Id = 1, Amount = 100.00m };

            var repository = new InvoiceRepository();
            repository.Save(invoice);

            var printer = new InvoicePrinter();
            printer.Print(invoice);

            var emailSender = new InvoiceEmailSender();
            emailSender.Send(invoice);
        }
    }
}
