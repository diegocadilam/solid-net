using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.Incorrect
{
    public class EmailService
    {
        public void EnviarEmail(string mensagem)
        {
            Console.WriteLine($"Email enviado: {mensagem}");
        }
    }
}
