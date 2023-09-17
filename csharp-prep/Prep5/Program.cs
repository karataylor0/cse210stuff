using System;
using System.IO.Compression;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        //DisplayWelcome - displays "welcome to the program!"
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }
        //PromptUserName
        static string PromptUserName ()
        {
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            return username;
        }
        //PromptUserNumber
        static int PromptUserNumber ()
        {
            Console.WriteLine("What is your favorite number?");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        //SquareNumber
        static int SquareNumber (int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        //DisplayResult
        static void DisplayResult(string username, int squared)
        {
            Console.WriteLine($"{username}, the square of your favorite number is {squared}.");       
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int originalNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(originalNumber);
        DisplayResult(userName, squaredNumber);
    }
}