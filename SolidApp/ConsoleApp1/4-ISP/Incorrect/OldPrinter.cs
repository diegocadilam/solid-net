using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Incorrect
{
    // Classe obrigada a implementar métodos que não precisa
    public class OldPrinter : IMachine
    {
        public void Print(Document doc) => Console.WriteLine("Printing...");

        public void Scan(Document doc)
        {
            throw new NotImplementedException(); // Violação do ISP
        }

        public void Fax(Document doc)
        {
            throw new NotImplementedException(); // Violação do ISP
        }
    }
}
