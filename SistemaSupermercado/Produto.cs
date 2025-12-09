using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quant {  get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            Console.Clear();
            Console.WriteLine("#############################");
            Console.WriteLine("#    Sistema de Cadastro    #");
            Console.WriteLine("#############################\n\n");
            return "Nome: " + Name
                + "\nPreço: " + Price
                + "\nQuantidade: " + Quant
                + "\nId: " + Id;
        }
        public void AddProd()
        {
            Console.Clear();
            Console.WriteLine("#############################");
            Console.WriteLine("#    Sistema de Cadastro    #");
            Console.WriteLine("#############################\n\n");
            Console.WriteLine("Quantidade: ");
            int Add = int.Parse(Console.ReadLine());
            Quant += Add;
        }
    }
}
