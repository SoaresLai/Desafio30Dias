using System;

namespace Desafio30Dias_Dia07
{
    class Program
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            
            for (int i = 0; i <= 500; i++) 
            {
                soma += i;
                Console.WriteLine(i);
            }
        }
    }
}