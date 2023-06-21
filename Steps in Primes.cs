using System;

public class StepInPrimes
{
    public static long[] Step(int g, long m, long n)
    {
        for (long i = m; i <= n - g; i++)
        {
            if (IsPrime(i) && IsPrime(i + g))
                return new long[] { i, i + g };
        }

        return null;
    }

    private static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;

        if (number == 2 || number == 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (long i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
}
