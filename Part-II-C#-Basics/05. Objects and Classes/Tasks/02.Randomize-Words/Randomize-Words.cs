using System;
using System.Collections.Generic;
using System.Linq;

/*
 * You are given a list of words
 *   - Randomize their order and print each word at a separate line
 */
public class RandomizeWords
{
    private static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        Random rnd = new Random();

        int countWords = words.Length;
        List<int> randomIndexesOfWords = new List<int>();

        while (countWords > 0)
        {
            int idx = rnd.Next(0, words.Length);

            if (!randomIndexesOfWords.Contains(idx))
            {
                randomIndexesOfWords.Add(idx);

                countWords--;
            }
        }

        Console.WriteLine(string.Join("\r\n", randomIndexesOfWords.Select(idx => words[idx])));
    }
}