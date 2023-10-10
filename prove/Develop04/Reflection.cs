using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Reflection : Activity
    {
        private List<string> _reflectionPrompts;

        public Reflection(string activityName, string description) : base(activityName, description)
        {
            
        }
        
        public void DisplayRandomPrompt()
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_reflectionPrompts.Count);
            Console.WriteLine(_reflectionPrompts[index]);
        }
    }
}