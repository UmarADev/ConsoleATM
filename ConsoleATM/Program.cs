using ConsoleATM.Services;
using System;

namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtmMenuServices atmMenuServices = new AtmMenuServices();
            BalanceServices balanceServices = new BalanceServices();
            SmsServices smsServices = new SmsServices();
            WithdrawCashServices withdrawCashServices = new WithdrawCashServices();
            LoggerServices loggerServices = new V1Logger();
            bool isContinue = true;

            while (isContinue)
            {
                atmMenuServices.WriteAtmMenu();
                string userChoise = Console.ReadLine();
                int convertedUserChoise = Convert.ToInt32(userChoise);

                switch(convertedUserChoise)
                {
                    case 1:
                        balanceServices.GetBalance();
                        break;

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
