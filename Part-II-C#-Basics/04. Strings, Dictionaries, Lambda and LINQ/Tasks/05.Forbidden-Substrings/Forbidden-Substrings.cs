using System;
using System.Linq;

/*
 * Change Forbidden Substrings
 * 
 * Read a text and several forbidden words
 *   - Replace all forbidden words with stars (e.g. beer -> ****)
 *   - Use "substring" matching (match part of word), case-sensitive
 */
public class ForbiddenSubstrings
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();

        string[] forbiddenWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        foreach (string forbWord in forbiddenWords)
        {
            text = text.Replace(forbWord, new string('*', forbWord.Length));
        }

        Console.WriteLine(text);
    }
}