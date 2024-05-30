using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Sometown", "TX", "USA");

        // Create events
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in technology", new DateTime(2024, 6, 15), "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Company Gala", "Annual company gala event", new DateTime(2024, 7, 20), "7:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun summer picnic", new DateTime(2024, 8, 5), "12:00 PM", address3, "Sunny and warm");

        // Store the events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display the details of each event
        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("\n--------------------------\n");
        }
    }
}