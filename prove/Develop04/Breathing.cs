using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly."
          )
    { }

    protected override void RunActivity()
    {
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4);
            elapsed += 4;

            Console.Write("\nBreathe out...");
            ShowCountdown(6);
            elapsed += 6;
        }
    }
}