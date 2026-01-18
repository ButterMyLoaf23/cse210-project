using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;
    public string Category;

    public Entry(string date, string prompt, string response, string category)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }
}