using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Count Occurrences in String
 *
 * Read a text and a word and count how many times the word occurs in 
 * the text as substring
 */
public static class OccurrencesInString
{
    /// <summary>
    /// Extension method of String class which returns all indexes of substring we search for
    /// </summary>
    /// <param name="str"></param>
    /// <param name="substr"></param>
    /// <returns></returns>
    public static IEnumerable<int> IndexesOf(this string str, string substr)
    {
        int lastIndex = 0;

        while (true)
        {
            int index = str.IndexOf(substr, lastIndex);

            if (index == -1)
            {
                yield break;
            }

            yield return index;

            lastIndex = index + 1;
        }
    }

    private static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();

        // int count = 0;
        // int pos = 0;
           
        // while (true)
        // {
        //     pos = text.IndexOf(word, pos);
        // 
        //     if (pos == -1)
        //     {
        //         break;
        //     }
        // 
        //     count++;
        //     pos += 1;
        // }

        // Console.WriteLine("{0}", count);
        Console.WriteLine("{0}", text.IndexesOf(word).Count());
    }
}