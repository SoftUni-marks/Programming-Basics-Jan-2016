using System;

public class SquareArea
{
    private static void Main(string[] args)
    {
        Console.Write("Въведете дължината на страната на квадрата: a = ");

        var a = double.Parse(Console.ReadLine());

        var area = a * a;

        Console.WriteLine("Лицето на квадрата е = " + area);
    }
}