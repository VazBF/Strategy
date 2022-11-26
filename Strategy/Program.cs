using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##Padrão Strategy##");

            Calculadora calc = new Calculadora(new Soma());

            Console.WriteLine("Informe o primeiro numero:");
            var operandoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            var operandoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a operacao:");
            var operacao = Console.ReadLine();

            if (String.Equals(operacao, "-"))
            {
                calc.setOperacao(new Subtracao());
            }
            else if (String.Equals(operacao, "*"))
            {
                calc.setOperacao(new Multiplicacao());
            }
            else if (String.Equals(operacao, "/"))
            {
                calc.setOperacao(new Divisao());
            }

            calc.calcularOperacao(operandoA, operandoB);
        }
    }
}