using ConsoleATM.Services;
using System;
using TarteebBank.Services;

namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoggerService loggerService = new V1LoggerService();

            try
            {
                var menu = new AtmMenuService();
                var password = new SmsService();
                var balance = new BalanceService();

                Console.ForegroundColor = ConsoleColor.Magenta;
                loggerService.LogInformation("Create a unique password to use the program!!!");
                password.GetUserPassword();

                Console.Clear();

                loggerService.LogInformation("Password created!\n");
                loggerService.LogInformation("Welcome to TarteebBank!!!");

                loggerService.LogInformation("Enter your password to use the program!!!");

                string userInputPassword;

                string isContinue;

                if (userInputPassword == password.user)
            }
            catch
            {

            }
        }
    }
}
