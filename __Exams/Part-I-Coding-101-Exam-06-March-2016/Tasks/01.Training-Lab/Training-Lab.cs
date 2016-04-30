using System;

public class TrainingLab
{
    private static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        int cols = (int)(((height * 100) - 100) / 70);
        int rows = (int)((width * 100) / 120);

        int places = (cols * rows) - 3;

        Console.WriteLine(places);
    }
}
