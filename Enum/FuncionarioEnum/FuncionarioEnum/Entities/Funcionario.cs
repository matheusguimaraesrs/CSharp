using System;
using System.Collections.Generic;
using FuncionarioEnum.Entities.Enum;


namespace FuncionarioEnum.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public cargoFuncionario Cargo { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contrato> Contratos { get; set; } = new List<Contrato>();

        public Funcionario() { }

        public Funcionario(string nome, cargoFuncionario cargo, double salario, Departamento departamento)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salario;
            Departamento = departamento;
        }

        public void AddContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoveContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach(Contrato contrato in Contratos)
            {
                if (contrato.DataContrato.Year == ano && contrato.DataContrato.Month == mes)
                    soma += contrato.ValorTotal();
            }
            return soma;
        }
    }
}
