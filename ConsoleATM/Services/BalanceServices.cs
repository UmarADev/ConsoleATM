using System;

namespace ConsoleATM.Services
{
    internal class BalanceServices
    {
        LoggerServices loggerServices = new V1Logger();

        public void ShowBalance(decimal balance)
        {
            loggerServices.LogInformation(balance);
        }
    }
}
