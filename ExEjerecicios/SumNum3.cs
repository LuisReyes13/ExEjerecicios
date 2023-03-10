using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class SumNum3
    {
        public void verSuma()
        {
            int a = Utilerias.validarint("Ingresa valor 1: ");
            int b = Utilerias.validarint("Ingresa valor 2: ");
            int c = Utilerias.validarint("Ingresa valor 3: ");

            Console.WriteLine($"Dados los numeros '{a}', '{b}', '{c}'");

            if (a == suma(b, c))
                Console.WriteLine($"El numero {a} es la suma de {b} + {c}");
            else if (b == suma(a, c))
                Console.WriteLine($"El numero {b} es la suma de {a} + {c}");
            else if (c == suma(a, b))
                Console.WriteLine($"El numero {c} es la suma de {a} + {b}");
            else
                Console.WriteLine("Ninguno de los numeros es la suma de los otros dos");
        }
        private int suma(int n1, int n2)
        {
            int s = n1 + n2;
            return s;
        }
    }
}
