namespace EsferaObj
{
    internal class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
