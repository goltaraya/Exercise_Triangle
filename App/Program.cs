using Course;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(4, 6, 9);
            Triangulo triangulo2 = new Triangulo(4, 7, 9);

            double area1 = triangulo1.CalculaArea();
            double area2 = triangulo2.CalculaArea();

            System.Console.WriteLine($"Área do triângulo 1: {area1.ToString("F4")}.");
            System.Console.WriteLine($"Área do triângulo 2: {area2.ToString("F4")}.");
        }
    }
}