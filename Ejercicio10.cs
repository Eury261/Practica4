using System;

namespace Ejercicios10
{
    class MainClass
    {
        private string nombre;
        private int edad;

        public void cargar()
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

        }

        public void mostrar()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }

        public void mensaje()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            MainClass p = new MainClass();
            p.cargar();
            p.mostrar();
            p.mensaje();

        }
    }
}
