using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            string n = Console.ReadLine();

            if(n[0] == '-')
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }
        }
    }
}
