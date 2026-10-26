using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o preço original do produto desejado: ");
                decimal precoOG = decimal.Parse(Console.ReadLine());

                CalculateDiscount calcular = CalcularDesconto;

                decimal precoFinal = calcular(precoOG);

                Console.WriteLine($"Preço com desconto: {precoFinal:C}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public delegate decimal CalculateDiscount(decimal precoOG);

        public static decimal CalcularDesconto(decimal precoOG)
        {
            return precoOG * 0.90m;
        }
    }
}