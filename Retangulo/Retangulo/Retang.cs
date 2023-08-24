namespace Retangulo
{

    class Retang
    {
        public double LadoA;
        public double LadoB;
        public double Area()
        {
            return LadoA * LadoB;
        }
        public double Perimetro()
        {

            return 2 * (LadoA + LadoB);
        }
        public double Diagonal()
        {
            return Math.Sqrt(LadoA * LadoA + LadoB * LadoB);
        }
    }
}