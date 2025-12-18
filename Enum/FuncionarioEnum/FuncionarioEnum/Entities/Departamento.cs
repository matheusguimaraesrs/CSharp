using System;

namespace FuncionarioEnum.Entities
{
    class Departamento
    {
        public string Nome { get; set; }

        public Departamento() { }
        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
