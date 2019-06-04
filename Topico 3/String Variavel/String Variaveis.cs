using System;
using System.Globalization;

namespace String_Variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é ${1}", produto1, preco1.ToString("F2"));
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}\n");

            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genero: " + genero + "\n");

            Console.WriteLine("Media com oito casas decimias: {0:F8}", media);
            Console.WriteLine($"Arredondando (três casas decimais): {media:f3}");
            Console.WriteLine("Separador decimal invriant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
