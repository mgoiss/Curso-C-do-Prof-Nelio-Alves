using System;
using System.Globalization;

namespace Execicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retan = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retan.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retan.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retan.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + retan.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retan.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
