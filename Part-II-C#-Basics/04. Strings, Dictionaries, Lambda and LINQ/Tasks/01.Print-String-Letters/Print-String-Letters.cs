using System;

/*
 * Print String Letters
 *
 * Read a string and print its letters
 */
public class PrintStringLetters
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine("str[{0}] -> '{1}'", i, str[i]);
        }
    }
}