using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Count Real Numbers
 * 
 * Read a list of real numbers and print them in ascending 
 * order along with their number of occurrences
 */
public class CountRealNumbers
{
    private static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        var counts = new SortedDictionary<double, int>();

        foreach (var num in numbers)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        foreach (var num in counts.Keys)
        {
            Console.WriteLine("{0} -> {1} times", num, counts[num]);
        }
    }
}