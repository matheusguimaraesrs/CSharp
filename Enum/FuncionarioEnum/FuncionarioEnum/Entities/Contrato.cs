using System;

namespace FuncionarioEnum.Entities
{
    internal class Contrato
    {
        public DateTime DataContrato { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public Contrato() { }

        public Contrato(DateTime dataContrato, double valorPorHora, int horas)
        {
            DataContrato = dataContrato;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return Horas * ValorPorHora;
        }
    }
}
