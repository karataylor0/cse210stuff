using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");

            string choice = "0";

            while (choice != "4")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    //Breathing Activity
                    Breathing breathing1= new Breathing("Breathing Activity", "This activity will help you to breath in and out slowly to help you be calm and relaxed.");
                    breathing1.StartMessage();
                    breathing1.BreathInBreathOut();
                    breathing1.EndMessage();
                }
                else if (choice == "2")
                {
                    //Reflection Activity
                    Reflection reflection1 = new Reflection("Reflection", "Reflect on stuff my dude. It's calming.");
                    reflection1.StartMessage();
                    reflection1.PauseAnimation();
                    while (reflection1.GetTotalTime() > 0)
                    {
                        reflection1.DisplayRandomPrompt();
                    }
                    reflection1.WaitingTime();


                    reflection1.EndMessage();
                }
                else if (choice == "3")
                {
                    //Listing Activity
                    Listing listing1 = new Listing("Listing", "This activity will help you to list out things and focus on the positives in your life.");
                    listing1.StartMessage();
                    //actual activity stuff
                    listing1.EndMessage();
                }
                else
                {
                    //Weird Thing Entered
                    Console.WriteLine("Girl, what are you typing?");
                }
            }

        }
    }
}