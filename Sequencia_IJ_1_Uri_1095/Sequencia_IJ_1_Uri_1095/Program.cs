using System;

namespace Sequencia_IJ_1_Uri_1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 60;

            while(j >= 0)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                i += 3;
                j -= 5;
            }

        }
    }
}
