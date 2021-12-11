using System;
using System.Collections.Generic;
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
            sellerContext = new();

            DisplayInternetBuyingWays();
            switch ((InternetBuyingWays)AskForInteger("Choose buying way"))
            {
                case InternetBuyingWays.ByCallToSupport:
                    sellerContext.Seller = new TechSupport();
                    sellerContext.Sellername = "099-999-99-99";
                    break;
                case InternetBuyingWays.ByWebSite:
                    sellerContext.Seller = new WebPage();
                    sellerContext.Sellername = "https://mus.shop.com";
                    break;
                default:
                    throw new InvalidOperationException("There is no such buying way");
            }

            var goodsList = Avaliable_goods.ToList();
            for (int i = 0; i < goodsList.Count; i++)
            {
                sellerContext.Message = $"{i + 1} - {goodsList[i]}";
                sellerContext.ShowSellersMessage();
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
