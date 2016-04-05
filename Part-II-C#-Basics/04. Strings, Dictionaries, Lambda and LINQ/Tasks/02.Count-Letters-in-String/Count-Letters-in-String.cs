using System;
using System.Linq;

/*
 * Count Letters in String
 *
 * Read a string and count how many times each character occurs
 *   - Print all chars (case insensitive) alphabetically with their counts
 */
public class CountLettersInString
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine().ToLower();

        foreach (var ch in str.Distinct().OrderBy(c => c))
        {
            Console.WriteLine("{0} -> {1}", ch, str.Where(c => c == ch).Count());
        }
    }
}