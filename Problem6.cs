/*

The sum of the squares of the first ten natural numbers is 1² + 2² + … + 10² = 385.

The square of the sum of the first ten natural numbers is (1 + 2 + … + 10)² = 55² = 3025.

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

*/

using System;

public class Problem6 : IProblem
{

    int numToCheckUpTo = 100;

    public void StartProblem()
    {
        int sumPart1 = 0;

        for (int i = 1; i <= numToCheckUpTo; i++)
        {
            sumPart1 += (int)Math.Pow(i,2);
        }

        Console.WriteLine($"The sum of the square of the numbers up to {numToCheckUpTo} is {sumPart1}.");

        int sumPart2 = 0;

        for (int i = 1; i <= numToCheckUpTo; i++)
        {
            sumPart2 += i;
        }

        int sumPart3 = (int)Math.Pow(sumPart2,2);

        Console.WriteLine($"The square of the sum of the numbers up to {numToCheckUpTo} is {sumPart3}.");

        int finalAnswer = sumPart3 - sumPart1;

        Console.WriteLine($"Therefore, the final answer is: {finalAnswer}");

    }



}