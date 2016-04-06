using System;
using System.Linq;

public class MinNumber
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(nums.Min());
    }
}