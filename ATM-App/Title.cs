using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public static class Title
    {
        private static string _appName = "AUTOMATED TELLER MACHINE";

        /*public Title() { _appName = "My Multi-lingual ATM App"; }   */    

        public static void showTitle()
        {
            Console.WriteLine("*******************************************************************");            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****************{0}****************\n", _appName);
            Console.ResetColor();
        }
    }
}
