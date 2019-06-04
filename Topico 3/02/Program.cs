using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("A = {0:F4}", 3.14159 * Math.Pow(raio, 2));
        }
    }
}
