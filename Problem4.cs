using System;

public class Problem4 : IProblem
{

    //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //Find the largest palindrome made from the product of two 3-digit numbers.

    private int largestPalindromeSoFar = 0;


    public void StartProblem()
    {
        Console.WriteLine("\n\nQuestion 4 reads: A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99. \n\nFind the largest palindrome made from the product of two 3-digit numbers.");
        Console.WriteLine($"\nFinding the largest palindrome made up from 3 digit numbers now...");

        for (int i = 999; i > 99; i--)
        {

            for (int j = i; j > 99; j--)
            {

                int product = i * j;
                if (product < largestPalindromeSoFar)
                {
                    break;
                }
                else
                {
                    string productFrontToBack = product.ToString();
                    string productBackToFront = Reverse(productFrontToBack);


                    if (String.Equals(productFrontToBack, productBackToFront))
                    {
                        largestPalindromeSoFar = product;
                        break;
                    }
                }

            }
        }

        Console.WriteLine($"\n The largest palindrome made from two 3-digit numbers is {largestPalindromeSoFar}.");

        ProblemDecider.Instance?.ResetProblem();

    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

