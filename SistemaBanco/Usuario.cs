using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    internal class Usuario
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Usuario(int conta, string titular)
        {
            while (conta < 1000 || conta > 9999)
            {
                Console.WriteLine("A conta deve conter 4 dígitos!");
                Console.WriteLine("Informe o número da conta: ");
                conta = int.Parse(Console.ReadLine());
            }
            Conta = conta;
            Titular = titular;
        }

        public Usuario(int conta, string titular, double saldo) : this(conta, titular)
        {
            Deposito(saldo);
        }

        public override string ToString() 
        {
            return "Conta: " 
                + Conta + ", Titular: " 
                + Titular + ", Saldo: R$" 
                + Saldo.ToString("F2");
        }

        public void Deposito(double deposito)
        {
            if (deposito != null)
                Saldo += deposito; 
        }
        public void Saque(double saque)
        {
            if (Saldo != null)
                Saldo -= (saque + 5.0);
        }
    }
}
