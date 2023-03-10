using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Impnimpar
    {
        public void nImpar()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
