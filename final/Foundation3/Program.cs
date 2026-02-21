using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Address address = new Address("123 Main St", "Phoenix", "AZ", "USA");

        Event lecture = new Lecture("Tech Seminar", "Learning all about AI", "November 3", "6:00 pm", address, "Boston Wyatt", 100);

        Event reception = new Reception("Wedding Reception", "Celebrate with us", "July 10", "8:00 pm", address, "rsvp@email.com");

        Event outdoor = new Outdoor("Pickleball Tournament", "Pickleball with the fam", "April 23", "10:30 am", address, "Sunny");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}