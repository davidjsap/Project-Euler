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


