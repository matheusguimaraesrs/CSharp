using System;

namespace ExeObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("#############################\n");
            Console.WriteLine("Insira os dados da pessoa 1");
            Console.Write("Nome: ");
            pessoa1.name = Console.ReadLine();
            Console.Write("\nIdade: ");
            pessoa1.age = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("#############################\n");
            Console.WriteLine("Insira os dados da pessoa 2");
            Console.Write("Nome: ");
            pessoa2.name = Console.ReadLine();
            Console.Write("\nIdade: ");
            pessoa2.age = int.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("#############################\n");
            if (pessoa1.age > pessoa2.age)
                Console.WriteLine($"Pessoa mais velha: {pessoa1.name}");
            else
                Console.WriteLine($"Pessoa mais velha: {pessoa2.name}");
            Console.WriteLine("\n#############################");
        }
    }
}