using System;
using System.Globalization;

namespace Exercicio_4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcetagem)
        {
            SalarioBruto += SalarioBruto * (porcetagem / 100.00);
        }

        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
