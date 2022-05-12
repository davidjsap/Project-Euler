using System;

public class Problem3
{

    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?


    private int maxNumber = 13195;
    private List<int> allFactors = new List<int>();

    public void StartProblem()
    {
        for (int i = 1; i < maxNumber + 1; i++) //iterate through ever number up to maxNumber
        {
            if (maxNumber % i == 0) // get list of all factors
            {
                allFactors.Add(i);
            }
        }

        Console.WriteLine(allFactors);
        

    }
}

