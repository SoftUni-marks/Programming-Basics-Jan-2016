using System;
using System.Linq;

public class MultiplyTargetedCell
{
    private static void Main()
    {
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

        // targeted row & col
        int[] targetedRowAndCol = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int targetedRow = targetedRowAndCol[0];
        int targetedCol = targetedRowAndCol[1];

        long sumOfNeighboringCells = 0L;

        // walk through all neighboring cells
        for (int rowShift = -1; rowShift <= 1; rowShift++)
        {
            int row = targetedRow + rowShift;

            for (int colShift = -1; colShift <= 1; colShift++)
            {
                int col = targetedCol + colShift;

                if (0 <= row && row < rows &&
                    0 <= col && col < cols)
                {
                    if (row != targetedRow || col != targetedCol)
                    {
                        sumOfNeighboringCells += matrix[row][col];

                        // Each neighboring cells should be the product of its initial 
                        // value and the initial value of the targeted cell
                        matrix[row][col] *= matrix[targetedRow][targetedCol];
                    }
                }
            }
        }

        // Get a targeted cell and multiply its value with the sum of all neighboring cells
        matrix[targetedRow][targetedCol] *= sumOfNeighboringCells;

        // print result
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", matrix[row]));
        }
    }
}
