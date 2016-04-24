using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayModifier
{
    private static void Main()
    {
        List<long> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        while (true)
        {
            string[] commands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            string command = commands[0];

            if (command == "end")
            {
                break;
            }
            else if (command == "decrease")
            {
                numbers = numbers.Select(num => num - 1).ToList();
            }
            else
            {
                int idx1 = int.Parse(commands[1]);
                int idx2 = int.Parse(commands[2]);

                if (command == "swap")
                {
                    // swap
                    numbers[idx1] ^= numbers[idx2];
                    numbers[idx2] ^= numbers[idx1];
                    numbers[idx1] ^= numbers[idx2];
                }
                else if (command == "multiply")
                {
                    numbers[idx1] *= numbers[idx2];
                }
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}
