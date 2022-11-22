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
            Console.WriteLine("If you want to be serviced in Igbo press 2\n");
            Console.WriteLine("If you want to be serviced in Pidgin press 3\n");
            Console.WriteLine("To exit this process, press 4\n");
            Console.WriteLine("*********************************************************\n");
            Console.ResetColor();

            /*int inputLanguageType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputLanguageType);*/
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
                        Console.WriteLine("Igbo continues");
                        Igbo igbo = new();
                        igbo.IgboATM();
                        break;
                    }
                    else if (inputLanguageType == 3)
                    {
                        Console.WriteLine("Pidgin continues");
                        Pidgin pidgin = new();
                        pidgin.ATMPidgin();
                        break;
                    }
                    else if (inputLanguageType == 4)
                    {
                        Console.WriteLine("Exit completed");
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
            

            //int inputLanguageType = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(inputLanguageType);
        }
    }
}
