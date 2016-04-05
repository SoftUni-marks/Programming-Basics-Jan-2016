using System;
using System.Linq;

/*
 * Largest 3 Numbers
 * 
 * Read a list of real numbers and print largest 3 of them
 */
public class Largest_3_Numbers
{
    private static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

        var sortedNums = nums.OrderBy(x => -x);
        var largest3Nums = sortedNums.Take(3);

        Console.WriteLine(string.Join(" ", largest3Nums));
    }
}