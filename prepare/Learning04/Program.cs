using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("John Joe","History of Trees");
        Console.WriteLine(newAssignment.GetSummary());

        MathAssignment newMath = new MathAssignment("Barbara Gordon","Algebra","Chapter 1","1-12");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomeworkList());

        WritingAssignment newWriting = new WritingAssignment("Jojo Siwa","Pride and Prejudice","An Analysis of Mr. Bennet");
        Console.WriteLine(newWriting.GetSummary());
        Console.WriteLine(newWriting.GetWritingInformation());


    }
}