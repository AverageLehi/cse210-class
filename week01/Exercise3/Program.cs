using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int userNumber = 0;
        bool isValidInput = false;
        int attempts = 0;
        string stopLoop = "no";
        do 
        {
            Console.WriteLine("What is the magic number? ");
            string input = Console.ReadLine();
            isValidInput = int.TryParse(input, out userNumber);

            if (!isValidInput)
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed the magic number!");
                Console.WriteLine($"It took you {attempts} attempts.");
                Console.WriteLine("Do you want to stop the game? (yes/no)");
                stopLoop = Console.ReadLine();

                if (stopLoop == "yes")
                {
                    break;
                }
                else
                {
                    magicNumber = randomGenerator.Next(1, 11);
                    attempts = 0;
                }
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                attempts++;
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                attempts++;
            }
        } while (userNumber != magicNumber);
    }
}