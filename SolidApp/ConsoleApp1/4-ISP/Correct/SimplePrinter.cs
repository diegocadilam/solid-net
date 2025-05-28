using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Correct
{
    public class SimplePrinter : IPrinter
    {
        public void Print(Document doc) => Console.WriteLine("Printing...");
    }
}
