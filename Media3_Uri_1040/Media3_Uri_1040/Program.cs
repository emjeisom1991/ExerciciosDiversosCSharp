using System;
using System.Globalization;

namespace Media3_Uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe as notas: ");
            string[] notas = Console.ReadLine().Split(" ");
            double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture), peso1 = 2;
            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture), peso2 = 3;
            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture), peso3 = 4;
            double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture), peso4 = 1;

            double media = (n1 * peso1 + n2 * peso2 + n3 * peso3 + n4 * peso4) / (peso1 + peso2 + peso3 + peso4);

            string status;

            if (media < 10)
            {
                status = "Aprovado.";
            }else if(media > 7)
            {
                status = "Aluno em exame.";
                double notaExame = double.Parse(Console.ReadLine());
            }
            else
            {
                status = "Aluno reprovado.";
            }


        }
    }
}
