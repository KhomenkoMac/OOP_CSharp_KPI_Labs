using System;

namespace Part1
{
    class Program
    {
        private enum ShopVisit { Internet= 1, Real }

        private static void DisplayShopToVisit()
        {
            Console.WriteLine();
            Console.WriteLine($"{(int)ShopVisit.Internet} - {ShopVisit.Internet}");
            Console.WriteLine($"{(int)ShopVisit.Real} - {ShopVisit.Real}");
            Console.WriteLine();
        }
        private static ShopVisit GetShopVisit()
        {
            Console.Write("What shop to visit this time? >");
            return (ShopVisit)int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Client c = new()
            {
                Id = 1,
                Username = "Client1",
                Balance = 20000,
            };

            Shop shop;
            
            do
            {
                try
                {
                    DisplayShopToVisit();
                    switch (GetShopVisit())
                    {
                        case ShopVisit.Internet:
                            shop = new InternetShop();
                            break;
                        case ShopVisit.Real:
                            shop = new RealShop();
                            break;
                        default:
                            throw new InvalidOperationException("Invalid choice!");
                    }

                    shop.Run(c);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            } while (true);
        }
    }
}
