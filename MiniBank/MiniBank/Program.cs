// Escreva	um programa que apresente quatro opções: (a) consulta saldo, (b) saque e (c) depósito e (d) sair.
// O saldo deve iniciar em R$ 0,00. A cada saque ou depósito o valor do saldo deve ser atualizado.
using System;
using System.Globalization;

namespace MiniBank
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = ' ';
            double saldo = 0, saque = 0, depo = 0;

            do
            {
                Console.WriteLine("Informe a operação que deseja:");
                Console.WriteLine("(a) Consultar Saldo");
                Console.WriteLine("(b) Saque");
                Console.WriteLine("(c) Depósito");
                Console.WriteLine("(d) Sair");
                Console.Write("Operação: ");

                op = char.Parse(Console.ReadLine());

                Console.Clear();

                while (op != 'a' && op != 'b' && op != 'c' && op != 'd')
                {
                    Console.WriteLine("Opção inválida. Digite novamente!");
                    Console.WriteLine("Informe a operação que deseja:");
                    Console.WriteLine("(a) Consultar Saldo");
                    Console.WriteLine("(b) Saque");
                    Console.WriteLine("(c) Depósito");
                    Console.WriteLine("(d) Sair");
                    Console.Write("Operação: ");
                    op = char.Parse(Console.ReadLine());
                    Console.Clear();
                }

                switch (op)
                {
                    case 'a':
                        Console.WriteLine("Saldo: R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 'b':
                        Console.Write("Informe o valor do saque: R$ ");
                        saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        saldo -= saque;
                        Console.WriteLine("Saldo: R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 'c':
                        Console.Write("Informe o valor do depósito: R$ ");
                        depo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        saldo += depo;
                        Console.WriteLine("Saldo: R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture));
                        break;
                }

            } while (op != 'd');

        }
    }
}
