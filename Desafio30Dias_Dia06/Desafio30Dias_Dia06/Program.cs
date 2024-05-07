using System;

namespace Desafio30Dias_Dia06
{
    class Program
    {
        public static void Main(string[] args)
        {
            string login = "dia06";
            string senha = "a1b2c3";

            Console.WriteLine("Insira o usuario: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nInsira a senha: ");
            string pass = Console.ReadLine();

            if (name == login &&  pass == senha)
            {
                Console.WriteLine("\nACESSO CONCEDIDO");
            }
            else
            {
                Console.WriteLine("\nACESSO NEGADO");
            }
        }
    }
}