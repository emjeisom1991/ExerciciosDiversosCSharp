using System;

namespace Grenais_Uri_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, contVitInter=0, contVitGremio = 0, contEmpates = 0, contJogos=0;
            int golsInter, golsGremio;
            
            do
            {
                string[] gols = Console.ReadLine().Split(" ");
                golsInter = int.Parse(gols[0]);
                golsGremio = int.Parse(gols[1]);

                if(golsInter > golsGremio)
                {
                    contVitInter++;
                }else if(golsInter < golsGremio)
                {
                    contVitGremio++;
                }
                else
                {
                    contEmpates++;
                }

                contJogos++;

                Console.Write("Novo grenal? (1-sim 2-nao) ");
                op = int.Parse(Console.ReadLine());

            } while (op != 2);

            Console.WriteLine();

            Console.WriteLine(contJogos + " grenais.");
            Console.WriteLine("Inter: " + contVitInter + ".");
            Console.WriteLine("Gremio: " + contVitGremio + ".");
            Console.WriteLine("Empates: " + contEmpates + ".");

            if (contVitInter > contVitGremio && contVitInter > contEmpates)
            {
                Console.WriteLine("Inter venceu mais.");
            }
            if (contVitGremio > contVitInter && contVitGremio > contEmpates)
            {
                Console.WriteLine("Gremio venceu mais.");
            }




        }
    }
}
