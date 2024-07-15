using System;
using TarteebBank.Services;

namespace ConsoleATM.Services
{
    internal class BalanceService
    {
        private ILoggerService loggerService;

        public BalanceService()
        {
            this.loggerService = new V1LoggerService();
        }

        internal void ShowBalance(decimal balance)
        {
            Console.Clear();
            loggerService.LogInformation($"Your current balance is: ${balance}");
        }

        internal decimal GetWithdrawCash(decimal withdrawBalance)
        {
            loggerService.LogInformation("How much cash you want to withdraw?");
            loggerService.LogInformation("1. 10$\n2. 20$\n3. 50$\n4. 100$\n5. Another amount\n");
            loggerService.LogInformation("Enter the value: ");

            string userInput = Console.ReadLine();
            decimal userChoise = Convert.ToInt32(userInput);

            try
            {
                switch (userChoise)
                {
                    case 1:
                        withdrawBalance -= 10;
                        PrintMessage();
                        break;

                    case 2:
                        withdrawBalance -= 20;
                        PrintMessage();
                        break;

                    case 3:
                        withdrawBalance -= 50;
                        PrintMessage();
                        break;

                    case 4:
                        withdrawBalance -= 100;
                        PrintMessage();
                        break;

                    case 5:
                        loggerService.LogInformation("How much do you want to withdraw?");
                        string withdrawCashInput = Console.ReadLine();
                        decimal withdrawCash = Convert.ToDecimal(withdrawCashInput);

                        withdrawBalance -= withdrawCash;
                        PrintMessage();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                loggerService.LogInformation(exception.Message);
            }

            return withdrawBalance;
        }

        public void PrintMessage()
        {
            loggerService.LogInformation("Cash withdrawal was successfully");
        }
    }
}
