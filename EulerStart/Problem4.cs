using System;

public class Problem4
{

    //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //Find the largest palindrome made from the product of two 3-digit numbers.

    private int maxNumber;


    public void StartProblem()
    {
        for (int i = 99; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                int product = i * j;
                var productFrontToBack = product.ToString().ToCharArray();
                var productBackToFront = productFrontToBack.Reverse();


                if (productFrontToBack == productBackToFront)
                {
                    Console.WriteLine($"found one! its {productFrontToBack}!");
                    break;
                }
            }
        }

    }
}

