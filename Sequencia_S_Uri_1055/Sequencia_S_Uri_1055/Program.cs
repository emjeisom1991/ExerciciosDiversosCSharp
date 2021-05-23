using System;
using System.Globalization;

namespace Sequencia_S_Uri_1055
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, s = 1;

            for (int i = 1; i <= 100; i++)
            {
                soma += (1 / s);
                s++;
            }

            Console.WriteLine("Sequencia S: " + soma.ToString("F2" ,CultureInfo.InvariantCulture) + ".");

        }
    }
}
