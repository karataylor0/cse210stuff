using System;
using System.Threading;
using System.Collections.Generic;

namespace Develop04
{
    public class Activity
    {
        private string _activityName;
        private string _description;
        private int _totalTime;

        public Activity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }
        
        public void StartMessage()
        {
            //message with name of activity, description
            Console.WriteLine($"Welcome to {_activityName}! {_description}.");

            // ask for and set the duration
            Console.WriteLine("What time would you want (in seconds)?");
            int _totalTime = int.Parse(Console.ReadLine());
            

            //pause for several seconds
            Thread.Sleep(3000);
        }

        public void EndMessage()
        {
            //great job message
            Console.WriteLine("Great job!");
            //pause
            Thread.Sleep(3000);
            //activity completed, length of time
            Console.WriteLine($"You've completed {_activityName}! It took {_totalTime}");
            //pause
            Thread.Sleep(2000);
        }

        public void PauseAnimation(int time)
        {
            //some kind of animation (spinner, countdown timer, periods)
            while (time != 0)
            {
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("--");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(250);

                time = time - 1000;
            }
        }


        public int GetTotalTime()
        {
            return _totalTime;
        }

        public string GetActivityName()
        {
            return _activityName;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}