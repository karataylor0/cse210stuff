using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            //lists
            List<string> reflectionPrompts = new List<string>();
            reflectionPrompts.Add("Think of a time when you stood up for someone else.");
            reflectionPrompts.Add("Think of a time when you helped someone in need.");
            reflectionPrompts.Add("Think of a time when you did something really difficult.");
            reflectionPrompts.Add("Think of a time when you did something truly selfless.");
            reflectionPrompts.Add("Think of a time when you went out of your comfort zone to do something good.");
            reflectionPrompts.Add("Think of a time when you maintained your integrity.");

            List<string> reflectionQuestions = new List<string>();
            reflectionQuestions.Add("Why was this experience meaningful to you?");
            reflectionQuestions.Add("Have you ever done anything like this before?");
            reflectionQuestions.Add("How did you get started?");
            reflectionQuestions.Add("How did you feel when it was complete?");
            reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
            reflectionQuestions.Add("What is your favorite thing about this experience?");
            reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
            reflectionQuestions.Add("What did you learn about yourself through this experience?");
            reflectionQuestions.Add("How can you keep this experience in mind in the future?");
            reflectionQuestions.Add("What was the most helpful step you took during this expierence?");
            reflectionQuestions.Add("What challenges did you overcome during this experience?");

            List<string> listingPrompts = new List<string>();
            listingPrompts.Add("Who are people that you appreciate?");
            listingPrompts.Add("What are personal strengths of yours?");
            listingPrompts.Add("Who are people that you have helped this week?");
            listingPrompts.Add("When have you felt the Holy Ghost this month?");
            listingPrompts.Add("Who are some of your personal heros?");
            listingPrompts.Add("What are you grateful for today?");
            listingPrompts.Add("What are the biggest blessings in your life?");

            List<string> items = new List<string>();
            

            //mindfulness program
            Console.WriteLine("\nWelcome to the Mindfulness Program!");

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


                    Reflection reflection1 = new Reflection("Reflection", "The reflection will help you to think over times in your life where you showed strength and resilience. You will be given a prompt to think over and questions to ask about the prompt.", reflectionPrompts, reflectionQuestions);

                    //start message, duration
                    reflection1.StartMessage();

                    //select random prompt to show user
                    reflection1.DisplayRandomPrompt();
                    //display questions with pauses
                    reflection1.DisplayRandomQuestions();
                    //end message
                    reflection1.EndMessage();
                }
                else if (choice == "3")
                {
                    //Listing Activity
                    Listing listing1 = new Listing("Listing", "This activity will help you to list out things and focus on the positives in your life.", listingPrompts, items);
                    listing1.StartMessage();
                    //select random prompt to show
                    listing1.DisplayRandomPrompt();
                    //countdown of several seconds to think about prompt
                    listing1.Countdown();
                    //list items until duration is over
                    listing1.ListItems();
                    //display items
                    listing1.DisplayItemCount();
                    listing1.DisplayItems();
                    //end message
                    listing1.EndMessage();
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }

        }
    }
}