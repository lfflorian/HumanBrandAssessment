using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("La siguiente apliación devuelve el numero mas grande de un listado ingresado");

            Int16 count = 0;
            int[] numbers = new int[10];

            Console.WriteLine("debe ingresar numeros del 1 al 10");

            while (count < 10)
            {
                Console.WriteLine("Ingrese un numero");
                int number = 0;

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Este no es un numero, por favor ingrese un numero entero");
                }

                numbers[count] = number;
                count++;
            }

            var biggestNumber = numbers.Max();

            Console.WriteLine($"El numero mayor ingresado es: {biggestNumber}");
            Console.ReadKey();
        }
    }
}
