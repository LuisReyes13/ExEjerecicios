using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class NumMayor3
    {
        public void Mayor()
        {
            int n1 = Utilerias.validarint("Ingresa valor 1: ");
            int n2 = Utilerias.validarint("Ingresa valor 2: ");
            int n3 = Utilerias.validarint("Ingresa valor 3: ");

            Console.WriteLine($"Dados los numeros '{n1}', '{n2}', '{n3}'");

            if (n1 > n2)
            {
                if (n1 > n3)
                    mostrarmayor(n1);
                else if (n3 > n2)
                    mostrarmayor(n3);
                else
                    mostrarmayor(n2);
            }
            else if (n2 > n3)
                mostrarmayor(n2);
            else if (n3 > n1)
                mostrarmayor(n3);
            else
                Console.WriteLine("Todos los numeros son del mismo valor ¬¬");
        }
        private void mostrarmayor(int n)
        {
            Console.WriteLine($"El numero mayor es: {n}");
        }
    }
}
