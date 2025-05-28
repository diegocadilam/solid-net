using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Correct
{
    // Implementação específica
    //"Nenhum cliente deve ser forçado a depender de métodos que não utiliza."
    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print(Document doc) => Console.WriteLine("Printing...");
        public void Scan(Document doc) => Console.WriteLine("Scanning...");
        public void Fax(Document doc) => Console.WriteLine("Faxing...");
    }
}
