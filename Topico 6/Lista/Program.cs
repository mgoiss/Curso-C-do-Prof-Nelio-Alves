using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de Fucionarios: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nFuncionário #" + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nDigite o Id do funcionário que terá o salario atualizado: ");
            int idBusca = int.Parse(Console.ReadLine());

            Funcionario indece = list.Find(x => x.Id == idBusca);

            if(indece != null)
            {
                Console.Write("Digite a Porcentagem: ");
                double porcetagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                indece.AumentaSalario(porcetagem);

                Console.WriteLine(list[0]);
                Console.WriteLine(indece);
            }
            else
            {
                Console.WriteLine("Id inexistente");
            }


            Console.WriteLine("\nLista atualizada de Funcionário: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
