namespace Course
{
    public class Triangulo
    {
        double ladoA;
        double ladoB;
        double ladoC;

        public double CalculaArea()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }


    }

}