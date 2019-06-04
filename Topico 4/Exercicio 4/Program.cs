using System;
using System.Globalization;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}", f);
        }
    }
}
