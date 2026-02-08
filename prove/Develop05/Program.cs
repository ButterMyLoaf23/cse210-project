using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine();
            Console.WriteLine("1). Create Goal");
            Console.WriteLine("2). List Goals");
            Console.WriteLine("3). Record Event");
            Console.WriteLine("4). Save Goals");
            Console.WriteLine("5). Load Goals");
            Console.WriteLine("6). Quit");

            Console.WriteLine();
            Console.Write("Select choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;

                case "2":
                    ListGoals(goals);
                    break;

                case "3":
                    RecordGoals(goals, ref score);
                    break;

                case "4":
                    SaveGoals(goals, score);
                    break;

                case "5":
                    LoadGoals(goals, ref score);
                    break;

                case "6":
                    return;
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("Select your goal type:");
        Console.WriteLine();
        Console.WriteLine("1). Simple Goal");
        Console.WriteLine("2). Eternal Goal");
        Console.WriteLine("3). CheckList Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            Console.WriteLine();

            goals.Add(new  ChecklistGoal(name, description, points, target, bonus));
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Goals:");
        Console.WriteLine();

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }

        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    static void RecordGoals(List<Goal> goals, ref int score)
    {
        ListGoals(goals);

        Console.Write("Which goal did you complete? ");
        Console.WriteLine();
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = goals[index].RecordEvent();
        score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    static void SaveGoals(List<Goal> goals, int score)
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);

            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        
        Console.WriteLine("Goal was saved!");
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }

    static void LoadGoals(List<Goal> goals, ref int score)
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        goals.Clear();
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (parts[0] == "EternalGoal")
            {
                goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
    }
}