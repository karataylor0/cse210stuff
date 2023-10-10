using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Listing : Activity
    {
        private int _items;
        private List<string> _listingPrompts;
        private List<string> _reponses;

        public Listing(string activityName, string description) : base(activityName, description)
        {
            
        }
        
        public void DisplayRandomPrompt()
        {
            _listingPrompts.Add("Who are people that you appreciate?");
            _listingPrompts.Add("What are personal strengths of yours?");
            _listingPrompts.Add("Who are people that you have helped this week?");
            _listingPrompts.Add("When have you felt the Holy Ghost this month?");
            _listingPrompts.Add("Who are some of your personal heros?");
            _listingPrompts.Add("What are you grateful for today?");
            _listingPrompts.Add("What are the biggest blessings in your life?");
            
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_listingPrompts.Count);
            Console.WriteLine(_listingPrompts[index]);
        }

        public void Countdown() : base()
        {
            int totalTime = base.GetTotalTime();
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        public void DisplayItems()
        {
            Console.WriteLine($"You wrote {_items} items.");
        }
        public int CountItems(int timeOrSomething)
        {
            
            while ( > 0)
            {
                AHHHHHHHHHHHHHHHHHHHHHHHHHHHH
            }
        }
    }
}