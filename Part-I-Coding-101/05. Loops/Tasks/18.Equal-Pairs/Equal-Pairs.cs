using System;
using System.Linq;

public class EqualPairs
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int pairSum = 0;
        int prevPairSum = 0;

        int[] pairDiffs = new int[n - 1];

        for (int i = 0; i < n; i++)
        {
            pairSum = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());

            if (i > 0)
            {
                pairDiffs[i - 1] = Math.Abs(pairSum - prevPairSum);
            }

            prevPairSum = pairSum;
        }

        if (pairDiffs.Count() == 0 || pairDiffs.Max() == 0)
        {
            Console.WriteLine("Yes, value={0}", pairSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", pairDiffs.Max());
        }
    }
}