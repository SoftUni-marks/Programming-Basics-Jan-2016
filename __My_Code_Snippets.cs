
int n = int.Parse(Console.ReadLine());

int[] rowsAndCols = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = rowsAndCols[0];
int cols = rowsAndCols[1];

long[][] matrix = new long[rows][];

// fill matrix
for (int row = 0; row < rows; row++)
{
    matrix[row] = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Take(cols)
        .Select(long.Parse)
        .ToArray();
}

//==============================================================================

private static int SumOfDiditsAtEvenPosition(string numStr, int numStrLength)
{
    int sum = 0;

    for (int i = 0; i < numStrLength; i += 2)
    {
        sum += numStr[i] - '0';
    }

    return sum;
}

private static int LongestLengthOfCharSequence(string str, char ch)
{
    int longestLen = 0;

    int i = 0;
    while (i < str.Length)
    {
        if (str[i] == ch)
        {
            int tmpLen = 1;

            i++;

            while (i < str.Length && str[i] == ch)
            {
                tmpLen++;
                i++;
            }

            longestLen = Math.Max(longestLen, tmpLen);
        }
        else
        {
            i++;
        }
    }

    return longestLen;
}

private static uint Pow(uint num, uint degree)
{
    uint result = 1;

    for (uint i = 0; i < degree; i++)
    {
        result *= num;
    }

    return result;
}

private static uint GetDecimalNumber(string str, uint baseNum)
{
    uint number = 0;

    for (int i = str.Length - 1; i >= 0; i--)
    {
        // 23-based digit
        uint digit = (uint)(str[i] - 'a');

        number += digit * Pow(baseNum, (uint)((str.Length - 1) - i));
    }

    return number;
}

private static string GetStringFromDecimalNumber(ulong num, uint baseNum)
{
    List<char> chars = new List<char>();

    if (num == 0UL)
    {
        return "a";
    }
    else
    {
        while (num > 0)
        {
            chars.Add((char)((int)(num % 23) + 'a'));

            num /= baseNum;
        }

        chars.Reverse();

        return new string(chars.ToArray());
    }
}

public static int GetStudentNumber(string student)
{
    int number = 0;

    for (int i = 0; i < student.Length; i++)
    {
        if (student[i] != ' ')
        {
            number += (int)student[i];
        }
    }

    return number;
}