using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Cycling cycling1 = new Cycling(10, "Dec", 10, 2022, 15);
        cycling1.DisplaySummary();

        Running running1 = new Running(5, "Jan", 05, 2023, 60);
        running1.DisplaySummary();

        Swimming swimming1 = new Swimming(15, "Sep", 28, 2023, 30);
        swimming1.DisplaySummary();
    }
}