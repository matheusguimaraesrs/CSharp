using System;

namespace TrianguloObj3
{
    class Program
    {
        static void Main()
        {
            Retangulo retangulo = new Retangulo();
            
            Console.WriteLine("Insira o valor de largura:");
            retangulo.Largura = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Insira o valor de altura:");
            retangulo.Altura = int.Parse(Console.ReadLine()!);

            retangulo.CalculaArea();
            Console.WriteLine($"AREA = {retangulo.Area}");
            retangulo.CalculaPerimetro();
            Console.WriteLine($"PERIMETRO: {retangulo.Perimetro}");
            retangulo.CalculaDiagonal();
            Console.WriteLine($"PERIMETRO: {retangulo.Diagonal.ToString("F2")}");
        }
    }
}