using System;

namespace _00002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de valores: ");
            int quant = int.Parse(Console.ReadLine());
            int sim = 0, nao = 0;
            

            for (int i = 1; i <= quant; i++)
            {
                Console.Write("Valor {0}°: ", i);
                int valores = int.Parse(Console.ReadLine());

                if(valores >= 10 && valores <= 20)
                {
                    sim += 1;
                }
                else
                {
                    nao += 1;
                }
            }

            Console.WriteLine(sim + " in");
            Console.WriteLine(nao + " out");
        }
    }
}
