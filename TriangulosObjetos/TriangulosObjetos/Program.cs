using System;

namespace TriangulosObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Informe os 3 valores do triangulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe os 3 valores do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Valor de Area de Triangulo X = {areaX.ToString("F2")}");
            Console.WriteLine($"Valor de Area de Triangulo y = {areaY.ToString("F2")}");

            if (areaX > areaY)
                Console.WriteLine("Area maior = X");
            else
                Console.WriteLine("Area maior = Y");
        }
    }
}