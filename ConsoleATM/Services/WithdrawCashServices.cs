using System;

namespace ConsoleATM.Services
{
    internal class WithdrawCashServices
    {
        LoggerServices loggerServices = new V1Logger();

        decimal userCash = 100;

        public void WithdrawUserCash()
        {
            loggerServices.LogInformation("How much cash you want to withdraw?");
            loggerServices.LogInformation("1. 10$\n2. 20$\n3. 50$\n4. 100$\n5. Another amount\n");

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
                    userCash -= userCashValue;
                    break;
            }

            if( userCash < 0)
            {
                loggerServices.LogInformation("You don't have enough money. Try with another amount of money");
            }
        }
    }
}
