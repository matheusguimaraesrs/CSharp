using System;

namespace EsferaObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Raio Valor = new Raio();

            Console.WriteLine("Informe o valor do Raio:");
            Valor.ValorRaio = double.Parse(Console.ReadLine());
            double Circ = Valor.Circunferencia();
            double Vol = Volume(Valor.ValorRaio);
            Console.WriteLine($"Circunferência: {Circ.ToString("F2")}");
            Console.WriteLine($"Valume: {Vol.ToString("F2")}");
            Console.WriteLine($"Valor de PI: {Valor.Pi.ToString("F2")}");
        }

        static double Volume (double r)
        {
            return 4 / 3 * 3.14 * Math.Pow(r, 3);
        }
    }
}