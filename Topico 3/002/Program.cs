using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
