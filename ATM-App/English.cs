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
            /*string pin = Console.ReadLine();
            Console.WriteLine("Pin must be 4 digits\n");
            Console.WriteLine("");*/
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
                        Console.WriteLine("Congrats... Valid card number");                        
                        Console.WriteLine($"card num: {cardNum}");
                        Console.WriteLine("You can input your pin to start your transaction");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again");
                        cardNumber = Console.ReadLine();                        
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
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
        }
    }
}
