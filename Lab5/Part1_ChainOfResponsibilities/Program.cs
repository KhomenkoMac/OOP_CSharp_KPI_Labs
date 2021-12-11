using Part2_ChainOfResponsibilities;
using System;

namespace Part1_ChainOfResponsibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var owner = new Person()
            {
                Firstname = "Tim",
                Lastname = "Cook",
                HaveDesireForShow = false,
                Balance = 110
            };

            Ticket t = new()
            {
                ShowName = "Сто тисяч",
                Price = 200,
                Owner = owner
            };


            Person p1 = new()
            {
                Firstname = "Tim1",
                Lastname = "Cook1",
                Ticket = null,
                HaveDesireForShow = true,
                Balance = 1000
            };

            Person p2 = new()
            {
                Firstname = "Tim2",
                Lastname = "Cook2",
                Ticket = null,
                HaveDesireForShow = false,
                Balance = 1000
            };

            Person p3 = new()
            {
                Firstname = "Tim3",
                Lastname = "Cook3",
                Ticket = null,
                HaveDesireForShow = true,
                Balance = 1250
            };

            Console.WriteLine($"Your balance: {owner.Balance}");

            t.Owner.SetNextNexus(p1).SetNextNexus(p3).SetNextNexus(p2);
            bool sold = t.Owner.ProcessBargain(t);
            
            if (!sold)
            {
                Console.WriteLine("Not sold!");
            }
            else
            {
                Console.WriteLine($"Sold to {t.Owner}");
            }
            
            Console.WriteLine($"Your balance: {owner.Balance}");
            Console.WriteLine($"not Your balance: {t.Owner.Balance}");
        }
    }
}
