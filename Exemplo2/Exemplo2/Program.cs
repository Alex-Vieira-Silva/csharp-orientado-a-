﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.verSaldo();
            c1.depositar(100);
            //c1.verSaldo();
            c1.sacar(100, "Dolar");
            //c1.depositar();
            c1.verSaldo();

            Conta c2 = new Conta();
            c2.verSaldo();

            Console.ReadKey();
        }
    }
}
