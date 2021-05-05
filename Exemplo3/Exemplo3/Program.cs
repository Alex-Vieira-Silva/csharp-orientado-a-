using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta = new ContaPoupanca();
            conta.verSaldo2();

            Console.WriteLine(conta.verSaldo2());

            Console.ReadKey();

            /*
            Console.WriteLine("Selecione uma conta: ");
            string tipo = Console.ReadLine();

            Conta conta = null;

            if (tipo == "1")
            {
                conta = new ContaCorrente();
            } else
            {
                conta = new ContaPoupanca();
            }

            conta.depositar(101);
            conta.verSaldo();
            conta.sacar(100);
            conta.verSaldo();

            Console.ReadKey();
            

            ContaCorrente conta = new ContaCorrente();
            conta.verSaldo();
            conta.depositar(101);
            conta.verSaldo();
            conta.sacar(100);
            conta.verSaldo();
    

            ContaPoupanca poup = new ContaPoupanca();
            poup.verSaldo();
            poup.depositar(49);
            poup.verSaldo();
            poup.sacar(50);
            poup.verSaldo();*/
        }
    }
}
