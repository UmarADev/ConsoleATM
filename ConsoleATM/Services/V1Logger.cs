using System;

namespace ConsoleATM.Services
{
    internal class V1Logger : LoggerServices
    {
        internal override void LogInformation(string message)
        {
            Console.WriteLine(message);
        }

        internal override void LogInformation(decimal message)
        {
            Console.WriteLine(message);
        }
    }
}
