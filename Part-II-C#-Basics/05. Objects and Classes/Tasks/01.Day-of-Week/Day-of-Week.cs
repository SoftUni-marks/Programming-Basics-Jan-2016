using System;
using System.Globalization;
using System.Linq;

/*
 * You are given a date in format day-month-year
 *   - Calculate and print the day of week in English
 */
public class DayOfWeek
{
    private static void Main()
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

        // Console.WriteLine(string.Join(string.Empty, string.Format(new CultureInfo("bg-BG"), "{0:dddd}", date).Select((ch, pos) => pos == 0 ? char.ToUpper(ch) : ch)));
        Console.WriteLine("{0}", date.DayOfWeek);
    }
}