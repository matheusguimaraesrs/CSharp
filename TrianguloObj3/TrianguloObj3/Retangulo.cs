using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloObj3
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area;
        public double Perimetro;
        public double Diagonal;

        public void CalculaArea()
        {
           Area = Largura * Altura;
        }
        public void CalculaPerimetro()
        {
            Perimetro = 2 * (Altura + Largura);
        }
        public void CalculaDiagonal()
        {
            Diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
