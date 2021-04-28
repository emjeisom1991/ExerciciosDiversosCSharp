// Faça um programa que leia dois vetores de 10 elementos. Crie um vetor que seja a intersecção entre
// os 2 vetores anteriores, ou seja, que contém apenas os números que estão em ambos os vetores. Não
// deve conter números repetidos.
using System;

namespace IntersecVector
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 5, n = 0, cont = 0;
            int[] vec01 = new int[len];
            int[] vec02 = new int[len];
            int[] intersect = new int[len];

            for (int i = 0; i < len; i++)
            {
                vec01[i] = 0;
                vec02[i] = 0;
            }

            Console.Write("Informe os dados do 1º vetor: ");
            string[] numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < len; i++)
            {
                vec01[i] = int.Parse(numbers[i]);
            }

            Console.Write("Informe os dados do 2º vetor: ");
            numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < len; i++)
            {
                vec02[i] = int.Parse(numbers[i]);
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (vec01[i] == vec02[j])
                    {
                        //n = vec01[i];
                        intersect[cont] = vec01[i];
                        cont++;
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Vetor intersecção: ");
            for (int i = 0; i < cont; i++)
            {
                Console.Write($"{intersect[i]} ");
            }

            Console.WriteLine();

        }
    }
}
