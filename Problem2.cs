﻿/*
    Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    1, 2, 3, 5, 8, 13, 21, 34, 55, 89,...
    By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
*/

using System;

public class Problem2 : IProblem
{
    List<int> fibonacciNumbers = new List<int>();
    int x = 1;
    int y = 2;
    int finalSum = 0;

    public void StartProblem()
    {
        //Add starting number
        fibonacciNumbers.Add(x);

        //Find all Fib numbers
        while (y <= 4000000)
        {
            int sum = x + y;
            fibonacciNumbers.Add(y);

            x = y;
            y = sum;

        }


        //Iterate through list of Fib numbers and add even ones
        foreach (var number in fibonacciNumbers)
        {
            if (number % 2 == 0)
            {
                finalSum += number;
            }
        }

        Console.WriteLine($"The sum of all even fibonacci numbers under 4,000,000 is {finalSum}.");

        ProblemDecider.Instance?.ResetProblem();
    }


}


