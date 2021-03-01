using System;

namespace Ejercicios9
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, multi = 1, j = 0; ;
            do
            {

                Console.Write("Ingresar valores: ");
                valor = int.Parse(Console.ReadLine());
                for (int i = 0; i < 11; i++)
                {
                    multi = i * valor;
                    Console.WriteLine("{0} x {1} = {2}", valor, i, multi);
                }

            } while (valor != -1);
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            MainClass p = new MainClass();
            p.cargar();

        }
    }
}
