using System;

namespace Desafio30Dias_Dia02
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Para calcular a média do aluno insira as informações abaixo:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Média 1º bimestre: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Média 2º bimestre: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Média 3º bimestre: ");
            double third = double.Parse(Console.ReadLine());

            Console.Write("Média 4º bimestre: ");
            double fourth = double.Parse(Console.ReadLine());

            double media = (first + second + third + fourth) / 4;

            Console.WriteLine($"A média do(a) aluno(a) " + name + " é de " + media.ToString("f2"));

            if (media >= 6.0)
            {
                Console.WriteLine("Aluno(a) aprovado(a).");
            }
            else
            {
                Console.WriteLine("O(a) aluno(a) foi rerovado(a)");
            }
        }
    }
}