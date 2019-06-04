using System;
using System.Globalization;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolaParaReal(cota, quant).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
