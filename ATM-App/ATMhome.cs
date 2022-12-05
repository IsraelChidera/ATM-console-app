using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    class ATMhome
    {
        private bool _isTrue = true;
        public English atmEnglish = new();
        public Igbo atmIgbo = new();
        public Pidgin atmPidgin = new();

       /* public enum LanguageOptions:int
        {
            English=1,
            Igbo,
            Pidgin
        }*/

        public ATMhome()
        {

        }
       

        public void Home()
        {                        

            Utility.PressEnterToContinue();
            Utility.Animation();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n******************************************************************\n");
            Console.WriteLine("If you want to be serviced in English press 1\n");
            Console.WriteLine("O buru n’ichoro ka e were gi ozi n’Igbo pia 2\n");
            Console.WriteLine("If you want make we service you with Pidgin, abeg press 3\n");
            Console.WriteLine("To exit this process, press 4\n");
            Console.WriteLine("*****************************************************************\n");
            Console.ResetColor();

            while (_isTrue)
            {
                try
                {
                    int options = Convert.ToInt32(Console.ReadLine());
                    
                    switch (options)
                    {
                        case 1:
                            Utility.Animation();
                            atmEnglish.EnglishATM();
                            break;
                        case 2:
                            Utility.Animation();
                            atmIgbo.IgboATM();
                            break;
                        case 3:
                            Utility.Animation();
                            atmPidgin.ATMPidgin();
                            break;
                        default:
                            Utility.Animation();
                            Console.WriteLine("Invalid option. Select a valid option");
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a valid input");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.ToString());
                }

            }


            /*while (_isTrue)
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
                    else
                    {
                        Console.WriteLine("Invalid inputs... Type a valid number");
                    }
                }
                catch(FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    Console.ResetColor();
                    continue;
                }
            }*/



        }
    }
}
