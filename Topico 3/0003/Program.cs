using System;

namespace _0003
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaso = 0, alco = 0, die = 0, cod = 0;

            while (cod != 4)
            {
                Console.Write("Informe o código do produto: ");
                cod = int.Parse(Console.ReadLine());

                if(cod == 1)
                {
                    alco += 1;
                }
                else if(cod == 2)
                {
                    gaso += 1;
                }
                else if(cod == 3)
                {
                    die += 1;
                }
                else if(cod < 1 || cod > 4)
                {
                    Console.WriteLine("Código Invalido");
                }
            }

            Console.WriteLine("\n\nMUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alco);
            Console.WriteLine("Gasolina: " + gaso);
            Console.WriteLine("Diesel: " + die);
        }
    }
}
