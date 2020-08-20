using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond;
            int dado = miliseg % 100 + 1;
            Console.WriteLine("El numero del dado es {0}", dado);
        }
    }
}
