using System;

namespace ConsoleATM.Services
{
    internal class WithdrawCashService
    {
        ILoggerService loggerServices = new V1LoggerService();
        BalanceService balanceServices = new BalanceService();

        decimal userCash = 100;

        public void GetWithdrawUserCash()
        {

            string userChoise = Console.ReadLine();
            decimal userCashValue = Convert.ToDecimal(userChoise);

            switch(userCashValue)
            {
                case 100:
                    userCash -= 100;
                    break;

                case 50:
                    userCash -= 50;
                    break;

                case 20:
                    userCash -= 20;
                    break;

                case 10:
                    userCash -= 10;
                    break;
                default:
                    try
                    {
                        userCash -= userCashValue;
                    }
                    catch(Exception exception)
                    {
                        loggerServices.LogInformation(exception.Message);
                    }
                    break;
            }

            loggerServices.LogInformation("Please get your cash");
        }
    }
}
