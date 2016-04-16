using System;

public class DressPattern
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int horizontalWidth = 3 * n;
        int totalWidth = (12 * n) + 2;

        int totalWidthDiv3 = (totalWidth - 2) / 3;

        // print 0-th part
        Console.WriteLine(
            (new string('_', (totalWidth - 2) / 3)) + "." +
            (new string('_', (totalWidth - 2) / 3)) + "." +
            (new string('_', (totalWidth - 2) / 3)));

        // print 1-st part
        for (int i = 0; i < 2 * n; i++)
        {
            int underscoreLength = totalWidthDiv3 - (2 * (i + 1));

            Console.Write(new string('_', underscoreLength));
            Console.Write(".");
            Console.Write(new string('*', totalWidthDiv3 - underscoreLength - 1));

            Console.Write("*");

            Console.Write(new string('*', (totalWidthDiv3 - underscoreLength - 2) / 2));
            Console.Write(".");
            Console.Write(new string('_', underscoreLength));
            Console.Write(".");
            Console.Write(new string('*', (totalWidthDiv3 - underscoreLength - 2) / 2));

            Console.Write("*");

            Console.Write(new string('*', totalWidthDiv3 - underscoreLength - 1));
            Console.Write(".");
            Console.Write(new string('_', underscoreLength));

            Console.WriteLine();
        }

        // print 2-nd part
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("." + (new string('*', totalWidth - 2)) + ".");
        }

        // print 3-rd part
        Console.WriteLine(
            (new string('.', horizontalWidth)) +
            (new string('*', totalWidth - (2 * horizontalWidth))) +
            (new string('.', horizontalWidth)));

        // print 4-th part (belt)
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                (new string('_', horizontalWidth)) +
                (new string('o', totalWidth - (2 * horizontalWidth))) +
                (new string('_', horizontalWidth)));
        }

        // print 5-th part
        for (int i = 0; i < 3 * n; i++)
        {
            Console.WriteLine(
                (new string('_', horizontalWidth - i)) +
                "." +
                (new string('*', totalWidth - (2 * horizontalWidth) - 2 + (2 * i))) +
                "." +
                (new string('_', horizontalWidth - i)));
        }

        // print 6-th part
        Console.WriteLine(new string('.', totalWidth));
    }
}
