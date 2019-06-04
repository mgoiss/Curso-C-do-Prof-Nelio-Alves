using System;
using System.Globalization;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu = new Aluno();

            Console.Write("Nome do Aluno: ");
            alu.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            alu.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alu.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alu.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nota = alu.calculo();

            if(nota >= 60)
            {
                Console.WriteLine("NOTA FINAL = " + nota.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + nota.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - nota).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
