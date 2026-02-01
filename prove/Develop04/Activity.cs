using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter how long you want to spend in this activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        RunActivity();

        End();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected void End()
    {
        Console.WriteLine("Good job");
        ShowSpinner(3);
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3);

        Console.WriteLine("Press Enter to continue. ");
        Console.ReadLine();
    }


    protected abstract void RunActivity();
}