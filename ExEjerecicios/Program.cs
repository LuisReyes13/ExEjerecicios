using ExEjerecicios;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

//Console.ForegroundColor = ConsoleColor.Green;
//Utilerias.menu();
/*List<int> OrdenarNumero = new List<int> { 250, 100, 23, 145, 122, 432, 107, 109, 265, 194, 1 };
OrdenarNumero.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
string test = "prueba";
test.ToUpper();
Console.WriteLine("El valor mayor es: " + OrdenarNumero.Max() + test);*/

for (int n = 0;n <= 100 && n%2==0; n+=2)
{
    if (n != 0)
    Console.WriteLine(n);
}
