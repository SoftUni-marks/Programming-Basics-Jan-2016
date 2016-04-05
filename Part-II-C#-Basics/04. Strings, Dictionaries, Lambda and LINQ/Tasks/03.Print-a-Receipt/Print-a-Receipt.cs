using System;
using System.Linq;

/*
 * Print a Receipt
 *
 * Read a sequence of numbers and print a receipt of width 24 chars
 */
public class PrintReceipt
{
    private static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        Console.WriteLine(@"/----------------------\");

        foreach (var num in nums)
        {
            Console.WriteLine("| {0,20:F2} |", num);
        }

        Console.WriteLine(@"|----------------------|");
        Console.WriteLine(@"| Total:{0, 14:F2} |", nums.Sum());
        Console.WriteLine(@"\----------------------/");
    }
}