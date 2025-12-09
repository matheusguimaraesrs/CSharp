using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SistemaLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("Insira seu nome de usuário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira seu email:");
            string email = Console.ReadLine();
            Console.WriteLine("Insira sua senha:");
            string senha = Console.ReadLine();
            Console.WriteLine("Confirme sua senha:");
            string senhaVerificacao = Console.ReadLine();
            if (usuario.VerificacaoSenha(senha, senhaVerificacao))
                Console.WriteLine("Senha Inválida");

            while (usuario.VerificacaoSenha(senha, senhaVerificacao))
            {
                Console.WriteLine("Insira sua senha:");
                senha = Console.ReadLine();
                Console.WriteLine("Confirme sua senha:");
                senhaVerificacao = Console.ReadLine();
                if (usuario.VerificacaoSenha(senha, senhaVerificacao))
                    Console.WriteLine("Senha Inválida");
            }

            usuario.SetUsuario(nome, email, senha);
            Console.Clear();
            Console.WriteLine("Conta Criada:");
            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.Email);
        }
    }
}
