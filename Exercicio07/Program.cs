using Exercicio07.Models;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log = new Logger();

            log.LogMessage?.Invoke("Conectado.");

            Console.WriteLine("Programa continua executando!");
        }
    }
}
