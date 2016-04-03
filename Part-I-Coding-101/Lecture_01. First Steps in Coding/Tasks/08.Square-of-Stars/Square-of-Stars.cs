using System;

public class SquareOfStars
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        if (n >= 2)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine(new string('*', n));
                }
                else
                {
                    Console.WriteLine("*".PadRight(n - 1, ' ').PadRight(n, '*'));
                }
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}