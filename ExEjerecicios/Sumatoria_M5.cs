using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Sumatoria_M5
    {
        public void sumatoria()
        {
            Console.WriteLine($"La suma total es: {sumam5()}");
        }
        public int sumam5()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    suma += i;
                    Console.WriteLine(i);
                }
            }
            return suma;
        }
    }
}
