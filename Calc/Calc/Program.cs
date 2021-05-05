using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            c.n1 = 10;
            c.n2 = 20;

            Console.WriteLine(c.somar());
            Console.WriteLine(c.diminuir());
            Console.WriteLine(c.dividir());
            Console.WriteLine(c.multiplicar());

            Console.ReadKey();
        }
    }
}
