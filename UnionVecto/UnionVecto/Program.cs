// Criar um vetor que seja a uniao entre os 2 vetores anteriores, ou seja, que contem os números dos dois vetores.
// Não deve conter numeros repetidos.
using System;

namespace UnionVector
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, u = 0;
            int pInd = 2 * n;
            int[] vec01 = new int[n];
            int[] vec02 = new int[n];
            int[] union = new int[pInd];


            for (int i = 0; i < pInd; i++)
            {
                if (i < n)
                {
                    vec01[i] = 0;
                    vec02[i] = 0;
                }
                union[i] = 0;
            }

            Console.Write("Vector 01: ");
            string[] numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vec01[i] = int.Parse(numbers[i]);
            }

            Console.Write("Vector 02: ");
            numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vec02[i] = int.Parse(numbers[i]);
            }

            for (int i = 0; i < n; i++)
            {
                union[i] = vec01[i];
            }

            for (int i = 0; i < n; i++)
            {
                int finded = 0;
                for (int j = 0; j < n; j++)
                {
                    if (vec02[i] == union[j])
                    {
                        finded = 1;
                        break;
                    }
                }
                if (finded == 0)
                {
                    union[n + u] = vec02[i];
                    u++;
                }
            }

            Console.WriteLine();
            Console.Write("Vector union: ");
            for (int i = 0; i < (n + u); i++)
            {
                Console.Write(union[i] + " ");
            }

        }
    }
}
