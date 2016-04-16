using System;
using System.Collections.Generic;
using System.Linq;

public class HogwartsSorting
{
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

    private static void Main()
    {
        string[] housesNames = new string[4]
        {
                "Gryffindor",
                "Slytherin",
                "Ravenclaw",
                "Hufflepuff",
        };

        // 0 -> Gryffindor, 1 -> Slytherin, 2 -> Ravenclaw, 3 -> Hufflepuff
        int[] studentsPerHouse = new int[4];

        // number of newcomers
        int n = int.Parse(Console.ReadLine());

        List<string> result = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string student = Console.ReadLine();

            string[] studentNames = student
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string studentInitials = string.Empty + studentNames[0][0] + studentNames[1][0];

            int studentNumber = GetStudentNumber(student);

            int houseNumber = studentNumber % 4;

            string house = housesNames[houseNumber];

            studentsPerHouse[houseNumber] += 1;

            result.Add(house + " " + studentNumber + studentInitials);
        }

        Console.WriteLine(string.Join("\r\n", result));
        Console.WriteLine();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("{0}: {1}", housesNames[i], studentsPerHouse[i]);
        }
    }
}
