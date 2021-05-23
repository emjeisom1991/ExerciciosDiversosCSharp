using System;

namespace Sequencia_IJ_2_Uri_1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I=" + i + " J=" + (j + sum));
                }
                sum+=2;
                Console.WriteLine();
            }
        }
    }
}
