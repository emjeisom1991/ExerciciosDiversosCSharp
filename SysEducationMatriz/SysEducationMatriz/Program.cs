using System;
using System.Globalization;

namespace SysEducationMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] StuInfo = new double[5, 4];
            double GFGrade = 0, GRegistration = 0, AFGrade=0, contStu=0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    StuInfo[i, j] = 0;
                }

            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i+1}º Aluno: ");
                string[] StuData = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    StuInfo[i, j] = double.Parse(StuData[j]);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    StuInfo[i, 3] = (StuInfo[i, 1] + StuInfo[i, 2]) / 2;

                    if (StuInfo[i, 3] >= GFGrade)
                    {
                        GFGrade = StuInfo[i, 3];
                        GRegistration = StuInfo[i, 0];
                    }
                        

                    
                }
                AFGrade += StuInfo[i, 3];
                contStu++;
            }

            Console.WriteLine($"The greatest final grade belongs to registration: {GRegistration}");
            Console.WriteLine($"Arithmetic average of final grades: {(AFGrade/contStu).ToString("F2", CultureInfo.InvariantCulture)}");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{StuInfo[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
