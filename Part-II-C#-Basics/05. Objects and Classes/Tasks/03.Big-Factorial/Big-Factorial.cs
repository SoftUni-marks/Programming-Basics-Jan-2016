using System;
using System.Numerics;

/*
 * Calculate n! (n factorial) for very big n (e.g. 1000)
 */
public class BigFactorial
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);
    }
}