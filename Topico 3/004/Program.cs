using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hora Inicial: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora Final: ");
            int final = int.Parse(Console.ReadLine());

            int duracao = 0;

            if (inicio < final)
            {
                duracao = final - inicio;
            }
            else
            {
                duracao = 24 - inicio + final;
            }        


            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
