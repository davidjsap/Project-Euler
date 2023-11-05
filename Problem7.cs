/*

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10,001st prime number?

*/

using System;
using MathUtilities;

public class Problem7 : IProblem
{
    private int numberOfPrimesFound = 0;
    private List<int> listOfPrimesFound = new List<int>();

    public void StartProblem()
    {
        int i = 0;

        while (numberOfPrimesFound < 10001)
        {
            if (MathLibrary.IsPrime(i))
            {
                numberOfPrimesFound++;
                listOfPrimesFound.Add(i);
            }

            i++;
        }

        int finalPrime = listOfPrimesFound[listOfPrimesFound.Count - 1];
        Console.WriteLine($"The 10,001 prime number is: {finalPrime}.");

    }



}