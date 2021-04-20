// Program that calculates a Standard Deviation of a vector with n numbers

using System;
using System.Globalization;

namespace StandardDeviationVet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers is there in the vector ? ");
            int qtd = int.Parse(Console.ReadLine());
            double[] StaDev = new double[qtd];
            double n = 0, m = 0, sum = 0, sd = 0;

            Console.Clear();

            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"Set number {i+1}: ");
                StaDev[i] = double.Parse(Console.ReadLine());
                sum += StaDev[i];
            }

            m = sum/qtd;          

            for (int i = 0; i < qtd; i++)
            {
                sd += Math.Pow((StaDev[i] - m), 2);
            }

            Console.Clear();
            Console.Write("Standard Deviation = ");
            Console.WriteLine(Math.Sqrt( sd/(qtd-1)).ToString("F6", CultureInfo.InvariantCulture));
        }
    }
}
