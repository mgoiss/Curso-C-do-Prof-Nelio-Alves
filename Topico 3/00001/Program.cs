using System;

namespace _00001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor Inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
