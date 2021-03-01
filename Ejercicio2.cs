using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] valor = new float[5];

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("Ingrese numero verdadero: ");
                valor[f] = float.Parse(Console.ReadLine());
            }
            for (int f = 4; f >= 0; f--)
            {
                Console.WriteLine("Valor: " + valor[f]);
            }

            }
        }
}
