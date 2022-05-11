using System;

public class Problem2
{
    List<int> fibonacciNumbers = new List<int>();
    int x = 1;
    int y = 2;
    int finalSum = 0;

    public static void StartProblem()
    {
        Problem2 problem = new Problem2();

        //Add starting number
        problem.fibonacciNumbers.Add(problem.x);

        //Find all Fib numbers
        while (problem.y <= 4000000)
        {
            int sum = problem.x + problem.y;
            problem.fibonacciNumbers.Add(problem.y);

            problem.x = problem.y;
            problem.y = sum;

        }


        //Iterate through list of Fib numbers and add even ones
        foreach (var number in problem.fibonacciNumbers)
        {
            if (number % 2 == 0)
            {
                problem.finalSum += number;
            }
        }

        Console.WriteLine($"The sum of all even fibonacci numbers under 4,000,000 is {problem.finalSum}.");
    }


}


