/*
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.
*/

using System;

public class Problem1 : IProblem
{
    private int maximumNumber = 10;
    private int sumTotal = 0;
    private List<int> listOfMultiples = new List<int>();
    
    public void StartProblem()
    {
        //Start program, prompt user for maximum.
        Console.WriteLine("This program finds all the multiples of 3 or 5 below a given number and adds them up.");
        Console.WriteLine("What number do you want to choose as the maximum?");

        //Check to make sure an int was entered and make it the maximum number.
        int X;
        string? userInput = Console.ReadLine();
        while (!Int32.TryParse(userInput, out X))
        {
            Console.WriteLine("Please try again, making sure you've entered a valid integer.");

            userInput = Console.ReadLine();
        }

        maximumNumber = int.Parse(userInput);
        Console.WriteLine($"Ok. Finding all multiples of 3 or 5 up to {maximumNumber}.");

        //Add multiples that satisfy conditions to list
        FindMultiples();

        Console.WriteLine($"There were {listOfMultiples.Count} unique multiples found. Nice!");
        Console.WriteLine("Adding them up...");

        //Add up all the multiples
        foreach (var multiple in listOfMultiples)
        {
            sumTotal += multiple;
        }

        Console.WriteLine($"The sum total of the {listOfMultiples.Count} multiples is {sumTotal}!");

        ProblemDecider.Instance?.ResetProblem();

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
}