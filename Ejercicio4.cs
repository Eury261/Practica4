using System;

namespace Ejercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int i, mayor = 0, n = 0;

            for (i = 0; i < 10; i++)
            {

                Console.Write("Ingrese un numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 10)
            {
                if (numeros[n] > mayor)
                {
                    mayor = numeros[n];
                }
                n++;
            }
            Console.WriteLine("El mayor es el " + mayor);
            Console.ReadKey();

        }
    }
}
