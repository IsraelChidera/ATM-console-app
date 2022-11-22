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

            ValidateCardNumber();
            ValidatePinNumber();
            Transactions();
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Congrats... Valid card number");
                        Console.WriteLine($"Card number: {cardNum}");
                        Console.ResetColor();
                        Console.WriteLine("**********************************************\n");
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

            Console.WriteLine("\nPin must be up to 4 digits");
            string pinNumber = Console.ReadLine();
            Console.WriteLine(pinNumber);

            while (true)
            {
                try
                {
                    if (pinNumber.Length == 4 && int.TryParse(pinNumber, out int pinNum))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n**********************************************");
                        Console.WriteLine($"PIN: {pinNum}");
                        Console.WriteLine("Congrats... You can now do your transactions");
                        Console.WriteLine("**********************************************");
                        Console.ResetColor();
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

        public void Transactions()
        {
            int amount = 2034;
            int deposit;
            int withdraw;
            int choice;
            Console.WriteLine("\n\nWHAT DO YOU WANT TO DO?");
            bool isTrue = true;

            while (isTrue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("****************AUTOMATED TELLER MACHINE**************\n");
                Console.WriteLine("\tType 1 to view Current Balance\n");
                Console.WriteLine("\tType 2 to withdraw funds\n");
                Console.WriteLine("\tType 3 to transfer funds \n");
                Console.WriteLine("\tType 4 to cancel transactions \n");
                Console.WriteLine("****************************************************\n\n");
                Console.WriteLine("========>");
                Console.ResetColor();

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n****************************************");
                        Console.WriteLine("YOUR CURRENT BALANCE IS $ {0} ", amount);
                        Console.WriteLine("****************************************");
                        break;
                    case 2:
                        Console.WriteLine("\nENTER AMOUNT IN $$ TO WITHDRAW : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {                            
                            Console.WriteLine("\nPLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\nSORRY! INSUFFICENT FUNDS");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\nPLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\nCURRENT BALANCE IS $ {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nENTER THE AMOUNT YOU WANT TO TRANSFER(IN $$)");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS $ {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for banking with us...");
                        isTrue = false;
                        break;
                }
            }

        }
    }
}
