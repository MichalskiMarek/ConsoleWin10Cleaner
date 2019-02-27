using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWin10Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will remove the following applications from your system:");
            Console.WriteLine("3D Builder");
            Console.WriteLine("Alarms & Clock");
            Console.WriteLine("Calendar and Mail");
            Console.WriteLine("Camera");
            Console.WriteLine("Feedback Hub");
            Console.WriteLine("Office");
            Console.WriteLine("Get Started and Tips");
            Console.WriteLine("Skype");
            Console.WriteLine("Groove Music, Movies & TV");
            Console.WriteLine("Maps");
            Console.WriteLine("Messaging");
            Console.WriteLine("Microsoft Solitaire Collection");
            Console.WriteLine("Microsoft Wallet");
            Console.WriteLine("Microsoft Wi-Fi");
            Console.WriteLine("Money, News, Sports and Weathe");
            Console.WriteLine("OneNote");
            Console.WriteLine("Paid Wi-Fi & Cellular");
            Console.WriteLine("Paint ");
            Console.WriteLine("People");
            Console.WriteLine("Phone and Phone Companion");
            Console.WriteLine("Photos");
            Console.WriteLine("Sticky Notes");
            Console.WriteLine("Sway");
            Console.WriteLine("View 3D");
            Console.WriteLine("Windows Holographic");
            Console.WriteLine("Voice Recorder");
            Console.WriteLine("Windows Store");
            Console.WriteLine("Xbox");
            Console.WriteLine("Do you want to continue? Y/N");

            List<string> appsArray = new List<string>(new string[] {
                "3dbuilder",
                "alarms",
                "communicationsapps",
                "camera",
                "feedback",
                "officehub",
                "getstarted",
                "skypeapp",
                "zune",
                "maps",
                "messaging",
                "solitaire",
                "wallet",
                "connectivitystore",
                "bing",
                "onenote",
                "oneconnect",
                "mspaint",
                "people",
                "phone",
                "photos",
                "sticky",
                "sway",
                "3d",
                "soundrecorder",
                "holographic",
                "windowsstore",
                "xbox" });

            PSpipe pspipe = new PSpipe();
            ConsoleKeyInfo result = Console.ReadKey();
            if (result.KeyChar == 'y' || result.KeyChar == 'Y')
            {
                foreach (string app in appsArray)
                {
                    Console.WriteLine("Removing applications...");
                    Console.Write(pspipe.RunScript($"get-appxpackage *{app}* | remove-appxpackage"));
                }
            }
            else Environment.Exit(1);
        }
    }
}
