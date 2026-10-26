using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04.Models
{
    public class TemperatureSensor
    {
        public event EventHandler TemperatureExceeded;

        public double TemperaturaAtual { get; private set; }

        public void CheckTemperature(double temperatura)
        {
            TemperaturaAtual = temperatura;

            if (temperatura > 100)
            {
                TemperatureExceeded?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}