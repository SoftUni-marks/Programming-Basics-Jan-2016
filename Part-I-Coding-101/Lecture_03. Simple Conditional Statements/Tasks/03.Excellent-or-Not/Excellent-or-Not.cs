﻿using System;

public class ExcellentOrNot
{
    private static void Main(string[] args)
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}