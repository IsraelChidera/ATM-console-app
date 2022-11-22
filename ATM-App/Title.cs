using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class Title
    {
        private string _appName;

        public Title() { _appName = "My Multi-lingual ATM App"; }       

        public void showTitle()
        {
            Console.WriteLine("*********** Welcome onboard ************");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t{0}\n",_appName);
            Console.ResetColor();
        }
    }
}
