using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal class Usuario
    {
        private string _nome;
        private string _email;
        private string _senha;

        public Usuario() { 
        }
        
        public bool VerificacaoSenha(string senha, string verificacao)
        {
            if (String.IsNullOrEmpty(senha) || senha == verificacao)
                return false;
            else
                return true;
        }

        public void SetUsuario(string nome, string email, string senha)
        {
            _nome = nome;
            _email = email;
            _senha = senha;
        }

        public string Nome // isso aqui é uma propriedade
        {
            get { return _nome; }
        }

        public string Email
        {
            get { return _email; }
        }
    }
}
