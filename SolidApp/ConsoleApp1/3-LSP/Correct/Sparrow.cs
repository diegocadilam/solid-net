using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.Correct
{
    public class Sparrow : Bird, IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("Pardal voando...");
        }
    }
}
