using System;

namespace Tempo_de_Jogo_com_Minutos_Uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horario = Console.ReadLine().Split(" ");
            int hInicio = int.Parse(horario[0]);
            int mInicio = int.Parse(horario[1]);
            int hFim = int.Parse(horario[2]);
            int mFim = int.Parse(horario[3]);

            int instanteInicial = hInicio * 60 + mInicio;
            int instanteFinal = hFim * 60 + mFim;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}
