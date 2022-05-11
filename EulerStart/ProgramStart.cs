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
                Problem1.StartProblem();
                break;
            case 2:
                Problem2.StartProblem();
                break;
            default:
                Console.WriteLine("Entry invalid, please try again.");
                break;
        }

    }
}
