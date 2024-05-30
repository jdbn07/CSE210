using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create activities
        Running running = new Running(new DateTime(2023, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2023, 11, 4), 45, 15.0);
        Swimming swimming = new Swimming(new DateTime(2023, 11, 5), 60, 40);

        // Store the activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}