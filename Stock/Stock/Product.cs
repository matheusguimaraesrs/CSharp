using System;
using System.Collections.Generic;
using System.Text;

namespace Stock
{
    internal class Product
    {
        public double quant;
        public string name;
        public double price;

        public double Total()
        {
            return quant * price;
        }
        public void Add(double quantAdd)
        {
            quant += quantAdd;
        }
        public void Rm(double quantRm)
        {
            quant -= quantRm;
        }
        public override string ToString()
        {
            return "$" + price.ToString("F2") + "\n" 
                + quant + " unidades\n" 
                + "Total: $" + Total().ToString("F2");
        }
    }
}
