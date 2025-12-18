using System;
using FuncionarioEnum.Entities;
using FuncionarioEnum.Entities.Enum;

namespace FuncionarioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string depNome = Console.ReadLine();
            Console.WriteLine("Dados do Funcionario\n********************\n");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Cargo (Junior/Pleno/Senior): ");
            cargoFuncionario cargo = Enum.Parse<cargoFuncionario>(Console.ReadLine());
            Console.Write("Base Salarial: ");
            double BaseSalarial = double.Parse(Console.ReadLine());

            Departamento Departamento = new Departamento(depNome);
            Funcionario Funcionario = new Funcionario(nome, cargo, BaseSalarial, Departamento);

            Console.Write("Quantidade de contratos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine($"Insira #{i+1}º contrato:");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double ValorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(data, ValorPorHora, horas);
                Funcionario.AddContrato(contrato);
            }

            Console.WriteLine("Digite o mês e o ano de cunsulta:");
            string MesAno = Console.ReadLine();
            int Mes = int.Parse(MesAno.Substring(0, 2));
            int Ano = int.Parse(MesAno.Substring(3));
            Console.WriteLine($"Nome: {Funcionario.Nome}");
            Console.WriteLine($"Departamento: {Funcionario.Departamento.Nome}");
            Console.WriteLine($"Renda de {MesAno}: {Funcionario.Renda(Ano, Mes).ToString("F2")}");
        }
    }
}