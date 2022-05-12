using System;

public class Problem3
{

    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?


    private int maxNumber = 13195;
    private List<int> allFactors = new List<int>();
    private List<int> primeFactors = new List<int>();

    public void StartProblem()
    {

        Console.WriteLine("For what number do you want to find the largest prime factor?");

        //Check to make sure an int was entered and make it the maximum number.
        int X;
        string? userInput = Console.ReadLine();
        while (!Int32.TryParse(userInput, out X))
        {
            Console.WriteLine("Please try again, making sure you've entered a valid integer.");

            userInput = Console.ReadLine();
        }

        maxNumber = int.Parse(userInput);
        Console.WriteLine($"Ok. Finding largest prime factor of the number {maxNumber}.");

        for (int i = 1; i < maxNumber + 1; i++) //iterate through ever number up to maxNumber
        {
            if (maxNumber % i == 0) // get list of all factors
            {
                if (i != 1)
                {
                    allFactors.Add(i);
                }

            }
        }

        Console.WriteLine("The following factors were found: ");
        Console.WriteLine(string.Join("\t", allFactors));

        for (int i = 0; i < allFactors.Count; i++) // iterate through each factor
        {
            if (i == 0)
            {
                primeFactors.Add(allFactors[i]);
            }
            else
            {
                for (int j = 0; j <= i; j++) //iterate through each factor infront of this factor to check if any are divisible into it
                {
                    if (allFactors[i] == allFactors[j])
                    {
                        //I have gotten to myself in the list without any factors, so I am a prime factor
                        primeFactors.Add(allFactors[i]);

                    }
                    else if (allFactors[i] % allFactors[j] == 0)
                    {
                        //if I hit a number that gives me a remainder of 0, Im not a prime factor, don't add
                        break;
                    }
                }
            }
        }

        Console.WriteLine("Of these, the following prime factors were found: ");
        Console.WriteLine(string.Join("\t", primeFactors));
        Console.WriteLine($"The largest prime factor is: {primeFactors[primeFactors.Count - 1]}.");

    }
}

