using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleATM.Services
{
    internal class AtmMenuServices
    {
        LoggerServices loggerServices = new V1Logger();

        public void WriteAtmMenu()
        {
            loggerServices.LogInformation("Hi. Welcom to the ConsoleATM app.");
            loggerServices.LogInformation("Choose one section below:\n");
            loggerServices.LogInformation("1. Balance\n2. Withdraw Cash\n3. Sms service");
        }
    }
}
