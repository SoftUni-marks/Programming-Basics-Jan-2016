using System;

public class Histogram
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var countP1 = 0;
        var countP2 = 0;
        var countP3 = 0;
        var countP4 = 0;
        var countP5 = 0;

        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                countP1++;
            }
            else if (200 <= num && num <= 399)
            {
                countP2++;
            }
            else if (400 <= num && num <= 599)
            {
                countP3++;
            }
            else if (600 <= num && num <= 799)
            {
                countP4++;
            }
            else
            {
                // 800 <= num
                countP5++;
            }
        }

        Console.WriteLine("{0:F2}", (countP1 / (double)n) * 100);
        Console.WriteLine("{0:F2}", (countP2 / (double)n) * 100);
        Console.WriteLine("{0:F2}", (countP3 / (double)n) * 100);
        Console.WriteLine("{0:F2}", (countP4 / (double)n) * 100);
        Console.WriteLine("{0:F2}", (countP5 / (double)n) * 100);
    }
}
