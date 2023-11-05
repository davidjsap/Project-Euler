using System;

public class ProblemDecider
{
    public static ProblemDecider? Instance {get; private set;}

    public void Initialize()
    {
        Instance = this;
        PromptForProblem();
    }

    private void PromptForProblem()
    {
        Instance = this;
        Console.WriteLine("This program contains the solutions to all Project Euler questions solved thus far by David Saperstein.");
        Console.WriteLine("What problem would you like to get the solution for?");

        int X;
        string? userInput = Console.ReadLine();
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
                Problem1 problem1 = new Problem1();
                problem1.StartProblem();
                break;
            case 2:
                Problem2 problem2 = new Problem2();
                problem2.StartProblem();
                break;
            case 3:
                Problem3 problem3 = new Problem3();
                problem3.StartProblem();
                break;
            case 4:
                Problem4 problem4 = new Problem4();
                problem4.StartProblem();
                break;
            case 5:
                Problem5 problem5 = new Problem5();
                problem5.StartProblem();
                break;
            case 6:
                Problem6 problem6 = new Problem6();
                problem6.StartProblem();
                break;
            case 7:
                Problem7 problem7 = new Problem7();
                problem7.StartProblem();
                break;
            default:
                Console.WriteLine("Entry invalid, please try again.");
                break;
        }

    }

    public void ResetProblem()
    {
        PromptForProblem();
    }
}
