using System;

namespace Desafio30Dias_Dia04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe os graus °C que deseja converter em °F: ");
            int n = int.Parse(Console.ReadLine());

            int grau = (9 * n) / 5;

            Console.WriteLine(n + " °C em °F é: " + grau);
        }
    }
}