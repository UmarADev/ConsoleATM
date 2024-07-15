using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarteebBank.Services;

namespace ConsoleATM.Services
{
    internal class V2LoggerService : ILoggerService
    {
        public void LogInformation(string message)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{message}");
        }
}
