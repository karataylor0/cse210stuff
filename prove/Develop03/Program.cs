using System;

namespace Develop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference1 = new Reference("1 Nephi", 3, 7);
            Scripture scripture1 = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", reference1);

            string quitter = "";

            Console.WriteLine(scripture1.GetDisplayText());
            
            while (!scripture1.IsCompletelyHidden())
            {
                if (quitter != "quit")
                {
                    Console.Write("Type 'quit' to exit or type something else to hide a word: ");
                    quitter = Console.ReadLine();

                    scripture1.HideRandomWord();
                    Console.WriteLine(scripture1.GetDisplayText());
                }
            }
        }
    }
}