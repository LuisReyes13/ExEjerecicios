using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Ordenarcn
    {
        public void ordenarnum()
        {
            int[] numeros = { 250, 100, 23, 145, 122, 432, 107, 109, 265, 194, 1 };
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        public void ordenarnumlinq()
        {
            List<int> numeros = new List<int>() { 250, 100, 23, 145, 122, 432, 107, 109, 265, 194, 1 };
            List<int> nord = numeros.OrderBy(x => x).ToList();
            foreach (int x in nord)
                Console.WriteLine(x);
        }
    }
}
