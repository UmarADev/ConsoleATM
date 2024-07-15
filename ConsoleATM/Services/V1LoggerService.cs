using System;
using TarteebBank.Services;

namespace ConsoleATM.Services
{
    internal class V1LoggerService : ILoggerService
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}
