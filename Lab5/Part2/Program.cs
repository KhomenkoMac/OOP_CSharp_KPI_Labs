using Part2.Models;
using System;
using System.Linq;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new()
            {
                WantToVisitShow = false,
                Firstname = "James",
                Lastname = "Drake"
            };

            // 1
            Composite pers11 = new()
            {
                WantToVisitShow = false,
                Firstname = "James11",
                Lastname = "Drake11"
            };

            Person pers111 = new()
            {
                WantToVisitShow = false,
                Firstname = "James111",
                Lastname = "Drake111"
            };

            Person pers1111 = new()
            {
                WantToVisitShow = false,
                Firstname = "James1111",
                Lastname = "Drake1111"
            };

            Person pers11111 = new()
            {
                WantToVisitShow = true,
                Firstname = "James11111",
                Lastname = "Drake11111"
            };

            pers11.Add(pers111);
            pers11.Add(pers1111);
            pers11.Add(pers11111);
            //

            //2
            Composite pers12 = new()
            {
                WantToVisitShow = false,
                Firstname = "James12",
                Lastname = "Drake12"
            };

            Composite pers222 = new()
            {
                WantToVisitShow = false,
                Firstname = "James222",
                Lastname = "Drake222"
            };

            Composite pers2222 = new()
            {
                WantToVisitShow = true,
                Firstname = "James2222",
                Lastname = "Drake2222"
            };

            Composite pers22222 = new()
            {
                WantToVisitShow = false,
                Firstname = "James22222",
                Lastname = "Drake22222"
            };

            pers12.Add(pers222);
            pers12.Add(pers2222);
            pers12.Add(pers22222);
            //

            Composite pers13 = new()
            {
                WantToVisitShow = false,
                Firstname = "James13",
                Lastname = "Drake13"
            };

            root.Add(pers11);
            root.Add(pers12);
            root.Add(pers13);

            DesireOfShowVisitor desireVisitor = new();
            root.Accept(desireVisitor);

            foreach (var item in desireVisitor.PersonsHavingDesire)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Sold to {desireVisitor.PersonsHavingDesire.ToList()[0]}");
        }
    }
}
