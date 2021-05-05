using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    class ContaPoupanca : Conta
    {
        public override void depositar(double valor)
        {
            base.depositar(valor);
            this.saldo += 1; 
        }

        public override void juro()
        {
            this.saldo += 1;
        }
    }
}
