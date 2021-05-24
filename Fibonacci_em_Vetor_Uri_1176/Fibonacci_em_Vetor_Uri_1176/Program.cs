using System;

namespace Fibonacci_em_Vetor_Uri_1176
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de termos da série: ");
            int n = int.Parse(Console.ReadLine());

            int qtdTermos = 20;
            int[] vFibo = new int[qtdTermos];

            vFibo[0] = 0;
            vFibo[1] = 1;

            for (int i = 0; i < qtdTermos; i++)
            {
                if (i >= 2)
                {
                    vFibo[i] = vFibo[i - 1] + vFibo[i - 2];
                }
            }

            //for (int i = 0; i < qtdTermos; i++)
            //{
            //    Console.Write(vFibo[i] + " ");
            //}

            Console.WriteLine("Fib("+n+") = " + vFibo[n]);


        }
    }
}
