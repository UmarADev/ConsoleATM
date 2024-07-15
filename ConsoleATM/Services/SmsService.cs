using System;
using TarteebBank.Services;

namespace ConsoleATM.Services
{
    internal class SmsService
    {
        private ILoggerService loggerService;

        private string userPassword = "0000";
        private string userPhone = "123456789";

        public SmsService()
        {
            this.loggerService = new V1LoggerService();
        }

        public void GetUserPassword()
        {
            loggerService.LogInformation("Please enter your password: ");
            userPassword = Console.ReadLine();

            loggerService.LogInformation("Your password added succesfully!");
        }

        public void GetUserPhone()
        {
            loggerServices.LogInformation("Please enter your number: +998 ");
            userPhone = Console.ReadLine();

            loggerServices.LogInformation("Your phone added succesfully!");
        }

        public void ChangeUserPassword()
        {
            for (int i = 0; i < 3; i++)
            {
                loggerServices.LogInformation("Enter your password: ");
                string pin = Console.ReadLine();

                if(pin != userPassword)
                {
                    if (i == 2)
                    {
                        loggerServices.LogInformation("Too much effort. Try again later.");
                        break;
                    }
                    loggerServices.LogInformation("Incorrect password. Try again.");
                }
                else
                {
                    while (true)
                    {
                        try
                        {
                            loggerServices.LogInformation("Enter new password: ");
                            string newPassword = Console.ReadLine();

                            if (newPassword.Length != 4)
                            {
                                throw new ArgumentOutOfRangeException("PIN must be a 4-digit number.");
                            }
                            
                            loggerServices.LogInformation("Re-enter a new password: ");
                            string newPassword2 = Console.ReadLine();

                            if (newPassword != newPassword2)
                            {
                                loggerServices.LogInformation("The passwords must be the same. Try again.");
                            }
                            else
                            {
                                userPassword = newPassword;
                                loggerServices.LogInformation("PIN successfully changed.");
                                break;
                            }
                        }
                        catch (ArgumentException argumentException)
                        {
                            loggerServices.LogInformation($"{argumentException.Message}. Try again");
                        }
                        catch (Exception exception)
                        {
                            loggerServices.LogInformation($"{exception.Message}. Try again");
                        }
                    }
                }
            }
        }

        public void ChangePhoneNumber()
        {
            bool isCorrect = false;
            while(!isCorrect)
            {
                try
                {
                    loggerServices.LogInformation("Enter your phone number: ");
                    string phoneNumber = Console.ReadLine();

                    if (string.IsNullOrEmpty(phoneNumber))
                    {
                        throw new ArgumentException("This space must be filled.");
                    }
                    else if (phoneNumber.StartsWith("+"))
                    {
                        throw new Exception("Your phone number must have digits only but not symbol. Try again.");
                    }
                    else if (phoneNumber.Length < 10 || phoneNumber.Length > 10)
                    {
                        throw new Exception("Invalid phone number. There must be 9 digit number.");
                    }

                    userPhone = phoneNumber;
                    loggerServices.LogInformation("Phone number successfully changed");
                    isCorrect = true;
                }
                catch (ArgumentException argumentException)
                {
                    loggerServices.LogInformation   (argumentException.Message);
                }
                catch (Exception exception)
                {
                    loggerServices.LogInformation(exception.Message);
                }
            }
        }
    }
}
