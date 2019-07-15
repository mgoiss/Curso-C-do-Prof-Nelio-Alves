using System;
using System.Globalization;
using Topico_11.Entities;
using Topico_11.Entities.Exceptions;

namespace Topico_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da Conta:");
            Console.Write("Numero: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de Saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account conta = new Account(n, nome, saldo, limite);

            Console.Write("\nValor para Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                conta.Withdraw(saque);
                Console.WriteLine("Saldo: " + conta.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
