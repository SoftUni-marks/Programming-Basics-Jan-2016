using System;
using System.Linq;

public class HalfSumElement
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int diff = Math.Abs(nums.Sum() - (2 * nums.Max()));

        if (diff == 0)
        {
            Console.WriteLine("Yes\r\nSum = {0}", nums.Max());
        }
        else
        {
            Console.WriteLine("No\r\nDiff = {0}", diff);
        }
    }
}