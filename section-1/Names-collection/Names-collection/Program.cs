using System;
using System.Collections.Generic;

namespace Names_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            bool status = true;
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Esta aplicación retorna todos los nombres que contenga la silaba \"RE\"");

            while (status)
            {
                Console.WriteLine("Porfavor, ingresa un nombre");
                var name = Console.ReadLine();
                names.Add(name);
                Console.WriteLine("Desea ingresar otro nombre?, SI: cualquier caracter, No: ingresar X");
                var again = Console.ReadLine();

                if (again.ToLower() == "x")
                    status = false;
            }

            Console.WriteLine("Resultado con los nombres con la silaba \"RE\"");

            var result = names.FindAll(x => x.ToLower().Contains("re"));

            result.ForEach(name =>
            {
                Console.WriteLine(name);
            });

            Console.ReadKey();
        }
    }
}
