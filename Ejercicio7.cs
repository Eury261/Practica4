using System;

namespace Ejercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            foreach (char letras in nombre)
            {
                Console.WriteLine(letras);
            }

            }
        }
}
