using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = numSquared(number);
        DisplaySalutation(name, numberSquared);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int numSquared(int number)
    {
        return number * number;
    }
    
    static void DisplaySalutation(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
    }
}