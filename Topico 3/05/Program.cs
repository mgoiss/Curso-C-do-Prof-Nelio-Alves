using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código, Quantidade e o Valor da Primeira Peça: ");
            string[] peca = Console.ReadLine().Split(' ');
            double valor = double.Parse(peca[2]) * double.Parse(peca[1]);
            Console.WriteLine("Informe o código, Quantidade e o Valor da Segunda Peça: ");
            string[] pec = Console.ReadLine().Split(' ');
            valor = double.Parse(pec[2]) * double.Parse(pec[1]) + valor;

            Console.WriteLine("VALOR A PAGAR: R${0:F2}", valor);
        }
    }
}
