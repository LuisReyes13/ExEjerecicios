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
        public static void menu()
        {
            Par_impar ej1 = new Par_impar();
            Division ej2 = new Division();
            Sumatoria_M5 ej3 = new Sumatoria_M5();
            Impnimpar ej4 = new Impnimpar();
            Ordenarcn ej5 = new Ordenarcn();
            NumMayor3 ej6 = new NumMayor3();
            SumNum3 ej7 = new SumNum3();

            bool salir = false;

            while (!salir)
            {
                opcionesmenu();
                int opcion = validarint("Elige una de las opciones: ");

                switch (opcion)
                {
                    case 1:
                        ej1.numero();
                        break;
                    case 2:
                        ej2.division();
                        break;
                    case 3:
                        ej3.sumatoria();
                        break;
                    case 4:
                        ej4.nImpar();
                        break;
                    case 5:
                        ej5.ordenarnumlinq();
                        break;
                    case 6:
                        ej6.Mayor();
                        break;
                    case 7:
                        ej7.verSuma();
                        break;
                    case 8:
                        Console.WriteLine("Has elegido salir de la aplicación, presiona ENTER");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 8");
                        break;
                }
            }
            Console.ReadLine();
        }

        public static void opcionesmenu()
        {
            Console.WriteLine("1. Lee un numero y dice si es par o impar");
            Console.WriteLine("2. Lee 2 y divide el mayor entre el menor");
            Console.WriteLine("3. Suma numeros enteros multiplos de 5 entre 1 y 100");
            Console.WriteLine("4. Imprime numeros impar en orden descendente entre 1 y 100");
            Console.WriteLine("5. Ordena numeros establecidos");
            Console.WriteLine("6. Lee 3 numeros y determina cual es mayor");
            Console.WriteLine("7. Lee 3 numeros y determina si uno es la suma de los otros dos");
            Console.WriteLine("8. Salir");
        }
    }
}
