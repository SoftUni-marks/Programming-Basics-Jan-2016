using System;
using System.Collections.Generic;
using System.Linq;

public class OddEvenPosition
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] nums = new double[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = double.Parse(Console.ReadLine());
        }

        List<string> result = new List<string>();

        result.Add(string.Format("OddSum={0}", nums.Where((x, pos) => pos % 2 == 0).Sum()));

        if (n > 0)
        {
            result.Add(string.Format("OddMin={0}", nums.Where((x, pos) => pos % 2 == 0).Min()));
            result.Add(string.Format("OddMax={0}", nums.Where((x, pos) => pos % 2 == 0).Max()));
        }
        else
        {
            result.Add("OddMin=No");
            result.Add("OddMax=No");
        }

        result.Add(string.Format("EvenSum={0}", nums.Where((x, pos) => pos % 2 == 1).Sum()));

        if (n > 1)
        {
            result.Add(string.Format("EvenMin={0}", nums.Where((x, pos) => pos % 2 == 1).Min()));
            result.Add(string.Format("EvenMax={0}", nums.Where((x, pos) => pos % 2 == 1).Max()));
        }
        else
        {
            result.Add("EvenMin=No");
            result.Add("EvenMax=No");
        }

        Console.WriteLine(string.Join(", ", result));
    }
}