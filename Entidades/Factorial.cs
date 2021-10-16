using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5Aplicada.Entidades
{
    public class Factorial
    {

        public int Numero { get; set; }
        public int FactorialN { get; set; }

        public Factorial()
        {
            Numero = 0;
            FactorialN = 1;
        }

        public Factorial(int numero, int factorial)
        {
            Numero = numero;
            FactorialN = factorial;
        }
    }
}
