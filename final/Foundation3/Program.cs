using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Phoenix", "AZ", "USA");

        Address address2 = new Address("456 Canadian Ave", "Toronto", "ON", "Canada");

        Address address3 = new Address("789 Poppy Blvd", "Patterson", "CA", "USA");

        Event lecture = new Lecture("Tech Seminar", "Learning all about AI", "November 3", "6:00 pm", address1, "Boston Wyatt", 100);

        Event reception = new Reception("Wedding Reception", "Celebrate with us", "July 10", "8:00 pm", address2, "Example@email.com");

        Event outdoor = new Outdoor("Pickleball Tournament", "Pickleball with the fam", "April 23", "10:30 am", address3, "Sunny");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}