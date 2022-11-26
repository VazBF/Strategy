using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Divisao : Operacao
    {
        public void calcular(int operandoA, int operandoB)
        {
            float resultado = operandoA / operandoB;
            Console.WriteLine($" '{operandoA}' / '{operandoB}' = '{resultado}'");
        }
    }
}
