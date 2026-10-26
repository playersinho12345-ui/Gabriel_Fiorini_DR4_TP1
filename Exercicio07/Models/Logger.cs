using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio07.Models
{
    public class Logger
    {
        public Action<string>? LogMessage;
        public void LogToConsole(string msg)
        {
            Console.WriteLine("Console: " + msg);
        }

        public void LogToFile(string msg)
        {
            Console.WriteLine("File: " + msg);
        }

        public void LogToDatabase(string msg)
        {
            Console.WriteLine("Database: " + msg);
        }
    }
}
