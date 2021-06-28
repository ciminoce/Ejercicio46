using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio46
{
    class Program
    {
        static void Main(string[] args)
        {
            var cantidad = 0;
            var suma = 0;
            do
            {
                Console.Write("Ingrese un número:");
                var numeroIngresado = Convert.ToInt32(Console.ReadLine());
                suma += numeroIngresado;
                cantidad++;
            } while (suma<=60);

            Console.WriteLine($"Se ingresaron {cantidad} de números");
            Console.WriteLine($"La suma de los mismos es {suma}");
            Console.ReadLine();

        }
	}
}
