using System;

namespace SistemaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario;

            Console.Write("Informe o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Informe o titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? (s/n)");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao == 'S')
            {
                Console.WriteLine("Informe o valor:");
                double saldo = int.Parse(Console.ReadLine());
                usuario = new Usuario(conta, titular, saldo);
            }
            else
                usuario = new Usuario(conta, titular);

            Console.WriteLine("Dados da conta:\n" + usuario);
            
            Console.WriteLine("\nInsira o novo depósito:");
            double deposito = double.Parse(Console.ReadLine());
            usuario.Deposito(deposito);
            Console.WriteLine("Dados atualizados:\n" + usuario);

            Console.WriteLine("Insira o valor do saque:");
            double saque = double.Parse(Console.ReadLine());
            usuario.Saque(saque);
            Console.WriteLine("Dados atualizados:\n" + usuario);
        }
    }
}