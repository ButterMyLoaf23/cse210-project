using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you did something you thought was impossible but you still did it.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new()
    {
        "Why was this meaningful?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity()
        : base(
            "Reflection",
            "This Activity will help you with reflecting on your day"
          )
    { }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
    Console.WriteLine($"{prompt}");
    ShowSpinner(5);

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    foreach (string question in _questions)
    {
        if (DateTime.Now >= endTime)
        {
            break;
        }

        Console.WriteLine($"{question}");
        ShowSpinner(5);
    }
}
}