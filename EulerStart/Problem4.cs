using System;

public class Problem4
{

    //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //Find the largest palindrome made from the product of two 3-digit numbers.

    private int largestPalindromeSoFar = 0;


    public void StartProblem()
    {
        Console.WriteLine("Question 4 reads: A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99. \n Find the largest palindrome made from the product of two 3-digit numbers.");
        Console.WriteLine($"Finding the largest palindrome made up from 3 digit numbers now...");

        for (int i = 999; i > 99; i--)
        {

            for (int j = i; j > 99; j--)
            {

                int product = i * j;
                string productFrontToBack = product.ToString();
                string productBackToFront = Reverse(productFrontToBack);

                Console.WriteLine($"Checking {i} * {j} = {product}!");


                if (String.Equals(productFrontToBack,productBackToFront))
                {
                    if (product > largestPalindromeSoFar)
                    {
                        largestPalindromeSoFar = product;
                        break;
                    }


                }
            }
        }


        Console.WriteLine($"\n The largest palindrome made from two 3-digit numbers is {largestPalindromeSoFar}.");

    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

