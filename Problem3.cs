using System;
using System.Numerics;

public class Problem3 : IProblem
{

    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?


    private BigInteger maxNumber = new BigInteger(600851475143);
    private BigInteger smallestFactor = 1;
    private BigInteger runningRemainder = 100;

    public void StartProblem()
    {
        Console.WriteLine($"Finding largest prime factor of the number {maxNumber}.");

        while (runningRemainder != 1)
        {
            //Console.WriteLine($"The remainder is still not 1, trying again.");
            for (int i = 2; i <= maxNumber; i++)
            {
                //Console.WriteLine($"Comparing maxNumber of {maxNumber} with i of {i}.");
                if (maxNumber % i == 0)
                {
                    smallestFactor = i;
                    break;
                }
            }

            runningRemainder = maxNumber / smallestFactor;

            if (runningRemainder != 1)
            {
                maxNumber /= smallestFactor;
            }

        }

        Console.WriteLine($"The largest prime number is {maxNumber}.");

        ProblemDecider.Instance?.ResetProblem();

    }
}

