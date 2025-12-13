using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("88 Sunset Blvd", "Los Angeles", "CA", "USA");
        Address addr3 = new Address("500 Lake Rd", "Chicago", "IL", "USA");

        Lecture lecture = new Lecture(
            "Tech Innovations",
            "A talk about the future of AI.",
            "2025-03-01",
            "10:00 AM",
            addr1,
            "Dr. Sarah Thompson",
            150);

        Reception reception = new Reception(
            "Wedding Reception",
            "Celebrate the Johnsons!",
            "2025-04-10",
            "6:00 PM",
            addr2,
            "rsvp@events.com");

        OutdoorGathering gathering = new OutdoorGathering(
            "Spring Festival",
            "Food, games, and outdoor music.",
            "2025-05-20",
            "1:00 PM",
            addr3,
            "Sunny with light breeze");

        Event[] events = { lecture, reception, gathering };

        foreach (Event ev in events)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("-----------------------------------------------------\n");
        }
    }
}
