using System;

public class OddEvenSum
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += int.Parse(Console.ReadLine());
            }
            else
            {
                oddSum += int.Parse(Console.ReadLine());
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes\r\nSum = {0}", evenSum);
        }
        else
        {
            Console.WriteLine("No\r\nDiff = {0}", Math.Abs(evenSum - oddSum));
        }
    }
}