using System;

namespace EsferaObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do Raio:");
            double Raio = double.Parse(Console.ReadLine());

            double Circ = Calculadora.Circunferencia(Raio);
            double Vol = Calculadora.Volume(Raio);

            Console.WriteLine($"Circunferência: {Circ.ToString("F2")}");
            Console.WriteLine($"Valume: {Vol.ToString("F2")}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2")}");
            Console.ReadKey();
        }
    }
}