using System;

class Program
{
    static void Main(string[] args)
    {
        // Instances
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            // Menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Add a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Create a new Entry
                Entry entry = new Entry
                {
                    _date = DateTime.Now, // Current date and time
                    _promptText = promptGenerator.GetRandomPrompt() // Random prompt

                };

                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine(entry._promptText);
                Console.Write("Enter your journal entry: ");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry); // Add the entry to the journal
            }
            else if (choice == "2")
            {
                // Display all journal entries
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                journal.SaveToFile(Console.ReadLine());
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename: ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}