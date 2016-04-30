using System;

public class DrawFort
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var cols = 2 * n;
        var rows = n;

        var colsWidth = n / 2;

        var str_row = string.Empty;

        // 1. first row
        Console.WriteLine(
            "/{0}\\{1}/{0}\\",
            new string('^', colsWidth),
            new string('_', cols - (colsWidth + 2) - (colsWidth + 2)));

        // 2. middle rows
        for (int i = 0; i < rows - 3; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', cols - 2));
        }

        // 3. row before last
        Console.WriteLine(
            "|{0}{1}{0}|",
            new string(' ', colsWidth + 1),
            new string('_', cols - (colsWidth + 2) - (colsWidth + 2)));

        // 4. last row
        Console.WriteLine(
            "\\{0}/{1}\\{0}/",
            new string('_', colsWidth),
            new string(' ', cols - (colsWidth + 2) - (colsWidth + 2)));
    }
}
