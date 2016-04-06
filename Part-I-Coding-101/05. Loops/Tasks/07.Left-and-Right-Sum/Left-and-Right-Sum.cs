using System;

public class LeftAndRightSum
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < 2 * n; i++)
        {
            if (i < n)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            else
            {
                rightSum += int.Parse(Console.ReadLine());
            }
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
        }
    }
}