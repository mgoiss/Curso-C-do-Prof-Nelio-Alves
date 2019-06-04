using System;

namespace Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);
            int[,] matriz = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if(matriz[i, j] == num)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }                        

                        if(i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }                       
                    }
                }
            }
        }
    }
}
