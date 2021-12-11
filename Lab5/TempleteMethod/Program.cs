using System;

namespace TempleteMethod
{
    public abstract class Shop
    {
        public void Run()
        {
            GreetCameClient();
            ShowAdressInfo();
            ShowGoods();
            GetClientPurchase();
            GetMoneyForGoods();
            DeliverGoods();
        }

        protected abstract void GreetCameClient();
        protected abstract void ShowAdressInfo();
        protected abstract void ShowGoods();
        protected abstract void GetClientPurchase();
        protected abstract void GetMoneyForGoods();
        protected abstract void DeliverGoods();

    }

    class Program
    {
        private enum ShopVisit { Internet = 1, Real }

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
            Shop shop = null;
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

                    shop.Run();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            } while (true);
        }
    }
}
