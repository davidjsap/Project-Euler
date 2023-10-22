/*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

using System;

public class Problem5 : IProblem
{
    private bool numberFound = false;
    int maxNumber = 10;
	int smallestNumberThatSatisfies;

    public void StartProblem()
    {
        Console.WriteLine($"Finding smallest positive number that is evenly divisible by numbers from 1 to {maxNumber}...");
		
        int i = 1;
        while (numberFound == false)
        {
            Console.WriteLine($"Trying number {i}");

		    for (int j = 1; j < maxNumber + 1; j++)
            {
				if (i % j != 0)
				{
					break;
				}
					
                
				
				if (j == maxNumber)
				{
					smallestNumberThatSatisfies = i;
					Console.WriteLine("Found smallest number to satisfy: " + smallestNumberThatSatisfies);
					numberFound=true;
				}
            }
			
            i++;
        }

        Console.WriteLine($"The smallest positive number that is evenly divisible by numbers from 1 to {maxNumber} is {smallestNumberThatSatisfies}.");

        ProblemDecider.Instance?.ResetProblem();

    }

}

