using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Incorrect
{
    // Interface muito genérica
    public interface IMachine
    {
        void Print(Document doc);
        void Scan(Document doc);
        void Fax(Document doc);
    }
}
