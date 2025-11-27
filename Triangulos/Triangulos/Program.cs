using System;
using System.Globalization;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double aX, bX, cX, aY, bY, cY;

            Console.WriteLine("Insira os valores do triangulo X:");
            aX = double.Parse(Console.ReadLine());
            bX = double.Parse(Console.ReadLine());
            cX = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira os valores do triangulo Y:");
            aY = double.Parse(Console.ReadLine());
            bY = double.Parse(Console.ReadLine());
            cY = double.Parse(Console.ReadLine());

            double p = (aX + bX + cX) / 2.0;
            double areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));
            p = (aY + bY + cY) / 2.0;
            double areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
                Console.WriteLine("Maior area: X");
            else
                Console.WriteLine("Maior area: Y");
        }
    }
}