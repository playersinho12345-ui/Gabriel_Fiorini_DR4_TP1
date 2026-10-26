using Exercicio04.Models;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += Warning;

            while (true)
            {
                Console.Write("Digite a temperatura (-1 para sair): ");

                double temperatura = double.Parse(Console.ReadLine()!);

                if (temperatura == -1)
                    break;

                sensor.CheckTemperature(temperatura);
            }
        }

        static void Warning(object? sender, EventArgs e)
        {
            if (sender is TemperatureSensor sensor)
            {
                Console.WriteLine(
                    $"ALERTA! Temperatura acima do limite: {sensor.TemperaturaAtual} °C"
                );
            }
        }
    }
}