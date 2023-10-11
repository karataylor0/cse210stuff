using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Breathing : Activity
    {
        
        public Breathing(string activityName, string description) : base(activityName, description)
    {
        
    }
        public void BreathInBreathOut()
        {
            int totalTime = base.GetTotalTime() * 1000;

            while (totalTime != 0)
            {
                Console.WriteLine("Breath in.");
                Thread.Sleep(totalTime/4);
                Console.WriteLine("Breath out.");
                Thread.Sleep(totalTime/4);
                Console.WriteLine("Breath in.");
                Thread.Sleep(totalTime/4);
                Console.WriteLine("Breath out.");
                Thread.Sleep(totalTime/4);
            }
        }
    }
}