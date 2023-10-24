using System;

namespace Develop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference1 = new Reference("1 Nephi", 3, 7);
            Scripture scripture1 = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", reference1);


            Console.WriteLine(scripture1.GetDisplayText());
            // Loop until all words are hidden or the user types "quit"
            while (!scripture1.IsCompletelyHidden())
            {
                while (true) // Continue looping until the user types "quit"
                {
                    Console.Write("Press enter to hide a word or type 'quit' to exit): ");
                    string wordToHide = Console.ReadLine();

                    if (string.Equals(wordToHide, "quit", StringComparison.OrdinalIgnoreCase))
                    {
                        break; // Exit the loop when the user types "quit"
                    }
                    if(!string.IsNullOrWhiteSpace(wordToHide))
                    {
                        scripture1.HideWord(wordToHide);
                        Console.WriteLine(scripture1.GetDisplayText());
                    }
                }
            }
        }
    }
}