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
            int totalTime = base.GetTotalTime();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(totalTime);

            //reflect on questions pulled from list
            while (DateTime.Now < futureTime)
            {
                Console.WriteLine("Breath in.");
                Thread.Sleep(3000);
                Console.WriteLine("Breath out.");
                Thread.Sleep(5000);
            }
        }
    }
}