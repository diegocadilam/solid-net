using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.Correct
{
    internal class Implementacao
    {
        //Se S é um subtipo de T, então objetos do tipo T devem poder ser substituídos por objetos do tipo S sem alterar as propriedades desejáveis do programa.    
        public void ImplementacaoMethod() {
            // Uso:
            var birds = new List<Bird> { new Sparrow(), new Ostrich() };

            foreach (var bird in birds)
            {
                if (bird is IFlyingBird flyingBird)
                    flyingBird.Fly();
                else
                    Console.WriteLine($"{bird.GetType().Name} não voa.");
            }
        }
    }
}
