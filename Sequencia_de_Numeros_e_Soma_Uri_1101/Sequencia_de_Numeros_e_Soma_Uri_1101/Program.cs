using System;

namespace Sequencia_de_Numeros_e_Soma_Uri_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, sum = 0, maior = 0, menor;
            string[] MN;

            do
            {

                MN = Console.ReadLine().Split(" ");
                M = int.Parse(MN[0]);
                N = int.Parse(MN[1]);

                if(M > N)
                {
                    maior = M;
                    menor = N;
                }
                else
                {
                    maior = N;
                    menor = M;
                }

                if (M > 0 && N > 0)
                {

                    for (int i = menor; i <= maior; i++)
                    {
                        Console.Write(i + " ");
                        sum += i;
                    }

                    Console.WriteLine("Sum=" + sum);
                }

                sum = 0;

            } while (M > 0 && N > 0);




        }
    }
}
