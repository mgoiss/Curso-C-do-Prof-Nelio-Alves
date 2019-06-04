using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os Valores: ");
            string[] valores = Console.ReadLine().Split(' ');

            Console.WriteLine("CIRCULO: {0}", 3.14159 * Math.Pow(double.Parse(valores[2]), 2));
        }
    }
    }
}
