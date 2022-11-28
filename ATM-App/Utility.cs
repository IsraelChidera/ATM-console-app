using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public static class Utility
    {
        public static void Animation(int timer=15)
        {
            for(var i=0; i<timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("Press Enter to Continue");

            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    PressEnterToContinue();
                }
            }
        }
    }
}
