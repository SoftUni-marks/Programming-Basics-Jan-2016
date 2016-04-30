using System;

public class StupidPasswordGenerator
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());

        string result = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (int k = 0; k < l; k++)
                {
                    for (int m = 0; m < l; m++)
                    {
                        for (int p = 1; p <= n; p++)
                        {
                            if (p > i && p > j)
                            {
                                result += string.Format("{0}{1}{2}{3}{4} ", i, j, (char)(k + 97), (char)(m + 97), p);
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(result);
    }
}
