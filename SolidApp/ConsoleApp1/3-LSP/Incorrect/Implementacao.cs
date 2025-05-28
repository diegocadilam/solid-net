using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOLID._3_LSP.Incorrect
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Voando...");
        }
    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            //Problema: Um Ostrich não pode substituir um Bird sem quebrar o contrato(espera - se que Bird.Fly() funcione).
            throw new NotSupportedException("Avestruzes não voam!");
        }
    }

    // Uso:    
    internal class Implementacao
    {
        public void ImplementacaoMethod() {
            Bird bird = new Ostrich();
            bird.Fly(); // Exceção em tempo de execução: viola o LSP
        }
    }
}
