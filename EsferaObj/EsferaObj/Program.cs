using System;

namespace EsferaObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Informe o valor do Raio:");
            double Raio = double.Parse(Console.ReadLine());
            double Circ = calc.Circunferencia(Raio);
            double Vol = calc.Volume(Raio);
            Console.WriteLine($"Circunferência: {Circ.ToString("F2")}");
            Console.WriteLine($"Valume: {Vol.ToString("F2")}");
            Console.WriteLine($"Valor de PI: {calc.Pi.ToString("F2")}");
        }
    }
}