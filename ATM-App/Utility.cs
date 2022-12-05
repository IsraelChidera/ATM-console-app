﻿namespace ATM_App
{
    public static class Utility
    {
        private static string _amount;

        public static string Amount
        {
            get; set;
        }

        public static void Animation(int timer = 15)
        {
            for (var i = 0; i < timer; i++)
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

        

        public static void SucessfullTransferPrompts(string message)
        {
            Console.WriteLine(message);
        }

    }
}
