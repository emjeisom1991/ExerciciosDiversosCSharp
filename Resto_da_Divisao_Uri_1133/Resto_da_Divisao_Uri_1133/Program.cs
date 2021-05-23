using System;

namespace Resto_da_Divisao_Uri_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe os valores de x e y: ");
            string[] xy = Console.ReadLine().Split(" ");
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            for (int i = x; i < y; i++)
            {
                if(i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i % 5);
                }
            }



        }
    }
}
