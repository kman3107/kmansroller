using System;
using System.Diagnostics;
using System.Threading;

namespace KmansRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            var tilExit = true;

            while (tilExit)
            {
                tilExit = false;

                Console.WriteLine("Welcome to K-MaN's Roller!");
                Console.WriteLine("");
                Console.Write("Please start by writing your name: ");
                String Input1 = Console.ReadLine();
                Console.WriteLine("Hello " + Input1 + "!");
                Console.Write("To start type 'Go', or type 'Exit' to quit the program: ");
                String Input2 = Console.ReadLine().ToLower();
                Console.WriteLine("");

                if (Input2 == "go")
                {
                    Console.Write("Please wait while loading. ");
                    Thread.Sleep(1000);
                    Console.Write(". ");
                    Thread.Sleep(1000);
                    Console.Write(". ");
                    Thread.Sleep(1250);
                    Console.Write(". ");
                    Chrome();
                    Console.WriteLine("Success!");
                    Console.ReadKey();
                    return;
                }

                else if (Input2 == "exit")
                {
                    Console.WriteLine("Come back when you are ready.");
                    Console.ReadKey();
                    return;
                }

                else
                {
                    Console.WriteLine("Try again.");
                    tilExit = true;
                }
            }
        }
        static public void Chrome()
        {
            Process.Start("chrome.exe", "getrolled.unstick.org");
        }
    }
}
