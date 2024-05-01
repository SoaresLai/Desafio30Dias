using System;

namespace Desafio30Dias_Dia01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int sum = n1 + n2;

            Console.WriteLine(" ");
            Console.WriteLine("A soma dos valores é de: " + sum);
        }
    }
}