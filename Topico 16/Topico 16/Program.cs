using System;
using System.Collections.Generic;
using Topico_16.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Topico_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o diretorio do Arquivo: ");
            string Diretorio = Console.ReadLine();

            Console.Write("Informe o Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Funcionario> dados = new List<Funcionario>();

            using (StreamReader sr = File.OpenText(Diretorio))
            {
                while(!sr.EndOfStream)
                {
                    string[] valores = sr.ReadLine().Split(",");
                    dados.Add(new Funcionario(valores[0], valores[1], double.Parse(valores[2], CultureInfo.InvariantCulture)));
                }            
            }

            var email = dados.Where(f => f.Salario > salario).OrderBy(f => f.Email).Select(f => f.Email);
            foreach( string valor in email)
            {
                Console.WriteLine(valor);
            }

            var soma = dados.Where(f => f.Nome[0] == 'M' || f.Nome[0] == 'm').Sum(f => f.Salario);
            Console.WriteLine("Soma do Salario dos Funcionarios com letra M: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
