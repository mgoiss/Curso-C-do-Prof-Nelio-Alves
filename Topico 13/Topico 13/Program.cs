using System;
using System.IO;
using Topico_13.Classes;
using System.Globalization;

namespace Topico_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o diretorio do Arquivo: ");
            string diretorio = Console.ReadLine();

            try
            {
                string[] dados = File.ReadAllLines(diretorio);

                string diretorioPasta = Path.GetDirectoryName(diretorio);
                string diretorioNovaPasta = diretorioPasta + @"\out";
                string diretorioNovoArquivo = diretorioNovaPasta + @"\summary.csv";

                Directory.CreateDirectory(diretorioNovaPasta);

                using (StreamWriter novoArquivo = File.AppendText(diretorioNovoArquivo))
                {
                    foreach (string linha in dados)
                    {
                        string[] dadosLinha = linha.Split(",");
                        string nome = dadosLinha[0];
                        double preco = double.Parse(dadosLinha[1], CultureInfo.InvariantCulture);
                        int quant = int.Parse(dadosLinha[2]);

                        Produto prod = new Produto(nome, preco, quant);

                        novoArquivo.WriteLine(prod.nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }                   
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
