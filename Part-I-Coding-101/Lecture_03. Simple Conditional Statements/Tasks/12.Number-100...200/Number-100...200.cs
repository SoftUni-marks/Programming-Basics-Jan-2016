﻿using System;

public class Number_100__200
{
    private static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        if (num < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (num > 200)
        {
            Console.WriteLine("Greater than 200");
        }
        else
        {
            Console.WriteLine("Between 100 and 200");
        }
    }
}