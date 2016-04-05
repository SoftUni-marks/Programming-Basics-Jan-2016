using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Short Words Sorted
 * 
 * Read a text, extract its words, find all short words (less than 
 * 5 characters) and print them alphabetically, in lower case
 *   - Use the following separators: . , : ; ( ) [ ] " ' ! ? (space)
 *   - Use case-insensitive matching
 *   - Remove duplicated words 
 */
public class ShortWordsSorted
{
    private static void Main(string[] args)
    {
        char[] separators = ".,:;()[]\"'!? ".ToCharArray();

        var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var result = words
            .Where(w => w.Length < 5)
            .Distinct(StringComparer.CurrentCultureIgnoreCase)
            .Select(w => w.ToLowerInvariant())
            .OrderBy(w => w);

        Console.WriteLine(string.Join(", ", result));
    }
}