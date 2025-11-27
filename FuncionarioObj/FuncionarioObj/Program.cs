using System;

namespace FuncionarioObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun1 = new Funcionario();
            Funcionario fun2 = new Funcionario();

            Console.WriteLine($"Digite as informações do Funcionário 1");
            Console.Write("Nome: ");
            fun1.Name = Console.ReadLine();
            Console.Write("Salario: ");
            fun1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite as informações do Funcionário 2");
            Console.Write("Nome: ");
            fun2.Name = Console.ReadLine();
            Console.Write("Salario: ");
            fun2.Salary = double.Parse(Console.ReadLine());

            double media = (fun1.Salary +  fun2.Salary) / 2;
            Console.WriteLine($"Salario medio: = {media.ToString("F2")}");
            if (fun1.Salary > fun2.Salary)
                Console.WriteLine($"Funcionario com maior salario: {fun1.Name}");
            else
                Console.WriteLine($"Funcionario com maior salario: {fun2.Name}");
        }
    }
}