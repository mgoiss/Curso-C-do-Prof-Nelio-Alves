using System;
using Topico_10.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Topico_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de Produtos: ");
            int quant = int.Parse(Console.ReadLine());
            List<Product> produto = new List<Product>();

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Produto #{i}:");
                Console.Write("Comum, Usado ou Importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(tipo == 'i' || tipo == 'i')
                {
                    Console.Write("Valor Taxa: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    produto.Add(new ImportedProduct(nome, preco, taxa));
                }
                else if(tipo == 'u' || tipo == 'u')
                {
                    Console.Write("Data de Fabricação: (DD/MM/YY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    produto.Add(new UseProduct(nome, preco, data));
                }
                else
                {
                    produto.Add(new Product(nome, preco));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Itens: ");
            foreach (Product item in produto)
            {
                Console.WriteLine(item.PriceTag().ToString());
            }
            
        }
    }
}
