using System;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mes = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            int meses;

            Console.Write("Ingrese numero de mes: ");
            meses = int.Parse(Console.ReadLine());

            if (meses == 1)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[0]);
            }
            if (meses == 2)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[1]);
            }
            if (meses == 3)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[2]);
            }
            if (meses == 4)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[3]);
            }
            if (meses == 5)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[4]);
            }
            if (meses == 6)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[5]);
            }
            if (meses == 7)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[6]);
            }
            if (meses == 8)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[7]);
            }
            if (meses == 9)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[8]);
            }
            if (meses == 10)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[9]);
            }
            if (meses == 11)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[10]);
            }
            if (meses == 12)
            {
                Console.WriteLine("El mes numero {0} tiene {1} dias", meses, mes[11]);
            }
            if (meses <= 0 || meses >= 13)
            {
                Console.WriteLine("No existe ese mes");
            }
            Console.ReadKey();

        }
    }
}
