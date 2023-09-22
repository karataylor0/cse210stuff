using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello to the journal!");
        
        string choice = "";
        Journal myJournal = new Journal();
        string filename = "W02Journal.xlsx";
        PromptGenerator promptsAndWhatnot = new PromptGenerator();
        promptsAndWhatnot.AddPrompts();
        while (choice != "5")
        {
            Console.WriteLine("Menu:\n1. Write New Entry\n2. Display the Journal\n3.Save Journal to File\n4. Load Journal From File\n5. Quit");
            choice  = Console.ReadLine();

            if (choice == "1")
            {
                //write new entry
                Entry myEntry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                myEntry._date = theCurrentTime.ToShortDateString();
                myEntry._promptText = promptsAndWhatnot.GetRandomPrompt();
                Console.WriteLine($"{myEntry._promptText}");
                myEntry._entryText = Console.ReadLine();
                myJournal.AddEntry(myEntry);
            }
            if (choice == "2")
            {
                //display journal
                myJournal.DisplayAll();
            }
            if (choice == "3")
            {
                //save journal
                myJournal.SaveToFile(filename);
            }
            if (choice == "4")
            {
                //load journal
                myJournal.LoadFromFile(filename);
            }
        }
    }
}