using System;

namespace SalarioObj
{
    class Program
    {
        static void Main()
        {
            Funcionario f1 = new Funcionario();

            Console.WriteLine(">>>>CALCULADORA DE SALÁRIO<<<<<");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine()!;
            Console.Write("Salário bruto: ");
            f1.Salario = double.Parse(Console.ReadLine()!);
            Console.Write("Salário bruto: ");
            f1.Imposto = double.Parse(Console.ReadLine()!);

            f1.SalarioLiq();
            Console.WriteLine($"Funcionário: {f1.Nome}, ${f1.NovoSalario}");

            Console.WriteLine("Digite o percentual de aumento:");
            f1.Porcento = double.Parse(Console.ReadLine()!);
            f1.Adicional();
            Console.WriteLine($"Dados atualizado: {f1.Nome}, ${f1.NovoSalario}");
        }
    }
}