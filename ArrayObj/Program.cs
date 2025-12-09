using System;
using System.Runtime.CompilerServices;

namespace ArrayObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos deseja adicionar? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetorProd = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o preço do produto:");
                double preco = double.Parse(Console.ReadLine());
                vetorProd[i] = new Produto { Nome = nome, Preco = preco };
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
                soma += vetorProd[i].Preco;
            double media = soma / n;
            Console.WriteLine($"Media dos preços: {media}");
        }
    }
}