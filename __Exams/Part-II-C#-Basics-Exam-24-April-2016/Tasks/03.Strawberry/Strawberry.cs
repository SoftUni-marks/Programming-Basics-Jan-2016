using System;

public class Strawberry
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // 1.
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(string.Format(
                "{0}\\{1}|{2}/{3}",
                new string('-', 2 * i),
                new string('-', n - (2 * i)),
                new string('-', n - (2 * i)),
                new string('-', 2 * i)));
        }

        // 2.
        for (int i = 0; i < n; i += 2)
        {
            Console.WriteLine(string.Format(
                "{0}#{1}.{2}#{3}",
                new string('-', n - i),
                new string('.', i),
                new string('.', i),
                new string('-', n - i)));
        }

        // 3.
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(string.Format(
                "{0}#{1}.{2}#{3}",
                new string('-', i),
                new string('.', n - i),
                new string('.', n - i),
                new string('-', i)));
        }
    }
}
