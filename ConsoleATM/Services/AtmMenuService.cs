using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarteebBank.Services;

namespace ConsoleATM.Services
{
    internal class AtmMenuService
    {
        private ILoggerService loggerService;

        public AtmMenuService()
        {
            this.loggerService = new V1LoggerService();
        }

        public void WriteAtmMenu()
        {
            loggerService.LogInformation("\nChoose one section below!!!");
            loggerService.LogInformation("1. Balance check.");
            loggerService.LogInformation("2. Withdraw cash.");
            loggerService.LogInformation("3. Spending");
            loggerService.LogInformation("4. Exit the program");
        }
    }
}
