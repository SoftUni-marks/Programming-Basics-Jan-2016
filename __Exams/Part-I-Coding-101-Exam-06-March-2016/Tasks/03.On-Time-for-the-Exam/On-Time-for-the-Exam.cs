using System;

public class OnTimeForTheExam
{
    private static void Main()
    {
        var examHour = int.Parse(Console.ReadLine());
        var examMinute = int.Parse(Console.ReadLine());

        var arriveHour = int.Parse(Console.ReadLine());
        var arriveMinute = int.Parse(Console.ReadLine());

        var examTime = (examHour * 60) + examMinute;
        var arriveTime = (arriveHour * 60) + arriveMinute;

        var diff = examTime - arriveTime;

        if (diff < 0)
        {
            Console.WriteLine("Late");
        }
        else if (0 <= diff && diff <= 30)
        {
            Console.WriteLine("On time");
        }
        else if (30 < diff)
        {
            Console.WriteLine("Early");
        }

        if (diff <= -60)
        {
            Console.WriteLine("{0}:{1:D2} hours after the start", -diff / 60, -diff % 60);
        }
        else if (-60 < diff && diff < 0)
        {
            Console.WriteLine("{0} minutes after the start", -diff);
        }
        else if (0 < diff && diff < 60)
        {
            Console.WriteLine("{0} minutes before the start", diff);
        }
        else
        {
            Console.WriteLine("{0}:{1:D2} hours before the start", diff / 60, diff % 60);
        }
    }
}
