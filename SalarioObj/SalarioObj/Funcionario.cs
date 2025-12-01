using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioObj
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double NovoSalario;
        public double Imposto;
        public double Porcento;

        public double SalarioLiq()
        {
            NovoSalario = Salario - Imposto;
            return NovoSalario;
        }

        public void Adicional()
        {
            NovoSalario = NovoSalario  + (Salario * Porcento / 100);
        }
    }
}
