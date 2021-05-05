using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    class Conta
    {
        // public
        // private
        // protected

        // Atributos
        private double saldo = 0;
        public int agencia = 0;
        public int conta = 0;

        // Métodos
        public void sacar(double valor, string tipoMoeda)
        {
            this.saldo = this.saldo - valor;
            this.juro();
            Console.WriteLine("Realizado Saque de " + valor + " com moeda " + tipoMoeda);
        }

        private void juro()
        {
            this.saldo = this.saldo - 1;
        }

        public void depositar(double valor)
        {
            this.saldo = this.saldo + valor;
            Console.WriteLine("Deposito realizado: " + valor);
            this.verSaldo();
        }

        public void verSaldo()
        {
            Console.WriteLine("Seu saldo é: " + this.saldo);
        }

    }
}
