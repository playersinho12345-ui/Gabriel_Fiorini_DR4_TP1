using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Func<double, double, double> calcularArea = CalcularArea;

            double area = calcularArea(baseRetangulo, altura);

            Console.WriteLine($"A área do retângulo é: {area}");
        }

        public static double CalcularArea(double baseRetangulo, double altura)
        {
            return baseRetangulo * altura;
        }
    }
}