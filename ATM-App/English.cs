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
            Console.WriteLine("We will be using the card number to use the ATM\n\n");

            ATMoperation atmOperation = new();
            atmOperation.ValidateCardNumber();
            atmOperation.ValidatePinNumber();
            atmOperation.Transactions();
        }

        
    }
}
