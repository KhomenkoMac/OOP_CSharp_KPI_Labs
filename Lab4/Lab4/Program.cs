using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class Program
    {
        private static Dictionary<string, Func<Ticket>> choise_ticketToBook = new();

        class Client
        {
            public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        }

        static int GetSeat()
        {
            Console.Write("\nSeat> ");
            return int.Parse(Console.ReadLine());
        }

        static int GetRow()
        {
            Console.Write("\nRow> ");
            return int.Parse(Console.ReadLine());
        }

        static void DisplayTickets(IEnumerable<Ticket> tickets)
        {
            int count = 0;
            foreach (var item in tickets)
            {
                Console.WriteLine("{0} - {1}", ++count, item);
            }
        }

        static void Main(string[] args)
        {

            Client c = new();

            Ticket johnWeekTicket = new()
            {
                FilmName = "John Weak",
                FilmTiming = TimeSpan.Parse("2:00:00"),
                Price = 100M,
            };

            Ticket pulpFiction = new()
            {
                FilmName = "Pulp fiction",
                FilmTiming = TimeSpan.Parse("1:30:00"),
                Price = 100M,
            };

            Ticket plemya = new()
            {
                FilmName = "Plem'ya",
                FilmTiming = TimeSpan.Parse("2:20:00"),
                Price = 100M,
            };

            var tickects = new List<Ticket>()
            {
                johnWeekTicket,
                pulpFiction,
                plemya
            };

            choise_ticketToBook.Add("1", () => johnWeekTicket.DeepClone());
            choise_ticketToBook.Add("2", () => pulpFiction.Clone());
            choise_ticketToBook.Add("3", () => plemya.DeepClone());
            
            do
            {
                Console.WriteLine("Your tickets:");
                DisplayTickets(c.Tickets);
                Console.WriteLine("-------");
                Console.ReadKey();

                Console.WriteLine("Toonight Tickets 18:00");
                
                DisplayTickets(tickects);

                Console.Write("\nEnter> ");
                
                try
                {
                    var newBooked = choise_ticketToBook[Console.ReadLine()]();
                    newBooked.Seat = GetSeat();
                    newBooked.Row = GetRow();

                    c.Tickets.Add(newBooked);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }

            } while (true);
        }
    }
}
