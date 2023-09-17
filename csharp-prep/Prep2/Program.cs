using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int number = int.Parse(gradeString);


        if (number >= 90)
        {
            Console.WriteLine("You got an A.");
        }

        else if (number >= 80)
        {
            Console.WriteLine("You got an B.");
        }

        else if (number >= 70)
        {
            Console.WriteLine("You got an C.");
        }

        else if (number >= 60)
        {
            Console.WriteLine("You got an D.");
        }

        else 
        {
            Console.WriteLine("You got an F.");
        }


        if (number > 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
            Console.WriteLine("You failed.");
        }

        string letter = "";
        if (number < 60)
        {
            letter = "F";
        }
        else if (number < 70)
        {
            letter = "D";
        }
        else if (number < 80)
        {
            letter = "C";
        }
        else if (number < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        int remainder = number % 10;
        string plusMinus = "";
        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            plusMinus = "+";
        }
        else if (remainder < 3 && letter != "F")
        {
            plusMinus = "-";
        }


        Console.WriteLine($"Your grade is a {letter}{plusMinus}.");
    }
}