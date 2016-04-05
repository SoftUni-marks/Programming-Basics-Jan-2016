using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Odd Occurrences
 * 
 * Write a program to extracts from a given sequence of words all 
 * elements that present in it odd number of times (case-insensitive)
 *   - Words are given in a single line, space separated
 *   - Print the result elements in lowercase, in their order of appearance
 */
public class OddOccurrences
{
    private static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(str => str.ToLowerInvariant()).ToArray();

        var occurences = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (occurences.ContainsKey(word))
            {
                occurences[word]++;
            }
            else
            {
                occurences[word] = 1;
            }
        }

        Console.WriteLine(string.Join(", ", occurences.Keys.Where(key => occurences[key] % 2 == 1)));
    }
}