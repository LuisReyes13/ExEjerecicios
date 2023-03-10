using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Utilerias
    {
        public static int validarint(string mensaje)
        {
            int n;
            string vn;
            bool esNumero;

            do
            {
                Console.Write(mensaje);
                vn = Console.ReadLine();
                esNumero = int.TryParse(vn, out n);
                Console.Clear();
                if (esNumero == false)
                    Console.WriteLine("El valor capturado, no es un numero entero ¬¬");
            } while (!esNumero);
            return n;
        }
        public static float validarnum(string mensaje)
        {
            float n;
            string vn;
            bool esNumero;

            do
            {
                Console.Write(mensaje);
                vn = Console.ReadLine();
                esNumero = float.TryParse(vn, out n);
                Console.Clear();
                if (esNumero == false)
                Console.WriteLine("El valor capturado, no es un numero ¬¬");
            } while (!esNumero);
            return n;
        }
        public static int pedirnum()
        {
            Console.Write("Ingresar un numero: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
    }
}
