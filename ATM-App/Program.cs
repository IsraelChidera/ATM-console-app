using System;

namespace ATM_App
{   

     class Program
    {        
        static void Main(string[] args)
        {

            Title.showTitle();
            ATMhome ATMshowcase = new ATMhome();
            ATMshowcase.Home();

        }
    }
}