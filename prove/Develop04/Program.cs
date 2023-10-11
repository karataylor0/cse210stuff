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
                    Reflection reflection1 = new Reflection("Reflection", "The reflection will help you to think over times in your life where you showed strength and resilience. You will be given a prompt to think over and questions to ask about the prompt.");
                    reflection1.AddReflectionPrompts();
                    reflection1.AddReflectionQuestions();

                    //start message, duration
                    reflection1.StartMessage();

                    //select random prompt to show user
                    reflection1.DisplayRandomPrompt();

                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(reflection1.GetTotalTime());

                    DateTime currentTime = DateTime.Now;

                    //reflect on questions pulled from list
                    while (currentTime < futureTime)
                    {
                        reflection1.DisplayRandomQuestion();
                        //pause for several seconds
                        reflection1.PauseAnimation(5000);
                    }
                    //end message
                    reflection1.EndMessage();
                }
                else if (choice == "3")
                {
                    //Listing Activity
                    Listing listing1 = new Listing("Listing", "This activity will help you to list out things and focus on the positives in your life.");
                    listing1.StartMessage();
                    //select random prompt to show
                    //countdown of several seconds to think about prompt
                    //list items until duration is over
                    //display items
                    //end message
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