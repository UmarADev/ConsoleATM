using ConsoleATM.Services;
using System;

namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtmMenuService atmMenuServices = new AtmMenuService();
            BalanceService balanceServices = new BalanceService();
            SmsService smsServices = new SmsService();
            WithdrawCashService withdrawCashServices = new WithdrawCashService();
            ILoggerServices loggerServices = new V1LoggerService();
            bool isContinue = true;

            while (isContinue)
            {
                atmMenuServices.WriteAtmMenu();
                string userChoise = Console.ReadLine();
                int convertedUserChoise = Convert.ToInt32(userChoise);

                switch(convertedUserChoise)
                {
                    //case 1:
                    //    balanceServices.GetBalance();
                    //    break;

                    case 2:
                        withdrawCashServices.GetWithdrawUserCash();
                        break;

                    case 3:
                        smsServices.GetUserPassword();
                        smsServices.GetUserPhone();
                        break;
                }
            }


        }
    }
}
