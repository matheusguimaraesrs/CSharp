using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsferaObj
{
    internal class Raio
    {
        public double ValorRaio;
        public double Pi = 3.14;

        public double Circunferencia()
        {
            return 2 * Pi * ValorRaio; 
        }
        /*public double Volume()
        {
            return ;
        }*/
    }
}
