using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", n1, n2, n1+n2);
        }
    }
}
