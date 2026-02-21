using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("18 Feburary 2026", 30, 3.0));

        activities.Add(new Cycling("19 Feburary 2026", 45, 15.0));

        activities.Add(new Swimming("20 Feburary 2026", 90, 45));
    
        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}