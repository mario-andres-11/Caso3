using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write(" Ingrese la temperatura en grados Celsius: ");

            double celsius;
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Error: Se debe ingresar valor numérico. ");
                Console.Write("Ingrese la temperatura en grados Celsius: ");
            }

            double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;

            Console.WriteLine($"\n{celsius} °C equivalen a {fahrenheit} °F");


        }
    }
}
