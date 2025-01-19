using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber;
        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else 
            {
                break;
            }

        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Count;

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The sum of the numbers is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest numbers is: {largest}.");
    }
}