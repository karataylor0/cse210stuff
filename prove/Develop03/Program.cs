using System;

namespace Develop3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptureList = new List<Scripture>();
            
            Reference reference1 = new Reference("John", 11, 35);
            Scripture scripture1 = new Scripture("Jesus wept.", reference1);
            scriptureList.Add(scripture1);

            Reference reference2 = new Reference("2 Nephi", 2, 25);
            Scripture scripture2 = new Scripture("Adam feel that men might be; and men are, that they might have joy.", reference2);
            scriptureList.Add(scripture2);

            Reference reference3 = new Reference("Psalm", 46, 10);
            Scripture scripture3 = new Scripture("Be still, and know that I am God.", reference3);
            scriptureList.Add(scripture3);

            Reference reference4 = new Reference("Isiah", 58, 6, 7);
            Scripture scripture4 = new Scripture("Is not this the fast that I have chosen? to loose the bands of wickedness, to undo the heavy durdens, and to let the oppressed go free, and that ye break every yoke? \nIs it not to deal thir bread to the hungry, and that thou bring the poor that are cast out to thy house? when thou seest the naked, that thou cover him; and that thou hide not tyself from thine own flesh?", reference4);
            scriptureList.Add(scripture4);

            Random randomGenerator1 = new Random();
            int index = randomGenerator1.Next(scriptureList.Count);
            
            string quitter = "";

            Console.WriteLine("Welcome to the scripture memorizer!");

            Console.WriteLine(scriptureList[index].GetDisplayText());
            
            while (!scriptureList[index].IsCompletelyHidden())
            {
                if (quitter != "quit")
                {
                    Console.Write("Type 'quit' to exit or press enter hide a word: ");
                    quitter = Console.ReadLine();


                    for (int i = 0; i < 3; i++)
                    {
                        scriptureList[index].HideRandomWord();
                        if (scriptureList[index].IsCompletelyHidden() == true)
                        {
                            break;
                        }
                    }

                    Console.WriteLine(scriptureList[index].GetDisplayText());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("You are done with the scripture memorizer.");
        }
    }
}