using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            Hospede[] hospedes = new Hospede[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}º hospede");
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Email: ");
                string email = Console.ReadLine();
                Console.Write($"Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                hospedes[i] = new Hospede(nome, email, quarto);
                Console.Clear();
            }
            Console.WriteLine("Quartos Ocupados");
            for (int i = 0; i < n; i++)
                hospedes[i].QuartosOcupados();
        }
    }
}