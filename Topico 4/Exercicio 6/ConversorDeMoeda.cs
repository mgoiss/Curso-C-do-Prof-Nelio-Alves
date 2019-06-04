using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolaParaReal(double cota, double quant)
        {
            double Total = quant * cota;
            return Total + Total * (Iof / 100);
        }
    }
}
