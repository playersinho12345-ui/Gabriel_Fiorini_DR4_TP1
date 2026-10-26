using Exercicio06.Models;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log = new Logger();

            log.LogMessage += log.LogToConsole;
            log.LogMessage += log.LogToFile;
            log.LogMessage += log.LogToDatabase;

            log.LogMessage("Conectado.");
        }
    }
}
