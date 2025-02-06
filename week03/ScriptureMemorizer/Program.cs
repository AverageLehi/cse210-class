using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var reference = new ScriptureReference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        bool allHidden = false;

        while(!allHidden)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            allHidden = !scripture.HideRandomWords(3);
        }
        
        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nAll words are now hidden. Program ending.");   
    }
}