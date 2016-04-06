using System;

public class NumbersEndingIn_7
{
    private static void Main()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}