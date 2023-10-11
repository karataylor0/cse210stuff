using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Develop04
{
    public class Listing : Activity
    {
        private List<string> _listingPrompts;
        private List<string> _items;

        public Listing(string activityName, string description, List<string> listingPrompts, List<string> items) : base(activityName, description)
        {
            _listingPrompts = listingPrompts;
            _items = items;
        }
        

        
        //list items until duration is over
        public void ListItems()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetTotalTime());

            while (DateTime.Now < futureTime)
            {
                string item = Console.ReadLine();
                _items.Add(item);
            }
        }

        //select random prompt to show
        public void DisplayRandomPrompt()
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_listingPrompts.Count);
            Console.WriteLine(_listingPrompts[index]);
        }

        //countdown of several seconds to think about prompt
        public void Countdown()
        {
            Console.WriteLine("");
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

        //display item count
        public void DisplayItemCount()
        {
            Console.WriteLine($"You wrote {_items.Count} items.");
        }

        //display items
        public void DisplayItems()
        {
            foreach (string item in _items)
            {
                Console.Write($"{item}. ");
            }
        }
    }
}