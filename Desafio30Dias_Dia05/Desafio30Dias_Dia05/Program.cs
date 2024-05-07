using System;

namespace Desafio30Dias_Dia05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um valor numérico inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 9)
            {
                Console.WriteLine("Dentro do valor permitido!");
            }
            else
            {
                Console.WriteLine("Fora do valor permitido!");
            }
        }
    }
}