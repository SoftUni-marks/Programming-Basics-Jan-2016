using System;
using System.Linq;

public class VowelsSum
{
    private static void Main(string[] args)
    {
        string vowels = "aeiou";

        string text = Console.ReadLine();

        int vowelsSum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (vowels.Contains(text[i]))
            {
                vowelsSum += vowels.IndexOf(text[i]) + 1;
            }
        }

        Console.WriteLine(vowelsSum);
    }
}