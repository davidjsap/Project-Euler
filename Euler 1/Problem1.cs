using System;

public class Problem1
{
    private int maximumNumber = 10;
    private int sumTotal = 0;
    private List<int> listOfMultiples = new List<int>();
    
    public static void StartProblem()
    {
        Problem1 problem = new Problem1();


        //Start program, prompt user for maximum.
        Console.WriteLine("This program finds all the multiples of 3 or 5 below a given number and adds them up.");
        Console.WriteLine("What number do you want to choose as the maximum?");

        //Check to make sure an int was entered and make it the maximum number.
        int X;
        String userInput = Console.ReadLine();
        while (!Int32.TryParse(userInput, out X))
        {
            Console.WriteLine("Please try again, making sure you've entered a valid integer.");

            userInput = Console.ReadLine();
        }

        problem.maximumNumber = int.Parse(userInput);
        Console.WriteLine($"Ok. Finding all multiples of 3 or 5 up to {problem.maximumNumber}.");

        //Add multiples that satisfy conditions to list
        problem.FindMultiples();

        Console.WriteLine($"There were {problem.listOfMultiples.Count} unique multiples found.");
        Console.WriteLine("Adding them up...");

        //Add up all the multiples
        foreach (var multiple in problem.listOfMultiples)
        {
            problem.sumTotal += multiple;
        }

        Console.WriteLine($"The sum total of the {problem.listOfMultiples.Count} multiples is {problem.sumTotal}!");

    }

    private void FindMultiples()
    {
        for (int i = 1; i < maximumNumber; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                listOfMultiples.Add(i);
            }
        }
    }

    public static void Main()
    {

    }
}