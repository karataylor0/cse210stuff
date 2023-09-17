using System;
using System.Collections.Generic;

Console.WriteLine("Enter a list of numbers; type 0 when finished.");

List<int> numbers = new List<int>();

int typedNumber = -1;
while (typedNumber != 0)
{
    Console.WriteLine("Enter number:");
    if (typedNumber != 0)
    {
        typedNumber = int.Parse(Console.ReadLine());
        numbers.Add(typedNumber);
    }
}

int largestNumber = 0;
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
    if (number > largestNumber)
    {
        largestNumber = number;
    }
}
Console.WriteLine($"The sum is :{sum}");

int amount = numbers.Count;
int average = sum / amount;
Console.WriteLine($"The average is: {average}");

Console.WriteLine($"The largest number is: {largestNumber}");
