using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    class ContaCorrente : Conta, ICPMF
    {
        public void calculaTributo()
        {
            this.saldo -= 1;
        }

        public override void juro()
        {
            this.saldo -= 1;
        }

        // Overriding
        public override void sacar(double valor)
        {
            // Invocar o método da classe PAI
            base.sacar(valor);
            this.saldo = this.saldo - 1;
            this.calculaTributo();
        }

        public void teste() { }
    }
}
