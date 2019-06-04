using System;
using System.Globalization;

namespace Entrada_de_Dados
{
    class Entrada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            char quarto = char.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');
            string n = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);


            Console.WriteLine("\n" + nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(n);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
