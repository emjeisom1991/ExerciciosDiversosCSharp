// Leia 10 numeros inteiros e armazene em um vetor. Em seguida escreva os elementos que sao
// primos e suas respectivas posições no vetor.
using System;

namespace NumPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 10;
            int cont = 0, n = 0;
            Boolean primo = false;
            int[] vet = new int[pos];
            int[] vetprimo = new int[pos];

            Console.Write("Entre com os " + pos + " numeros: ");
            string[] num = Console.ReadLine().Split(' ');
            for (int i = 0; i < pos; i++)
            {
                vet[i] = int.Parse(num[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < pos; i++)
            {
                // verificando se o número é primo
                n = vet[i];

                if (n == 1)
                {
                    Console.WriteLine($"O numero {n} é primo e esta na posicao {i}.");
                    vetprimo[cont] = n;
                    cont++;
                }
                else
                {
                    primo = true;
                    for (int j = 2; j < n; j++)
                    {
                        if (n % j == 0)
                        {
                            primo = false;
                        }
                    }
                    if (primo)
                    {
                        Console.WriteLine($"O numero {n} é primo e esta na posicao {i}.");
                        vetprimo[cont] = n;
                        cont++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total de numeros primos encontrados: " + cont + ".");

            Console.WriteLine();
            Console.Write("Vetor dos numeros primos: ");
            for (int i = 0; i < cont; i++)
            {
                Console.Write(vetprimo[i] + " ");
            }
        }
    }
}
