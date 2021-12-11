using System;
using System.Linq;

namespace Part1
{
    public class InternetShop : Shop
    {
        private enum InternetBuyingWays
        {
            ByCallToSupport = 1, ByWebSite
        }

        public InternetShop() : base("https://mus.shop.com") 
        {
            ShopType = "virtual";
        }

        public override void GetMoneyForGoods(Client c)
        {
            base.GetMoneyForGoods(c);
            DisplayClientBalance(c);
        }
        public override void ShowGoods()
        {
            string authorOfMessage;

            DisplayInternetBuyingWays();
            switch ((InternetBuyingWays)AskForInteger("Choose buying way"))
            {
                case InternetBuyingWays.ByCallToSupport:
                    seller = new TechSupport();
                    authorOfMessage = "099-999-99-99";
                    break;
                case InternetBuyingWays.ByWebSite:
                    seller = new WebPage();
                    authorOfMessage = "https://mus.shop.com";
                    break;
                default:
                    throw new InvalidOperationException("There is no such buying way");
            }

            var goodsList = Avaliable_goods.ToList();
            for (int i = 0; i < goodsList.Count; i++)
            {
                seller.Run(authorOfMessage, $"{i + 1} - {goodsList[i]}");
            }
        }
        
        private static void DisplayInternetBuyingWays()
        {
            Console.WriteLine();
            Console.WriteLine($"{(int)InternetBuyingWays.ByCallToSupport} - {InternetBuyingWays.ByCallToSupport}");
            Console.WriteLine($"{(int)InternetBuyingWays.ByWebSite} - {InternetBuyingWays.ByWebSite}");
            Console.WriteLine();
        }
    }
}
