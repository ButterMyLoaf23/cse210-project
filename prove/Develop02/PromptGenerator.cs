using System;
using System.Collections.Generic;
using System.ComponentModel;

public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What is one small win I had today?",
        "What is something that I am grateful for today?",
        "What drained my energy today, and what gave me energy today?",
        "What is one thing that I learned today?",
        "What is one goal I moved closer to today?"
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}