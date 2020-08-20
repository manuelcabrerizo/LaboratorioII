using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();

            int aleatorio1 = dado.Next(1, 11);
            int aleatorio2 = dado.Next(11, 21);

            Console.WriteLine("El dado Uno: " + aleatorio1);
            Console.WriteLine("El dado Dos: " + aleatorio2);

        }
    }
}
