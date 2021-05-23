using System;

namespace FibonacciFacil_Uri_1151
{
    class Program
    {
        static void Main(string[] args)
        {

            double t1 = 2, t2 = 3, t3;

            Console.Write("Informe quantos termos terá a sequencia: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 46)
            {
                Console.Write("0 1 1 2 3 ");
                for (int i = 2; i <= (n - 4); i++)
                {
                    t3 = t1 + t2;
                    Console.Write(t3 + " ");
                    t1 = t2;
                    t2 = t3;
                }
            }
            else
            {
                Console.WriteLine("Impossivel calcular.");
            }

            Console.WriteLine();

        }
    }
}
