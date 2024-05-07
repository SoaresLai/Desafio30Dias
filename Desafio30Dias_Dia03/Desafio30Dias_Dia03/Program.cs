using System;
using System.Drawing;

namespace Desafio30Dias_Dia03
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Informe o número de vendedores: ");
            int n = int.Parse(Console.ReadLine());

            for (int n1 = 0; n1 < n; n1++)
            {
                Console.WriteLine($"\nVendedor #{n1}: ");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Informe quantas formas de pagamento possui: ");
                int y = int.Parse(Console.ReadLine());

                for (int n2 = 0; n2 < y; n2++)
                {
                    Console.WriteLine($"\nTipo de pagamento #{n2}");
                    Console.Write("Forma de pagamento (D/C/P): ");
                    string formaPagamento = Console.ReadLine();

                    Console.Write("Valor total: ");
                    double valor = double.Parse(Console.ReadLine());

                    Console.Write("Porcentagem de Comissao: ");
                    double porcentagemComissao = double.Parse(Console.ReadLine());

                    double comissao = valor * porcentagemComissao;

                    Console.Write("O valor da comissão é de: " + comissao.ToString("f2"));
                    Console.WriteLine(" ");

                }
            }
        }
    }
}