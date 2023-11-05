namespace MathUtilities
{
    public static class MathLibrary
    {
        public static bool IsPrime(int n)
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
    }

}