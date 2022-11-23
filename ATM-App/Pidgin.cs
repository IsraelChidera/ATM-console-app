using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class Pidgin
    {
        public Pidgin()
        {
            
        }

        public void ATMPidgin()
        {
            Console.WriteLine("************* Automated Teller Machine ******************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tVersion na version 1.3");
            Console.WriteLine("\tLanguage na Pidgin\n");
            Console.ResetColor();

            Console.WriteLine("This wan na simulation of how ATM suppose be");
            Console.WriteLine("This ATM go require card number and pin\n\n");

            ValidateCardNumber();
            ValidatePinNumber();
            Transactions();
        }

        public void ValidateCardNumber()
        {
            Console.WriteLine("Card number suppose dey up to 6 digits");

            string cardNumber = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (cardNumber.Length == 6 && int.TryParse(cardNumber, out int cardNum))
                    {
                        Console.WriteLine("**********************************************");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Congrats... Card number dey valid");
                        Console.WriteLine($"Card number: {cardNum}");
                        Console.ResetColor();
                        Console.WriteLine("**********************************************\n");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input no correct. Abeg try again");
                        cardNumber = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nAbeg enter card number wey dey valid");

                    Console.WriteLine(exception.Message);
                    Console.ResetColor();
                    continue;
                }
            }


        }

        public void ValidatePinNumber()
        {

            Console.WriteLine("\nPin suppose dey up to 4 digits");
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
                        Console.WriteLine("Congrats... You fit continue with your transactions");
                        Console.WriteLine("**********************************************");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("PIN dey invalid. Abeg try again");
                        pinNumber = Console.ReadLine();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Abeg enter PIN number");
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
            Console.WriteLine("\n\nABEG WETIN YOU WAN DO?");
            bool isTrue = true;

            while (isTrue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("****************AUTOMATED TELLER MACHINE**************\n");
                Console.WriteLine("\tType 1 if you wan view Current Balance\n");
                Console.WriteLine("\tType 2 if you wan withdraw funds\n");
                Console.WriteLine("\tType 3 if you wan transfer funds \n");
                Console.WriteLine("\tType 4 make you cancel transactions \n");
                Console.WriteLine("****************************************************\n\n");
                Console.Write("========> ");
                Console.ResetColor();

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n****************************************");
                        Console.WriteLine("YOUR CURRENT BALANCE NA $ {0} ", amount);
                        Console.WriteLine("****************************************");
                        break;
                    case 2:
                        Console.WriteLine("\nENTER AMOUNT IN $$ WEY YOU WAN WITHDRAW : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\nABEG ENTER THE AMOUNT IN $$ WEY DEY ABOVE $100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\nSORRY! YOU GET INSUFFICENT FUNDS");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\nABEG COLLECT YOUR CASH");
                            Console.WriteLine("\nCURRENT BALANCE IS $ {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nABEG ENTER AMOUNT YOU WAN TRANSFER(IN $$)");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR MONEY DONE SEND..");
                        Console.WriteLine("YOUR TOTAL BALANCE NA $ {0}", amount);
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
