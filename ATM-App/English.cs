using System;
using System.Threading.Channels;

namespace ATM_App
{
    internal class English
    {
        /*private string _cardNumber;
        private string _pinNumber;*/
        public English()
        {
        }

        public void EnglishATM()
        {
            Console.WriteLine("************* Automated Teller Machine ******************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tVersion: version 1.3");
            Console.WriteLine("\tLanguage: English\n");
            Console.ResetColor();

            Console.WriteLine("Since this a simulation of an ATM");
            Console.WriteLine("We will be using the card number to use the ATM\n");

            ValidateCardNumber();
            ValidatePinNumber();
            
        }

        public void ValidateCardNumber()
        {
            Console.WriteLine("Card number must be up to 6 digits");

            string cardNumber = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (cardNumber.Length == 6 && int.TryParse(cardNumber, out int cardNum))
                    {
                        Console.WriteLine("**********************************************");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Congrats... Valid card number");                        
                        Console.WriteLine($"Card number: {cardNum}");
                        Console.ResetColor();
                        Console.WriteLine("**********************************************");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please try again");
                        cardNumber = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease enter a valid card number");
                    
                    Console.WriteLine(exception.Message);
                    Console.ResetColor();
                    continue;
                }
            }
            
            
        }
        
        public void ValidatePinNumber()
        {

            Console.WriteLine("Pin must be up to 4 digits");
            string pinNumber = Console.ReadLine();
            Console.WriteLine(pinNumber);
            
            while (true)
            {
                try
                {
                    if (pinNumber.Length == 4 && int.TryParse(pinNumber, out int pinNum))
                    {
                        Console.WriteLine("**********************************************");                    
                        Console.WriteLine($"PIN: {pinNum}");
                        Console.WriteLine("Congrats... You can now do your transactions");
                        Console.WriteLine("**********************************************");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid PIN. Please try again");
                        pinNumber = Console.ReadLine();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a PIN number");
                    Console.WriteLine(exception.Message);
                    Console.ResetColor();
                    continue;
                }
            }
        }
    }
}
