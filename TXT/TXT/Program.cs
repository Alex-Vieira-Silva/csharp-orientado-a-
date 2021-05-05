using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\rlsystem\curso.txt";

            Cliente cliente = new Cliente("Rafael", caminho);
            cliente.apagar();
        }
    }
}
