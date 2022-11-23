using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    class ATMhome
    {
        bool _check = true;

        public ATMhome()
        {

        }

        Title title = new();

        public void Home()
        {            
            title.showTitle();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine("If you want to be serviced in English press 1\n");
            Console.WriteLine("O buru n’ichoro ka e were gi ozi n’Igbo pia 2\n");
            Console.WriteLine("If you want make we service you with Pidgin, abeg press 3\n");
            Console.WriteLine("To exit this process, press 4\n");
            Console.WriteLine("*********************************************************\n");
            Console.ResetColor();
            
            while (_check)
            {
                try
                {
                    int inputLanguageType = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(inputLanguageType);

                    if (inputLanguageType == 1)
                    {
                        English english = new();
                        english.EnglishATM();
                        break;
                    }
                    else if (inputLanguageType == 2)
                    {                        
                        Igbo igbo = new();
                        igbo.IgboATM();
                        break;
                    }
                    else if (inputLanguageType == 3)
                    {                        
                        Pidgin pidgin = new();
                        pidgin.ATMPidgin();
                        break;
                    }
                    else if (inputLanguageType == 4)
                    {
                        Console.WriteLine("You have exited successfully!");
                        Console.WriteLine("We will love to see you next time");
                        break;
                    }
                }
                catch(FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    Console.ResetColor();
                    continue;
                }
            }
            

            
        }
    }
}
