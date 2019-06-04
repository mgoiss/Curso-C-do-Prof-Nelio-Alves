using System;

namespace _0001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma Senha: ");
            string senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("\nSenha Invalida\n\n");
                Console.Write("Informe uma Senha: ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("\nAcesso Permitido");
        }
    }
}
