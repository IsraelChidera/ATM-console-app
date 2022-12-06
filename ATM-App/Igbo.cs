
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class Igbo
    {
        public Igbo()
        {

        }

        public void IgboATM()
        {
            Console.WriteLine("************* Automated Teller Machine ******************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tVersion: version 1.3");
            Console.WriteLine("\tAsusu : Igbo\n");
            Console.ResetColor();

            Console.WriteLine("Nke a bu ime anwansi nke kaadi ATM");
            Console.WriteLine("Anyi ga-eji nomba kaadi iji ATM\n\n");

            ValidateCardNumber();
            ValidatePinNumber();
            Transactions();
        }

        public void ValidateCardNumber()
        {
            Console.WriteLine("Nomba kaadi ga-eruriri nkeji isii");

            string cardNumber = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (cardNumber.Length == 6 && int.TryParse(cardNumber, out int cardNum))
                    {
                        Console.WriteLine("**********************************************");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ekele... Nomba kaadi adabara");
                        Console.WriteLine($"Nomba kaadi: {cardNum}");
                        Console.ResetColor();
                        Console.WriteLine("**********************************************\n");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nomba kaadi ga-eruriri nkeji isii");
                        cardNumber = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\r\nBiko tinye nọmba kaadị bara uru");

                    Console.WriteLine(exception.Message);
                    Console.ResetColor();
                    continue;
                }
            }


        }

        public void ValidatePinNumber()
        {

            Console.WriteLine("\nNtutu ga-eruriri onuogu ano");
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
                        Console.WriteLine("Ekele... I nwere ike ime azumahia gi ugbu a");
                        Console.WriteLine("**********************************************");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Utility.Animation();
                        Console.WriteLine("PIN ezighi ezi. Biko nwaa ozo");
                        pinNumber = Console.ReadLine();
                    }
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nBiko tinye nomba PIN");
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
            int userInput;
            Console.WriteLine("\n\nKEDU IHE I CHORO IME?");
            bool isTrue = true;

            while (isTrue)
            {
                Utility.Animation();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("****************AUTOMATED TELLER MACHINE**************\n");
                Console.WriteLine("\tPinye 1 ka ilele nha nha ugbu a\n");
                Console.WriteLine("\tUdi 2 iji wepu ego\n");
                Console.WriteLine("\tUdi 3 iji nyefee ego \n");
                Console.WriteLine("\tPinye 4 ka ikagbu azumahia \n");
                Console.WriteLine("****************************************************\n\n");
                Console.Write("========> ");
                Console.ResetColor();

                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Utility.Animation();
                        Console.WriteLine("\n****************************************");
                        Console.WriteLine("Nhazi gi ugbu a bu $ {0} ", amount);
                        Console.WriteLine("****************************************");
                        break;
                    case 2:
                        Utility.Animation();
                        Console.WriteLine("\nTinye ego na $$ ka iwepu : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {                            
                            Console.WriteLine("\nBiko tinye ego n'ihe kariri 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {                            
                            Console.WriteLine("\nNdo! EGO NA-ECHICHE");
                        }
                        else
                        {                            
                            amount = amount - withdraw;
                            Console.WriteLine("\n\nBiko chikota ego gi");
                            Console.WriteLine("\nNhazi oge ugbu a bu $ {0}", amount);
                        }
                        break;
                    case 3:
                        Utility.Animation();
                        Console.WriteLine("\nTinye ego i choro ibufe(na $$)");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Etinyela ego gi nke oma..");
                        Console.WriteLine("Ngukota nguzozi gi bu $ {0}", amount);
                        break;
                    case 4:
                        Utility.Animation();
                        Console.WriteLine("Daalu maka gi na ulo aku...");
                        isTrue = false;
                        break;
                }
            }

        }
    }
}
