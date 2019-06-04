using System;

namespace Topico_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estu = new Estudante[10];

            Console.Write("Quantos Quartos Serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nAluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine()) - 1;
                
                estu[quarto] = new Estudante{Nome = nome, Email = email };
            }

            Console.Write("\nQuartos Ocupados: \n");
            for (int i = 0; i < 10; i++)
            {
                if(estu[i] != null)
                {
                    Console.WriteLine("{0}: {1}", i+1, estu[i]);
                }
            }
            
        }
    }
}
