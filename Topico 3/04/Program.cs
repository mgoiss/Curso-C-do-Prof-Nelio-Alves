using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero Funcionário: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Número Horas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor Horas: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero: {0}", num);
            Console.WriteLine("Salario: R${0:F2}", valor * horas);
        }
    }
}
