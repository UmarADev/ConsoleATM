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
            bool isCorrect = false;
            while(!isCorrect)
            {
                loggerService.LogInformation("Please enter your password: ");
                userPassword = Console.ReadLine();

                if (userPassword == null || userPassword.Length != 4)
                {
                    loggerService.LogInformation("Password must be 4 digit number!");
                }
                else
                {
                    loggerService.LogInformation("Your password added succesfully!");
                    isCorrect = true;
                }
            }
        }

        public void GetUserPhone()
        {
            loggerService.LogInformation("Please enter your number: +998 ");
            userPhone = Console.ReadLine();

            loggerService.LogInformation("Your phone added succesfully!");
        }

        public void ChangeUserPassword()
        {
            for (int i = 0; i < 3; i++)
            {
                loggerService.LogInformation("Enter your password: ");
                string pin = Console.ReadLine();

                if(pin != userPassword)
                {
                    if (i == 2)
                    {
                        loggerService.LogInformation("Too much effort. Try again later.");
                        break;
                    }
                    loggerService.LogInformation("Incorrect password. Try again.");
                }
                else
                {
                    while (true)
                    {
                        try
                        {
                            loggerService.LogInformation("Enter new password: ");
                            string newPassword = Console.ReadLine();

                            if (newPassword.Length != 4)
                            {
                                throw new ArgumentOutOfRangeException("PIN must be a 4-digit number.");
                            }
                            
                            loggerService.LogInformation("Re-enter a new password: ");
                            string newPassword2 = Console.ReadLine();

                            if (newPassword != newPassword2)
                            {
                                loggerService.LogInformation("The passwords must be the same. Try again.");
                            }
                            else
                            {
                                userPassword = newPassword;
                                loggerService.LogInformation("PIN successfully changed.");
                                break;
                            }
                        }
                        catch (ArgumentException argumentException)
                        {
                            loggerService.LogInformation($"{argumentException.Message}. Try again");
                        }
                        catch (Exception exception)
                        {
                            loggerService.LogInformation($"{exception.Message}. Try again");
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
                    loggerService.LogInformation("Enter your phone number: ");
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
                    loggerService.LogInformation("Phone number successfully changed");
                    isCorrect = true;
                }
                catch (ArgumentException argumentException)
                {
                    loggerService.LogInformation   (argumentException.Message);
                }
                catch (Exception exception)
                {
                    loggerService.LogInformation(exception.Message);
                }
            }
        }
    }
}
