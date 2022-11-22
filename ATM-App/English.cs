using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class English
    {
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

            //Since this a simulation of an ATM
            //We will be using the card number to use the ATM
            Console.WriteLine("Since this a simulation of an ATM");
            Console.WriteLine("We will be using the card number to use the ATM\n");
            Console.WriteLine("Card number must be up to 6 digits");

            //int cardNumber = Convert.ToInt32(Console.ReadLine());
            string cardNumber = Console.ReadLine();
            Console.WriteLine(cardNumber);

           /* try
            {
                if (cardNumber == 0)
                {

                }
            }
            catch
            {

            }*/
        }
    }
}
