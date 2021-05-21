using System;
using System.Globalization;

namespace Formula_de_Bhaskara_Uri_1036
{
    class Program
    {
        static void Main(string[] args)
        {

            //double ex = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double ex2 = ex * 1.22;
            //Console.WriteLine(ex2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\tSolucao de equacoes quadradas!");

            Console.Write("Informe os coeficiente a, b, c da equacao: ");
            string[] coef = Console.ReadLine().Split(" ");
            double a = double.Parse(coef[0], CultureInfo.InvariantCulture);
            double b = double.Parse(coef[1], CultureInfo.InvariantCulture);
            double c = double.Parse(coef[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                //Console.WriteLine("Delta = " + delta.ToString("F5", CultureInfo.InvariantCulture));
                //Console.WriteLine("Raiz de Delta = " + Math.Sqrt(delta).ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine(
                    "As raizes da equação são: " +
                    r1.ToString("F5", CultureInfo.InvariantCulture) + ", " +
                    r2.ToString("F5", CultureInfo.InvariantCulture) +
                ".");
            }

        }
    }
}
