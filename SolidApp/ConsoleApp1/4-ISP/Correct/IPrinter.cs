using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Correct
{
    // Interfaces segregadas
    public interface IPrinter
    {
        void Print(Document doc);
    }
}
