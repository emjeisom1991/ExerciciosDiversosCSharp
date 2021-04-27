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

            Console.Write("Entre com os " + pos + " numeros: ");
            string[] num = Console.ReadLine().Split(' ');
            for (int i = 0; i < pos; i++)
            {
                vet[i] = int.Parse(num[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < pos; i++)
            {
                
            }

        }
    }
}
