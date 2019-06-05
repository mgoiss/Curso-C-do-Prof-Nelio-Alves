using System;
using Topico_9.Entities.Enum;
using Topico_9.Entities;
using System.Globalization;

namespace Topico_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados da compra: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(name, email, dateBirth);
            Order compra = new Order(DateTime.Now, status, cliente);

            Console.Write("Quantidade de Itens: ");
            int quantItem = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantItem; i++)
            {
                Console.WriteLine($"Item {i}:");
                Console.Write("Nome Produto: ");
                string namePro = Console.ReadLine();
                Console.Write("Preço Produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantProd = int.Parse(Console.ReadLine());

                Product product = new Product(namePro, price);
                OrderItem itens = new OrderItem(quantProd, price, product);
                compra.AddItem(itens);
            }

            Console.WriteLine("\n" + compra);
        }
    }
}
