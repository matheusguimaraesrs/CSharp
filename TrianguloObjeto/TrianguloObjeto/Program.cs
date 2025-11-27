using System;
using System.Threading.Channels;
using TrianguloObjeto;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Insira os valores do triangulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira os valores do triangulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
                Console.WriteLine("Maior area: X"); 
            else
                Console.WriteLine("Maior area: Y");
        }
    }
}