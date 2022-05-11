using System;

public class ProgramStart
{
    static void Main()
    {
        Console.WriteLine("This program contains the solutions to all Project Euler questions solved thus far by David Saperstein.");
        Console.WriteLine("What problem would you like to get the solution for?");

        int X;
        String userInput = Console.ReadLine();
        while (!Int32.TryParse(userInput, out X))
        {
            Console.WriteLine("Please try again, making sure you've entered a valid integer.");

            userInput = Console.ReadLine();
        }

        int solutionNumber = int.Parse(userInput);
        Console.WriteLine($"Going to problem {solutionNumber}.");

        switch (solutionNumber)
        {
            case 1:
                Console.WriteLine("you chose 1");
                break;
            case 2:
                Console.WriteLine("you chose 2");
                break;
            default:
                Console.WriteLine();
                break;
        }

    }
}
