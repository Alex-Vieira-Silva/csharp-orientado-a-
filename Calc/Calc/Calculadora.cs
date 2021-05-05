using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculadora
    {
        public double n1;
        public double n2;

        public double somar()
        {
            return n1 + n2;
        }

        public double diminuir()
        {
            return n1 - n2;
        }

        public double multiplicar()
        {
            return n1 * n2;
        }

        public double dividir()
        {
            return n1 / n2;
        }
    }
}
