using System;

namespace Stock
{
    class Program
    {
        static void Main(String[] args)
        {

            Product p1 = new Product();
            string add_rm;
            double quantAdd, quantRm;
            char condition;

            Console.WriteLine("Insira os dados do produto\n");
            Console.Write("Nome: ");
            p1.name = Console.ReadLine()!;
            Console.Write("Preço: ");
            p1.price = double.Parse(Console.ReadLine()!);
            Console.Write("Quantidade: ");
            p1.quant = int.Parse(Console.ReadLine()!);

            Console.Clear();
            double total = p1.Total();

            Console.WriteLine($">>>>> {p1.name} <<<<<\n");
            Console.WriteLine($"Quantidade: {p1.quant.ToString("F1")}");
            Console.WriteLine($"Preço: R${p1.price.ToString("F2")}");
            Console.WriteLine($"Total: R${total.ToString("F2")}");

            do
            {
                Console.WriteLine("\nDeseja Adicionar (add) ou Remover (rm)?");
                add_rm = Console.ReadLine()!;
                Console.Clear();
                if (add_rm.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Insira a quantidade:");
                    quantAdd = double.Parse(Console.ReadLine()!);
                    if (quantAdd < 0)
                    {
                        Console.WriteLine("Valor incorreto!");
                        break;
                    }
                    p1.Add(quantAdd);
                    Console.Clear();
                    total = p1.Total();
                    Console.WriteLine($">>>>> {p1.name} <<<<<\n");
                    Console.WriteLine($"Quantidade: {p1.quant.ToString("F1")}");
                    Console.WriteLine($"Preço: R${p1.price.ToString("F2")}");
                    Console.WriteLine($"Total: R${total.ToString("F2")}");
                }
                else
                {
                    Console.WriteLine("Insira a quantidade:");
                    quantRm = double.Parse(Console.ReadLine()!);
                    p1.Rm(quantRm);
                    if (quantRm < 0)
                    {
                        Console.WriteLine("Valor incorreto!");
                        break;
                    }
                    Console.Clear();
                    total = p1.Total();
                    Console.WriteLine($">>>>> {p1.name} <<<<<\n");
                    Console.WriteLine($"Quantidade: {p1.quant.ToString("F1")}");
                    Console.WriteLine($"Preço: R${p1.price.ToString("F2")}");
                    Console.WriteLine($"Total: R${total.ToString("F2")}");
                }
                    Console.WriteLine("Deseja encerrar? (s/n)");
                condition = char.Parse(Console.ReadLine()!);
            }
            while (char.ToLower(condition) == 'n');
        }
    }
}