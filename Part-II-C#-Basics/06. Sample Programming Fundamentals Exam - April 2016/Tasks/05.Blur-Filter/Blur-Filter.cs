using System;
using System.Linq;

public class BlurFilter
{
    private static void Main()
    {
        long blurAmount = long.Parse(Console.ReadLine());

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

        // pixel row & col
        int[] pixelRowAndCol = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int pixelRow = pixelRowAndCol[0];
        int pixelCol = pixelRowAndCol[1];

        for (int rowShift = -1; rowShift <= 1; rowShift++)
        {
            int row = pixelRow + rowShift;

            for (int colShift = -1; colShift <= 1; colShift++)
            {
                int col = pixelCol + colShift;

                if (0 <= row & row < rows &
                    0 <= col & col < cols)
                {
                    matrix[row][col] += blurAmount;
                }
            }
        }

        // print result
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", matrix[row]));
        }
    }
}
