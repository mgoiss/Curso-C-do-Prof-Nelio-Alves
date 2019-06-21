using System;
using System.Collections.Generic;
using System.Globalization;
using Execicio_Fixação.Entities;

namespace Execicio_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qunatidade de Contribuintes? ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> pessoa = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Comntribuinte #{1}: ");
                Console.Write("Individual ou Compania: (i/c)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Rendimento Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(tipo == 'i')
                {
                    Console.Write("Gastos com Saúde: ");
                    double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    pessoa.Add(new Individual(nome, renda, gastos));
                }
                else
                {
                    Console.Write("Numero de Funcionarios: ");
                    int quant = int.Parse(Console.ReadLine());

                    pessoa.Add(new Company(nome, renda, quant));
                }
            }

            double total = 00.00;
            Console.WriteLine();
            Console.WriteLine("Impostos Pagos: ");
            foreach (TaxPayer item in pessoa)
            {
                Console.WriteLine(item);
                total += item.Tax(); 
            }

            Console.WriteLine();
            Console.WriteLine("Total de Imposto: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
