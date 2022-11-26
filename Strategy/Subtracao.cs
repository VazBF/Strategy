using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Subtracao : Operacao
    {
        public void calcular(int operandoA, int operandoB)
        {
            int resultado = operandoA - operandoB;
            Console.WriteLine($" '{operandoA}' - '{operandoB}' = '{resultado}'");
        }
    }
}
