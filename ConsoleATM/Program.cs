using ConsoleATM.Services;
using System;
using TarteebBank.Services;

namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoggerService loggerService = new V2LoggerService();

            try
            {
                var menu = new AtmMenuService();
                var password = new SmsService();
                var balance = new BalanceService();

                loggerService.LogInformation("Create a unique password to use the program!!!");
                password.GetUserPassword();

                Console.Clear();

                loggerService.LogInformation("Password created!\n");
                loggerService.LogInformation("Welcome to TarteebBank!!!");

                loggerService.LogInformation("Enter your password to use the program!!!");

                string userInputPassword = Console.ReadLine();

                string isContinue;

                bool correctPassword = password.CheckUserByPassword(userInputPassword);

                do
                {
                    if (correctPassword == true)
                    {
                        decimal startBalance = 100;

                        menu.WriteAtmMenu();

                        loggerService.LogInformation("Enter your choice: ");

                        string userInputValue = Console.ReadLine();
                        int userInput = Convert.ToInt32(userInputValue);

                        switch (userInput)
                        {
                            case 1:

                                balance.ShowBalance(startBalance);
                                break;

                            case 2:
                                balance.GetWithdrawCash(startBalance);
                                break;

                            case 3:
                                password.GetUserPhone();
                                password.GetUserPassword();
                                break;

                            case 4:
                                loggerService.LogInformation("Exit the program....");
                                loggerService.LogInformation("Thank you for using our program");
                                return;

                            default:
                                loggerService.LogInformation("Wrong choice. Try again.");
                                break;
                        }
                    }

                    loggerService.LogInformation("\nDo you want to continue? (yes / no)");
                    isContinue = Console.ReadLine();
                } while (isContinue.ToLower() == "yes" || isContinue.ToLower() == "y");
            }
            catch (Exception exception)
            {
                loggerService.LogInformation($"{exception.Message}\nRestart the program");
            }
        }
    }
}
