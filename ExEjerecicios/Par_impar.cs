﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Par_impar
    {
        public void numero()
        {
            int n = Utilerias.validarint("Ingresa un valor: ");
            Console.Clear();

            if (n % 2 == 0)
                Console.WriteLine($"El numero {n} es un numero: Par");
            else
                Console.WriteLine($"El numero {n} es un numero: Impar");
        }
    }
}
