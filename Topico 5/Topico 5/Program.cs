using System;
using System.Globalization;

namespace Topico_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());

            if(op == 's' || op == 'S')
            {
                Console.Write("Ente o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(num, titular, valor);
            }
            else
            {
                conta = new ContaBancaria(num, titular);
            }

            Console.WriteLine("\nDados da conta: \n" + conta);

            Console.Write("\nEntre um valorr para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: \n" + conta);

            Console.Write("\n Entre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Daados da conta Atualizados: \n" + conta);
        }
    }
}
