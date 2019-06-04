using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos?");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < quant; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos?");
            quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < quant; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos?");
            quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < quant; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(A);
            novo.UnionWith(B);
            novo.UnionWith(C);
            Console.WriteLine("Total de alunos: " + novo.Count);
        }
    }
}
