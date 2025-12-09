using System;

namespace ConverterDolar
{
    class Program
    {
        static void Main()
        {
            Console.Write("Informe a cotação do dólar:");
            double Dol = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de dólares:");
            double Value = double.Parse(Console.ReadLine());
            double Result = Conversor.Converter(Dol, Value);
            Console.WriteLine("Resultado: R$" + Result.ToString("F2"));
        }
    } 
}