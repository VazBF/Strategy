using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Calculadora
    {
        private Operacao operacao;

        public Calculadora(Operacao operacao)
        {
            this.operacao = operacao;
        }

        public void setOperacao(Operacao operacao)
        {
            this.operacao = operacao;
        }

        public void calcularOperacao(int operandoA, int operandoB)
        {
            operacao.calcular(operandoA, operandoB);
        }
    }
}
