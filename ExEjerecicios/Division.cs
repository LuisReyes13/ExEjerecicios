using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Division
    {
        public void division()
        {
            int n;
            string vn;
            bool esNumero;

            do
            {
                Console.Write("Ingresa primer numero entero: ");
                vn = Console.ReadLine();
                esNumero = int.TryParse(vn, out n);
                Console.Clear();
            } while (!esNumero);
        }
    }
}
