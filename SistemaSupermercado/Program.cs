using SistemaSupermercado;
using System;

namespace SistemaSupermecado
{
    class Program
    {
        readonly string? name;
        private double? price;
        private int? quant, id;
        private int? option;
        public static void Main(string[] args)
        {

            Console.WriteLine("#############################");
            Console.WriteLine("#    Sistema de Cadastro    #");
            Console.WriteLine("#############################\n\n");

            var produto = NewProduct();

            Console.WriteLine(produto);
            Console.ReadKey();
            produto.AddProd();
            Console.Clear();
            Console.WriteLine(produto);
        }

        private static Produto NewProduct()
        {
            Produto prod = new Produto(); 
            Console.WriteLine(">>>Criar um novo produto<<<");
            Console.Write("Nome: ");
            prod.Name = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            prod.Quant = int.Parse(Console.ReadLine());
            Console.Write("Id: ");
            prod.Id = int.Parse(Console.ReadLine());
            Console.Clear();

            return prod;
        }       
    }
}