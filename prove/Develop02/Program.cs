using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine ("\nJournal");
            Console.WriteLine("1). Write a new entry");
            Console.WriteLine("2). Display journal");
            Console.WriteLine("3). Save entry");
            Console.WriteLine("4). Load entry");
            Console.WriteLine("5). Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string save = Console.ReadLine();
                    journal.SaveToFile(save);
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string load = Console.ReadLine();

                    try
                    {
                        journal.LoadFromFile(load);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error loading file");
                    }
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    static void NewEntry (Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();
        string category = ChooseCategory();
        string date = DateTime.Now.ToShortDateString();
        Entry entry = new Entry(date, prompt, response, category);

        journal.AddEntry(entry);
        Console.WriteLine("Entry added");
    }

// ChooseCategory class is my own design on add a category to each prompt so you can see what category you listed it as. When you save and load the file, it will show the category when you display the journal entries.
    static string ChooseCategory()
    {
        Console.WriteLine("\nChoose a category: ");
        Console.WriteLine("1). School");
        Console.WriteLine("2). Family");
        Console.WriteLine("3). Spiritual");
        Console.WriteLine("4). Work");
        Console.WriteLine("5). Health");
        Console.WriteLine("6). Other");
        Console.Write("Category (1-6): ");

        string choice = Console.ReadLine();

        return choice switch
        {
            "1" => "School",
            "2" => "Family",
            "3" => "Spiritual",
            "4" => "Work",
            "5" => "Health",
            "6" => "Other",
            _ => "Other"
        };
    }
}