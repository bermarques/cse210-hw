using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "San Francisco", "CA", "USA");

        Event lecture = new Lecture("Tech Talk", "A lecture on the latest in tech.", new DateTime(2023, 9, 15), "10:00 AM", address1, "Dr. Smith", 100);
        Event reception = new Reception("Company Gala", "Annual company gala event.", new DateTime(2023, 12, 20), "6:00 PM", address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "An outdoor summer picnic for employees.", new DateTime(2023, 7, 10), "1:00 PM", address3, "Sunny with a chance of rain");

        Event[] events = [lecture, reception, outdoorGathering];


        foreach (Event ev in events)
        {
            Console.WriteLine(ev.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.FullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.ShortDescription());
            Console.WriteLine(new string('-', 50));
        }
    }
}