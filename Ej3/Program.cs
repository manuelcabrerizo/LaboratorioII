using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool gano = false;
            int cantOportunidad = 3;
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 7);

            for (int i = 0; i < cantOportunidad; i++)
            {
                Console.WriteLine("Indica el numero que creas: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio1)
                {
                    Console.WriteLine("Correcto , has acertado el numero");
                    gano = true;
                    break;
                }
                else
                {
                    if (i != cantOportunidad - 1)
                    {
                        if (numero < aleatorio1)
                        {
                            Console.WriteLine("Prueba un numero mas alto");
                        }
                        else
                        {
                            Console.WriteLine("Prueba un numero mas bajo");
                        }
                    }
                }
            }
            if (!gano)
                Console.WriteLine("No has acertado, era {0}", aleatorio1);
        }
    }
}
