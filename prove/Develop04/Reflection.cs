using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Reflection : Activity
    {
        private List<string> _reflectionPrompts;

        private List<string> _reflectionQuestions;

        public Reflection(string activityName, string description, List<string> reflectionPrompts, List<string> reflectionQuestions) : base(activityName, description)
        {
            _reflectionPrompts = reflectionPrompts;
            _reflectionQuestions = reflectionQuestions;
        }
        
        public void DisplayRandomPrompt()
        {
            Console.WriteLine("Consider the following prompt:");
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_reflectionPrompts.Count);
            Console.WriteLine(_reflectionPrompts[index]);
        }
        public void DisplayRandomQuestions()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetTotalTime());

            while (DateTime.Now < futureTime)
            {
                Random randomGenerator = new Random();
                int index = randomGenerator.Next(_reflectionQuestions.Count);
                Console.WriteLine(_reflectionQuestions[index]);
                base.PauseAnimation(10000);
            }
        }
        public void WaitingTime(int time)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(time);
            
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.Write(" . ");
                Thread.Sleep(250);
                Console.Write(" . ");
                Thread.Sleep(250);
                Console.Write(" . ");
                Thread.Sleep(250);
                Console.Write("\b \b \b \b \b \b \b \b \b \b");
            }
        }
    }
}