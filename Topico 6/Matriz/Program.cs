using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int[,] matriz = new int[n, n];
            int negativo = 0;
            Console.WriteLine("Valores: ");
            for (int i = 0; i < n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valor[j]);

                    if(matriz[i, j] < 0)
                    {
                        negativo += 1;
                    }
                }
            }

            Console.WriteLine("Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine("Números Negativos: " + negativo);
        }
    }
}
