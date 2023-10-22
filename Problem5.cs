/*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

using System;

public class Problem5 : IProblem
{
    int maxNumber = 20;
    List<List<int>> listOfLists = new List<List<int>>();

    public void StartProblem()
    {
        Console.WriteLine($"Finding smallest positive number that is evenly divisible by numbers from 1 to {maxNumber}...");
		
        // First, get all prime numbers below maxNumber
        Console.WriteLine($"First, getting all prime numbers below {maxNumber}...");

        List<int> primeNumbersBelowMaxNumber = new List<int>();
        for (int i = 1; i < maxNumber; i++)
        {
            if (IsPrime(i))
            {
                primeNumbersBelowMaxNumber.Add(i);
            }
        }

        Console.WriteLine($"The prime numbers below {maxNumber} are: ");
        foreach (var item in primeNumbersBelowMaxNumber)
        {
            Console.Write(item);
        }
        Console.WriteLine("\n");

        // Second, find the prime factorization of each term and make a list of all the factorizations
        Console.WriteLine($"Second, getting the prime factorization for each number between 1 and {maxNumber}...");

        for (int i = 1; i <= maxNumber; i++)
        {
            List<int> primeFactors = new List<int>();
		    primeFactors = PrimeFactors(i);
            foreach (var item in primeFactors)
            {
                Console.Write(item);
            }
            listOfLists.Add(primeFactors);
            Console.WriteLine("\n");

        }

        // Finally, find the max number of appearances of each prime and use that as the exponential
        Console.WriteLine("Finally, find the max number of appearances of each prime and use that as the exponential");

        List<int> listOfExponentials = new List<int>();

        foreach (var primeNumber in primeNumbersBelowMaxNumber)
        {
            int numOfAppearancesOfThisPrime = 0;

            foreach (var list in listOfLists)
            {
                int numAppearancesForThisList = 0;
                foreach (var item in list)
                {
                    if ((decimal)primeNumber / item == 1)
                    {
                        numAppearancesForThisList += 1;
                    }
                }

                if (numAppearancesForThisList > numOfAppearancesOfThisPrime)
                {
                    numOfAppearancesOfThisPrime = numAppearancesForThisList;
                }
            }

            //Console.WriteLine($"The number of {primeNumber}'s is {numOfAppearancesOfThisPrime}.");
            listOfExponentials.Add(numOfAppearancesOfThisPrime);
        }

        int finalNumber = 1;
        for (int i = 0; i < primeNumbersBelowMaxNumber.Count; i++)
        {
            int result = (int)Math.Pow(primeNumbersBelowMaxNumber[i], listOfExponentials[i]);
            //Console.WriteLine($"The number {primeNumbersBelowMaxNumber[i]} raised to the power of {listOfExponentials[i]} = {result}.");
            finalNumber *= result;
        }

        Console.WriteLine($"The answer is: {finalNumber}.");
        

    }

    private bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

 
        // Check from 2 to sqrt(n)
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }

        }

        return true;
    }

    static List<int> PrimeFactors(int n)
	{
		// Create an empty list to store the prime factors
		List<int> factors = new List<int>();

		// Handle the case when n is zero or one
		if (n <= 1) return factors;

		// Divide n by 2 as long as possible and add 2 to the list
		while (n % 2 == 0)
		{
			factors.Add(2);
			n = n / 2;
		}

		// Loop from 3 to the square root of n with a step of 2
		for (int i = 3; i <= Math.Sqrt(n); i += 2)
		{
			// Divide n by i as long as possible and add i to the list
			while (n % i == 0)
			{
				factors.Add(i);
				n = n / i;
			}
		}

		// If n is still greater than 2, it means it is a prime number and add it to the list
		if (n > 2) factors.Add(n);

		// Return the list of prime factors
		return factors;
	}

}

