// Faça um programa que preencha um vetor de tamanho 100 com os 100
// primeiros naturais que não são múltiplos de 7 ou que terminam com 7.

using System;

namespace Mult07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100, m = 0;
            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 7 != 0)
                {
                    m++;
                    vet[i] = m;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}ª posicao: {vet[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("REPETIÇÔES: " + m);

        }
    }
}