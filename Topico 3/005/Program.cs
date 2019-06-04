using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo Item:");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            int quant = int.Parse(Console.ReadLine());

            if(cod == 1)
            {
                Console.WriteLine("Total: R${0:F2}", 4.0 * quant);
            }
            else if (cod == 2)
            {
                Console.WriteLine("Total: R${0:F2}", 4.5 * quant);
            }
            else if(cod == 3)
            {
                Console.WriteLine("Total: R${0:F2}", 5.0 * quant);
            }
            else if(cod == 4)
            {
                Console.WriteLine("Total: R${0:F2}", 2.0 * quant);
            }
            else if(cod == 5)
            {
                Console.WriteLine("Total: R${0:F2}", 1.5 * quant);
            }
            else
            {
                Console.WriteLine("Codigo Invalido");
            }
        }
    }
}
