using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun1, fun2;
            fun1 = new Funcionario();
            fun2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            fun1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            fun1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            fun2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            fun2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (fun1.Salario + fun2.Salario) / 2.0;

            Console.WriteLine("Salário Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
