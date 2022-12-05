using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    class ATMoperation
    {            

        public ATMoperation()
        {
            
        }

        

        public delegate void PromptOperations(string message);

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
                        Utility.Animation();
                        Console.WriteLine("\n**********************************************");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Congrats... Valid card number");
                        Console.WriteLine($"Card number: {cardNum}");
                        Console.ResetColor();
                        Console.WriteLine("**********************************************\n");
                        break;
                    }
                    else
                    {
                        Utility.Animation();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid input. Please try again");
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
                        Utility.Animation();
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

        public static void ValidateAccountNumber()
        {

            Console.WriteLine("Account number must be up to 8 digits");

            string accountNumber = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (accountNumber.Length == 8 && int.TryParse(accountNumber, out int accountNum))
                    {
                        Utility.Animation();
                        Console.WriteLine("\n**********************************************");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Congrats... Valid account number");
                        Console.WriteLine($"Account number: {accountNum}");
                        Console.ResetColor();
                        Console.WriteLine("**********************************************\n");
                        break;
                    }
                    else
                    {
                        Utility.Animation();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid input. Please try again");
                        accountNumber = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease enter a valid account number");

                    Console.WriteLine(exception.Message);
                    Console.ResetColor();
                    continue;
                }
            }


        }

        public void Transactions()
        {
            int amount = 200000;
            int deposit;
            int withdraw;
            int choice;
            int transfer;

            Console.WriteLine("\n\nWHAT DO YOU WANT TO DO?");
            bool isTrue = true;

            while (isTrue)
            {
                Utility.Animation();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("****************AUTOMATED TELLER MACHINE**************\n");
                Console.WriteLine("\tType 1 to view Current Balance\n");
                Console.WriteLine("\tType 2 to withdraw funds\n");
                Console.WriteLine("\tType 3 to transfer funds \n");
                Console.WriteLine("\tType 4 to cancel transactions \n");
                Console.WriteLine("\tType 5 to transfer cash \n");
                Console.WriteLine("\tType 0 to change language/main menu \n");
                Console.WriteLine("*****************************************************\n\n");
                Console.Write("========> ");
                Console.ResetColor();

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Utility.Animation();
                        Console.WriteLine("\n****************************************");
                        Console.WriteLine("YOUR CURRENT BALANCE IS $ {0} ", amount);
                        Console.WriteLine("****************************************");
                        break;
                    case 2:
                        Console.Clear();
                        Utility.Animation();
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
                        Console.Clear();
                        Utility.Animation();
                        Console.WriteLine("\nENTER THE AMOUNT YOU WANT TO DEPOSIT(IN $$)");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS $ {0}", amount);
                        break;
                    case 4:
                        Console.Clear();
                        Utility.Animation();
                        Console.WriteLine("Thank you for banking with us...");
                        isTrue = false;
                        break;
                    case 5:
                        Utility.Animation();
                        Console.WriteLine("Transfer ....");
                        ValidateAccountNumber();
                        Console.WriteLine("\nENTER THE AMOUNT YOU WANT TO TRANSFER(IN $$)");
                        transfer = int.Parse(Console.ReadLine());
                        amount = amount - transfer;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN TRANSFERRED SUCCESSFULLY..");
                        PromptOperations operations = new PromptOperations(Utility.SucessfullTransferPrompts);
                        operations.Invoke($"Transfer successful...");
                        break;
                    case 0:
                        Console.Clear();
                        ATMhome home = new();
                        home.Home();
                        break;
                    default:
                        Console.WriteLine("Invalid inputs . . .");
                        break;
                }

            }

        }
    }
}
