using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    abstract class Conta
    {
        protected double saldo = 0;

        public virtual void sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo = this.saldo - valor;
                Console.WriteLine("Saque de: " + valor);
                this.juro();
            } else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void verSaldo()
        {
            Console.WriteLine("Saldo: " + this.saldo);
        }

        public double verSaldo2()
        {
            return this.saldo;
        }

        public virtual void depositar(double valor)
        {
            this.saldo = this.saldo + valor;
            Console.WriteLine("Depósito de: " + valor);
            this.juro();
        }

        public abstract void juro();
    }
}
