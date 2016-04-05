using System;
using System.Linq;

/*
 * Fold and Sum
 * 
 * Read an array of 4*k integers, fold it like shown below, and 
 * print the sum of the upper and lower rows (2*k integers)
 */
public class FoldAndSum
{
    private static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

        int k = nums.Count() / 4;

        int[] row1 = nums.Take(k).Reverse().Concat(nums.Skip(3 * k).Reverse()).ToArray();
        int[] row2 = nums.Skip(k).Take(2 * k).ToArray();

        Console.WriteLine(string.Join(" ", row1.Select((x, pos) => x + row2[pos])));
    }
}