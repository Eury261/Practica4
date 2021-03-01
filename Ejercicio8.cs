using System;

namespace Ejercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] altura = new float[5];
            for (int i = 0; i < 5; i++)
            {

                Console.Write("Ingrese altura: ");
                altura[i] = float.Parse(Console.ReadLine());
            }

            float suma = 0, pro;
            for (int i = 0; i < 5; i++)
            {
                suma += altura[i];
            }
            pro = suma / 5;
            Console.WriteLine("Promedio: " + pro);

            int mayores = 0, menores = 0;
            for (int i = 0; i < 5; i++)
            {
                if (altura[i] > pro)
                {
                    mayores++;
                }
                if (altura[i] < pro)
                {
                    menores++;
                }
            }
            Console.WriteLine("Personas mayores: " + mayores);
            Console.WriteLine("Personas menores: " + menores);

        }
    }
}
