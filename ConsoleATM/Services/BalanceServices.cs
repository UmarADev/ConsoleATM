using System;

namespace ConsoleATM.Services
{
    internal class BalanceServices
    {
        LoggerServices loggerServices = new V1Logger();

        public BalanceServices()
        {
            loggerServices.LogInformation("Your current balance is: 100");
        }

        public void GetBalance(decimal balance)
        {
            loggerServices.LogInformation($"Your current balance is: {balance}");
        }
    }
}
