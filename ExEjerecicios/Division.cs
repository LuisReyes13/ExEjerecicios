﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEjerecicios
{
    internal class Division
    {
        /*
        private float _dividendo { get; set; }
        private float _divisor { get; set; }
        public float _cociente { get { return _dividendo / _divisor; } }
        private int _resto { get;}
        public Division(float dividendo, float divisor)
        {
            this._dividendo = dividendo;
            this._divisor = divisor;
            //_cociente = _dividendo / _divisor;
            //_resto = (int)(_dividendo % _divisor);
        }*/
        public void division()
        {
            float res;
            float n1 = Utilerias.validarnum("Ingresa primer valor: ");
            Console.Clear();
            float n2 = Utilerias.validarnum("Ingresa segundo valor: ");
            Console.Clear();
            if (n1 > n2)
            {
                res = n1 / n2;
                Console.WriteLine($"La division de {n1}/{n2} = {res}");
            }
            else
            {
                res = n2 / n1;
                Console.WriteLine($"La division de {n2}/{n1} = {res}");
            }
        }
    }
}
