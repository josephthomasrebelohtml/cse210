using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        DateTime date1 = new DateTime(2026, 10, 01);
        DateTime date2 = new DateTime(2026, 10, 02);
        DateTime date3 = new DateTime(2026, 10, 05);

        Running running = new Running(date1, 30, 4.8);
        activities.Add(running);

        Cycling cycling = new Cycling(date2, 60, 11);
        activities.Add(cycling);

        Swimming swimming = new Swimming(date3, 50, 20);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}