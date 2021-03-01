using System;

namespace Ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.Write("Ingrese nombre: ");
                nombre[i] = Console.ReadLine();

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, nombre[i]);

            }
        }
}
