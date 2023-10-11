using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Reflection : Activity
    {
        private List<string> _reflectionPrompts;

        private List<string> _reflectionQuestions;

        public Reflection(string activityName, string description) : base(activityName, description)
        {
            
        }
        
        public void AddReflectionPrompts()
        {
            _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
            _reflectionPrompts.Add("Think of a time when you helped someone in need.");
            _reflectionPrompts.Add("Think of a time when you did something really difficult.");
            _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
            _reflectionPrompts.Add("Think of a time when you went out of your comfort zone to do something good.");
            _reflectionPrompts.Add("Think of a time when you maintained your integrity.");
        }
        public void AddReflectionQuestions()
        {
            _reflectionQuestions.Add("Why was this experience meaningful to you?");
            _reflectionQuestions.Add("Have you ever done anything like this before?");
            _reflectionQuestions.Add("How did you get started?");
            _reflectionQuestions.Add("How did you feel when it was complete?");
            _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
            _reflectionQuestions.Add("What is your favorite thing about this experience?");
            _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
            _reflectionQuestions.Add("What did you learn about yourself through this experience?");
            _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
            _reflectionQuestions.Add("What was the most helpful step you took during this expierence?");
            _reflectionQuestions.Add("What challenges did you overcome during this experience?");
        }
        public void DisplayRandomPrompt()
        {
            Console.WriteLine("Consider the following prompt:");
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_reflectionPrompts.Count);
            Console.WriteLine(_reflectionPrompts[index]);
        }
        public void DisplayRandomQuestion()
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_reflectionQuestions.Count);
            Console.WriteLine(_reflectionQuestions[index]);
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