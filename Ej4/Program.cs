using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio, introducido; int restantes = 13;
            Random generador = new Random(); aleatorio = generador.Next(1, 10001);

            do
            {
                Console.WriteLine("Te quedan {0} intentos", restantes);
                Console.Write("Introduce un número: ");

                introducido = Convert.ToInt32(Console.ReadLine());

                if (introducido == aleatorio)
                {
                    break;
                }

                if (introducido < aleatorio)
                    Console.WriteLine("Te has quedado corto");

                if (introducido > aleatorio)
                    Console.WriteLine("Te has pasado");

                restantes--;

            }
            while ((introducido != aleatorio) && (restantes >= 1));

            if (introducido == aleatorio) Console.WriteLine("Has ganado!");
            else
            {
                Console.WriteLine("Has perdido!"); Console.WriteLine("Era el {0}", aleatorio);
            }
        }
    }
}
