using System;

public class TrapeziodArea
{
    private static void Main(string[] args)
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        var trapeziodArea = ((a + b) * h) / 2.0;

        Console.WriteLine("Trapeziod area = " + trapeziodArea);
    }
}