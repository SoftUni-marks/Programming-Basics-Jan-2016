using System;

public class _2D_RectangleArea
{
    private static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());

        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        var sideX = Math.Abs(x1 - x2);
        var sideY = Math.Abs(y1 - y2);

        var area = sideX * sideY;
        var perimeter = 2 * (sideX + sideY);

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}