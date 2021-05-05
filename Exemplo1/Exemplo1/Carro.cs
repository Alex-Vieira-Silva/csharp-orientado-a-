using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    class Carro
    {
        // Atributos -> Caracteristicas
        public string modelo = "";

        // Métodos -> Ações
        public void ligar()
        {
            Console.WriteLine("Ligou " + this.modelo);
        }
    }
}