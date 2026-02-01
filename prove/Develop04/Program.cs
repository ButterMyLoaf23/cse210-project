using System;

// I created a counting function that counts how many activities you did while running the program and gives you a summary of it when you quit the program.
class Program
{
    static void Main()
    {
        bool running = true;

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an option: ");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity != null)
            {
                activity.Start();

                if (activity is BreathingActivity) breathingCount++;
                if (activity is ReflectionActivity) reflectionCount++;
                if (activity is ListingActivity) listingCount++;
            }
            else
            {

                Console.Clear();
                Console.WriteLine("Activity Summary:");
                Console.WriteLine($"Breathing Activities Completed: {breathingCount}");
                Console.WriteLine($"Reflection Activities Completed: {reflectionCount}");
                Console.WriteLine($"Listing Activities Completed: {listingCount}");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

                running = false;
            }
        }
    }
}